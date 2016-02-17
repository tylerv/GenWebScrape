using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Net;
using System.Diagnostics;

namespace GenWebScrape
{
    public partial class MainForm : Form
    {
        cookieWebClient client = new cookieWebClient();

        bool dirtyData = false;

        string currentFilename = "";

        DataTable resultsTable = new DataTable("ResultsTable");

        public MainForm()
        {
            InitializeComponent();
            InitializeDB();
        }

        #region File Operations

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentFilename = ofd.FileName;

                try
                {
                    data.Clear();
                    data.ReadXml(currentFilename);
                    data.FillLookupTables();
                    data.CleanExpiredResults();
                    DataBindStuff();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data could not be loaded.\r\n\r\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilename.Length > 0) sfd.FileName = currentFilename.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Last();

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                data.WriteXml(sfd.FileName);
                dirtyData = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilename.Length >= 1)
            {
                data.AcceptChanges();
                data.WriteXml(currentFilename);
                dirtyData = false;
            }
            else saveAsToolStripMenuItem_Click(sender, e);
        }

        #endregion

        #region Event Handlers

        private void siteDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiteDefinition frmSites = new SiteDefinition(data);

            if (frmSites.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                data.Clear();
                data.Merge(frmSites.Data);

                dirtyData = true;
                DataBindStuff();
            }
        }

        private void searchDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDefinition frmSearches = new SearchDefinition(data);

            if (frmSearches.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                data.Clear();
                data.Merge(frmSearches.Data);

                dirtyData = true;
                DataBindStuff();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (data.HasChanges() || dirtyData)
            {
                if (MessageBox.Show("The data has not been saved yet.\r\n\r\nWould you like to save?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void resultsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resultsDataGridView.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                Process.Start(resultsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
        }

        #endregion

        private void InitializeDB()
        {
            data = new DB();
            data.FillLookupTables();
        }

        private void RunSearch()
        {
            DB.SitesRow currentSite = data.Sites.FindBySiteID(int.Parse(ddlSites.SelectedValue.ToString()));

            if (currentSite != null)
            {
                resultsDataGridView.Columns.Clear();

                resultsTable.Clear();
                resultsTable.Columns.Clear();

                resultsTable.Columns.Add("resultsID", typeof(Int32));

                resultsTable.Columns["resultsID"].AutoIncrement = true;
                resultsTable.Columns["resultsID"].AutoIncrementSeed = 0;
                resultsTable.Columns["resultsID"].AutoIncrementStep = 1;

                DB.ResultSetsRow currentResultSet = data.ResultSets.NewResultSetsRow();
                currentResultSet.SearchID = int.Parse(ddlSearches.SelectedValue.ToString());
                currentResultSet.StartTime = DateTime.Now;
                data.ResultSets.AddResultSetsRow(currentResultSet);

                //TODO: Allow the user to change the expiration.
                //These Results expire 7 days from now
                currentResultSet.Expiration = new TimeSpan(7, 0, 0, 0);

                //Get current site's params.
                DB.SearchParamsRow[] parameters = (DB.SearchParamsRow[])(data.SearchParams.Select("SearchID = " + currentResultSet.SearchID));

                //Build the initial search URL
                string searchURL = currentSite.baseURL;

                if (!searchURL.EndsWith(currentSite.FirstSeparator))
                {
                    searchURL += currentSite.FirstSeparator;
                }

                foreach (DB.SearchParamsRow row in parameters)
                {
                    if (parameters.First().SearchID == row.SearchID && parameters.First().ParamID == row.ParamID) searchURL += String.Format(data.Parameters.FindByParamID(row.ParamID).FormatString, row.Value);
                    else searchURL += (currentSite.ParamSeparator + String.Format(data.Parameters.FindByParamID(row.ParamID).FormatString, row.Value));
                }


                //Make a request to the website without anything else in the URL to extablish cookies.
                HtmlAgilityPack.HtmlDocument document = GetHTML(currentSite.baseURL.Substring(0, currentSite.baseURL.IndexOf('/', 8)));

                //Retrieve the first page
                document = GetHTML(searchURL);

                if (document == null) return;

                //Check to see if we want to save the search HTML to a file.
                DB.SearchesRow currentSearch = data.Searches.FindBySearchID(currentResultSet.SearchID);
                if (currentSearch != null && currentSearch.SaveHTMLtoFile) document.Save(currentSite.Name + " - " + ddlSearches.SelectedText + DateTime.Now.ToString(" ddmmyyyy-hhmm") + ".html");

                /*
                 * Process all the pages!
                 */

                //find link for next page
                //find the max number of pages
                //loop through each page
                    //Process first page
                    //Update search URL or cookie to get next page
                    //Update Progress bar?

                DB.SitePagesDetailsRow paging = data.SitePagesDetails.FindBySiteID(currentSite.SiteID);
                
                string maxPagesSearch = "";
                int numPages = -1;

                string nextPageSearch = "";

                if (paging != null)
                {
                    if (paging.NextPageExact) nextPageSearch = "//*[@" + paging.NextPageAttribute + "='" + paging.NextPageValue + "']";
                    else nextPageSearch = "//*[contains(@" + paging.NextPageAttribute + ", '" + paging.NextPageValue + "')]";

                    if (paging.MaxPagesExact) maxPagesSearch = "//*[@" + paging.MaxPagesAttribute + "='" + paging.MaxPagesValue + "']";
                    else maxPagesSearch = "//*[contains(@" + paging.MaxPagesAttribute + ", '" + paging.MaxPagesValue + "')]";
                }

                HtmlNode foundMaxPages = null;
                if (maxPagesSearch != "") foundMaxPages= document.DocumentNode.SelectSingleNode(maxPagesSearch);

                if (foundMaxPages != null)
                {
                    if (paging.MaxPagesProp != null && foundMaxPages.Attributes.Contains(paging.MaxPagesProp))
                    {
                        if (!int.TryParse(foundMaxPages.Attributes[paging.MaxPagesProp].Value.Trim(), out numPages)) MessageBox.Show("Couldn't find the max number of pages");
                    }
                    else
                    {
                        if (!int.TryParse(foundMaxPages.InnerText.Trim(), out numPages)) MessageBox.Show("Couldn't find the max number of pages");
                    }
                }
                else numPages = 1;

                int rowNum = 0;

                for (int currentPage = 1; currentPage <= numPages; currentPage++)
                {

                    /*
                     *  Cycle through all the groups
                     */
                    DB.ResultFieldGroupsRow[] groups = (DB.ResultFieldGroupsRow[])data.ResultFieldGroups.Select("SiteID = " + currentSite.SiteID);
                    if (groups != null)
                    {
                        foreach (DB.ResultFieldGroupsRow group in groups)
                        {//In those Groups, cycle through all the results found on the page

                            string groupSearch = "";

                            if (group.ExactMatch) groupSearch = "//*[@" + group.Attribute + "='" + group.Value + "']";
                            else groupSearch = "//*[contains(@" + group.Attribute + ", '" + group.Value + "')]";
                            

                            HtmlNodeCollection foundGroups;
                            if (groupSearch != "") foundGroups = document.DocumentNode.SelectNodes(groupSearch);
                            else
                            {
                                MessageBox.Show("Couldn't generate a group search string");
                                return;
                            }

                            if (foundGroups != null)
                            {
                                DB.ResultFieldsRow[] fields = (DB.ResultFieldsRow[])data.ResultFields.Select("RFG_ID = " + group.RFG_ID);
                            
                                if (fields != null)
                                {
                                    //Prep-populate resultsTable with all the fields (columns)
                                    foreach (DB.ResultFieldsRow field in fields)
                                    {

                                        switch (data.ResultFieldType.FindByRFT_ID(field.RFT_ID).Type)
                                        {
                                            case "Link":
                                                if (!resultsTable.Columns.Contains(field.Name)) resultsTable.Columns.Add(field.Name, typeof(string));
                                                DataGridViewLinkColumn link = new DataGridViewLinkColumn();
                                                link.Name = field.Name;
                                                //link.Text = field.Name;
                                                link.DataPropertyName = field.Name;
                                                //link.UseColumnTextForLinkValue = true;
                                                if (!resultsDataGridView.Columns.Contains(field.Name)) resultsDataGridView.Columns.Add(link);
                                                break;
                                            case "Picture":
                                                if (!resultsTable.Columns.Contains(field.Name)) resultsTable.Columns.Add(field.Name, typeof(Bitmap));
                                                DataGridViewImageColumn pic = new DataGridViewImageColumn(false);
                                                pic.Name = field.Name;
                                                if (!resultsDataGridView.Columns.Contains(field.Name)) resultsDataGridView.Columns.Add(pic);
                                                break;
                                            default:
                                                if (!resultsTable.Columns.Contains(field.Name)) resultsTable.Columns.Add(field.Name, typeof(string));
                                                if (!resultsDataGridView.Columns.Contains(field.Name)) resultsDataGridView.Columns.Add(field.Name, field.Name);
                                                break;
                                        }

                                        resultsDataGridView.Columns[field.Name].DataPropertyName = field.Name;
                                        resultsDataGridView.Columns[field.Name].ToolTipText = field.Description;
                                    }

                                    foreach (HtmlNode node in foundGroups)
                                    {//For each of those results found on the page, search for all the fields
                                
                                        DataRow displayResult = resultsTable.NewRow();
                                        resultsTable.Rows.Add(displayResult);


                                        foreach (DB.ResultFieldsRow field in fields)
                                        {//For each of those fields, cycle through all the found results.

                                            string fieldSearch = "";

                                            if (field.ExactMatch) fieldSearch = ".//*[@" + field.Attribute + "='" + field.Value + "']";
                                            else fieldSearch = ".//*[contains(@" + field.Attribute + ", '" + field.Value + "')]";
                                            
                                            
                                            HtmlNode foundField;
                                            if (fieldSearch != "") foundField = node.SelectSingleNode(fieldSearch);
                                            else
                                            {
                                                MessageBox.Show("Couldn't generate a field search string");
                                                return;
                                            }

                                            if (foundField != null)
                                            {
                                                //Only bother adding to the results table is the field was actually found (after the null-check)
                                                DB.ResultsRow foundResult = data.Results.NewResultsRow();
                                                foundResult.ResultSetID = currentResultSet.ResultSetID;
                                                foundResult.ResultFieldID = field.ResultFieldID;
                                                foundResult.RowNumber = rowNum;

                                                //Get the desired Xpath (sometimes the data is in a tag that isn't 
                                                //uniquely serachable, hence the "foundField" and then a further XPath)
                                                HtmlNode foundNode = foundField.SelectSingleNode(field.XPath);

                                                //Verify the XPath found a node.
                                                if (foundNode != null)
                                                {
                                                    if (field.Property != null && foundNode.Attributes.Contains(field.Property)) foundResult.Value = foundNode.Attributes[field.Property].Value.Trim();
                                                    else foundResult.Value = foundNode.InnerText.Trim();

                                                    //Split Text if set
                                                    if (foundResult.Value != null && field.SplitRegex != null && field.SplitIndex >= 0)
                                                    {
                                                        string[] results = Regex.Split(foundResult.Value, field.SplitRegex);
                                                        if (results.Length >= field.SplitIndex - 1) foundResult.Value = results[field.SplitIndex].Trim();
                                                    }

                                                    //Replace Text if set
                                                    if (foundResult.Value != null && field.FindRegex != null && field.ReplaceRegex != null)
                                                    {
                                                        foundResult.Value = Regex.Replace(foundResult.Value, field.FindRegex, field.ReplaceRegex);
                                                    }

                                                    //foundResult.TimeStamp = DateTime.Now;
                                                    data.Results.AddResultsRow(foundResult);
                                                
                                                    //Added data to the main database, now to add it to the dataGridView table.
                                                    switch (data.ResultFieldType.FindByRFT_ID(field.RFT_ID).Type)
                                                    {
                                                        case "Link":
                                                            DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                                                            linkcell.Tag = foundResult.Value.ToString();
                                                            linkcell.UseColumnTextForLinkValue = true;
                                                            displayResult[field.Name] = foundResult.Value.ToString();
                                                            break;
                                                        case "Picture":
                                                            System.Drawing.Bitmap bmp = new Bitmap(1, 1);
                                                            try
                                                            {
                                                                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(foundResult.Value);
                                                                myRequest.Method = "GET";
                                                                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                                                                bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                                                                myResponse.Close();

                                                                displayResult[field.Name] = bmp;
                                                            }
                                                            catch
                                                            {
                                                                bmp = Properties.Resources.Delete_d.ToBitmap();
                                                            }
                                                            finally
                                                            {
                                                                displayResult[field.Name]  = bmp;
                                                            }
                                                            break;
                                                        default:
                                                            //This should be "Text"
                                                            displayResult[field.Name] = foundResult.Value.ToString();
                                                            break;
                                                    }
                                                }
                                            }
                                        }
                                        rowNum++;
                                    }
                                }
                            }
                        }
                    }

                    //Processed one page, time to get the next one (if configured).
                    if (paging != null)
                    {
                        searchURL = "";

                        HtmlNode foundNextPage = document.DocumentNode.SelectSingleNode(nextPageSearch);
                        if (foundNextPage != null)
                        {
                            if (paging.NextPageProp != null && foundNextPage.Attributes.Contains(paging.NextPageProp)) searchURL = foundNextPage.Attributes[paging.NextPageProp].Value.Trim();
                            else searchURL = foundNextPage.InnerText.Trim();
                        }

                        //Split Text if set
                        if (paging.SplitRegex != null && paging.SplitIndex >= 0)
                        {
                            string[] results = Regex.Split(searchURL, paging.SplitRegex);
                            if (results.Length >= paging.SplitIndex - 1) searchURL = results[paging.SplitIndex].Trim();
                        }

                        //Replace Text if set
                        if (paging.FindRegex != null && paging.ReplaceRegex != null) searchURL = Regex.Replace(searchURL, paging.FindRegex, paging.ReplaceRegex);


                        if (searchURL != "")
                        {
                            document = GetHTML(searchURL);
                            if (document == null) return;
                        }
                    }
                }

                currentResultSet.EndTime = DateTime.Now;
            }

            resultsBindingSource.DataSource = resultsTable;
        }

        private void DataBindStuff()
        {
            sitesBindingSource.DataSource = data;
            sitesBindingSource.DataMember = "Sites";
            sitesBindingSource.ResetBindings(false);

            searchesBindingSource.ResetBindings(false);
        }

        private HtmlAgilityPack.HtmlDocument GetHTML(string searchURL)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            try
            {
                //Get the page of search results.
                doc = client.GetPage(searchURL);

                string fixedHtml = Regex.Replace(doc.DocumentNode.OuterHtml, @"\s+", " ", RegexOptions.Singleline);
                fixedHtml = Regex.Replace(fixedHtml, @"> <", "><", RegexOptions.Singleline);
                doc.LoadHtml(fixedHtml.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Bind to progress so far (pages that have been already processed)
                if (resultsTable.Rows.Count > 0) resultsBindingSource.DataSource = resultsTable;
                return null;
            }

            return doc;
        }

    }
}

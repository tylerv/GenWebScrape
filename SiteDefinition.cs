using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenWebScrape
{
    public partial class SiteDefinition : Form
    {

        public SiteDefinition()
        {
            InitializeComponent();
        }

        public SiteDefinition(DB dataIn)
        {
            InitializeComponent();

            SiteDefDB.Merge(dataIn);
        }

        public DB Data
        {
            get { return SiteDefDB; }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            sitesBindingSource.AddNew();
            txtName.Text = "New Site " + ((System.Data.DataRowView)(sitesBindingSource.Current)).Row.ItemArray[0];
            sitesBindingSource.EndEdit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SiteDefDB.AcceptChanges();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SiteDefDB.RejectChanges();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void hasPagesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int SiteID = int.Parse(((System.Data.DataRowView)(sitesBindingSource.Current)).Row.ItemArray[0].ToString());
            DB.SitePagesDetailsRow foundRow = SiteDefDB.SitePagesDetails.FindBySiteID(SiteID);

            if (hasPagesCheckBox.Checked)
            {
                if (foundRow == null)
                {
                    //Add new row to table
                    DB.SitePagesDetailsRow myRow = SiteDefDB.SitePagesDetails.NewSitePagesDetailsRow();
                    myRow.SiteID = SiteID;
                    SiteDefDB.SitePagesDetails.AddSitePagesDetailsRow(myRow);
                }
            }
            //else if (foundRow != null) myData.SitePagesDetails.RemoveSitePagesDetailsRow(foundRow);

            foreach (Control control in gbPaging.Controls) control.Enabled = hasPagesCheckBox.Checked;
        }

        private void SiteDefinition_Load(object sender, EventArgs e)
        {
            SiteDefDB.AcceptChanges();

            sitesBindingSource.DataSource = SiteDefDB;
            paramTypeBindingSource.DataSource = SiteDefDB;
            pagingTypeBindingSource.DataSource = SiteDefDB;
        }
    }
}

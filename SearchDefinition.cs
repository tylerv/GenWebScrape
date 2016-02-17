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
    public partial class SearchDefinition : Form
    {
        public SearchDefinition()
        {
            InitializeComponent();
        }

        public SearchDefinition(DB dataIn)
        {
            InitializeComponent();

            searchDefDB.Merge(dataIn);
        }

        public DB Data
        {
            get { return searchDefDB; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            searchDefDB.AcceptChanges();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            searchDefDB.RejectChanges();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void RFG_BN_New_Click(object sender, EventArgs e)
        {
            resultFieldGroupsBindingSource.AddNew();
            txtResultGroupName.Text = "Group " + ((System.Data.DataRowView)(resultFieldGroupsBindingSource.Current)).Row.ItemArray[0];
            resultFieldGroupsBindingSource.EndEdit();
        }

        private void Searches_BN_New_Click(object sender, EventArgs e)
        {
            searchesBindingSource.AddNew();
            txtSearchName.Text = "Search " + ((System.Data.DataRowView)(searchesBindingSource.Current)).Row.ItemArray[0];
            searchesBindingSource.EndEdit();
        }

        private void SearchDefinition_Load(object sender, EventArgs e)
        {
            searchDefDB.AcceptChanges();

            //sitesBindingSource.DataSource = searchDefDB;
            //resultFieldsTypesBindingSource.DataSource = searchDefDB;
        }
    }
}

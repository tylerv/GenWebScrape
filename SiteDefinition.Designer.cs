namespace GenWebScrape
{
    partial class SiteDefinition
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label baseParamSeparatorLabel;
            System.Windows.Forms.Label paramSeparatorLabel;
            System.Windows.Forms.Label pagingTypeIDLabel;
            System.Windows.Forms.Label nextPageValueLabel;
            System.Windows.Forms.Label nextPageExactLabel;
            System.Windows.Forms.Label nextPagePropLabel;
            System.Windows.Forms.Label splitRegexLabel;
            System.Windows.Forms.Label splitIndexLabel;
            System.Windows.Forms.Label findRegexLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteDefinition));
            System.Windows.Forms.Label replaceRegexLabel;
            this.nextPageAttLabel = new System.Windows.Forms.Label();
            this.SiteDefDB = new GenWebScrape.DB();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sitesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.sitesListBox = new System.Windows.Forms.ListBox();
            this.SiteDetailsSplit = new System.Windows.Forms.SplitContainer();
            this.gbPaging = new System.Windows.Forms.GroupBox();
            this.findRegexTextBox = new System.Windows.Forms.TextBox();
            this.sitePagesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitIndexTextBox = new System.Windows.Forms.TextBox();
            this.splitRegexTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pagingTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.pagingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nextPageAttTextBox = new System.Windows.Forms.TextBox();
            this.nextPageValueTextBox = new System.Windows.Forms.TextBox();
            this.nextPageExactCheckBox = new System.Windows.Forms.CheckBox();
            this.nextPagePropTextBox = new System.Windows.Forms.TextBox();
            this.maxPagesAttTextBox = new System.Windows.Forms.TextBox();
            this.maxPagesValueTextBox = new System.Windows.Forms.TextBox();
            this.maxPagesExactCheckBox = new System.Windows.Forms.CheckBox();
            this.maxPagePropTextBox = new System.Windows.Forms.TextBox();
            this.gbSiteDetails = new System.Windows.Forms.GroupBox();
            this.paramSeparatorTextBox = new System.Windows.Forms.TextBox();
            this.baseParamSeparatorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hasPagesCheckBox = new System.Windows.Forms.CheckBox();
            this.txtBaseURL = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.parametersDataGridView = new System.Windows.Forms.DataGridView();
            this.ParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paramTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formatStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.replaceRegexTextBox = new System.Windows.Forms.TextBox();
            baseParamSeparatorLabel = new System.Windows.Forms.Label();
            paramSeparatorLabel = new System.Windows.Forms.Label();
            pagingTypeIDLabel = new System.Windows.Forms.Label();
            nextPageValueLabel = new System.Windows.Forms.Label();
            nextPageExactLabel = new System.Windows.Forms.Label();
            nextPagePropLabel = new System.Windows.Forms.Label();
            splitRegexLabel = new System.Windows.Forms.Label();
            splitIndexLabel = new System.Windows.Forms.Label();
            findRegexLabel = new System.Windows.Forms.Label();
            replaceRegexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SiteDefDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingNavigator)).BeginInit();
            this.sitesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteDetailsSplit)).BeginInit();
            this.SiteDetailsSplit.Panel1.SuspendLayout();
            this.SiteDetailsSplit.Panel2.SuspendLayout();
            this.SiteDetailsSplit.SuspendLayout();
            this.gbPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitePagesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagingTypeBindingSource)).BeginInit();
            this.gbSiteDetails.SuspendLayout();
            this.gbParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseParamSeparatorLabel
            // 
            baseParamSeparatorLabel.AutoSize = true;
            baseParamSeparatorLabel.Location = new System.Drawing.Point(6, 133);
            baseParamSeparatorLabel.Name = "baseParamSeparatorLabel";
            baseParamSeparatorLabel.Size = new System.Drawing.Size(78, 13);
            baseParamSeparatorLabel.TabIndex = 7;
            baseParamSeparatorLabel.Text = "First Separator:";
            // 
            // paramSeparatorLabel
            // 
            paramSeparatorLabel.AutoSize = true;
            paramSeparatorLabel.Location = new System.Drawing.Point(125, 133);
            paramSeparatorLabel.Name = "paramSeparatorLabel";
            paramSeparatorLabel.Size = new System.Drawing.Size(56, 13);
            paramSeparatorLabel.TabIndex = 9;
            paramSeparatorLabel.Text = "Separator:";
            // 
            // pagingTypeIDLabel
            // 
            pagingTypeIDLabel.AutoSize = true;
            pagingTypeIDLabel.Location = new System.Drawing.Point(18, 20);
            pagingTypeIDLabel.Name = "pagingTypeIDLabel";
            pagingTypeIDLabel.Size = new System.Drawing.Size(70, 13);
            pagingTypeIDLabel.TabIndex = 2;
            pagingTypeIDLabel.Text = "Paging Type:";
            // 
            // nextPageValueLabel
            // 
            nextPageValueLabel.AutoSize = true;
            nextPageValueLabel.Location = new System.Drawing.Point(39, 95);
            nextPageValueLabel.Name = "nextPageValueLabel";
            nextPageValueLabel.Size = new System.Drawing.Size(37, 13);
            nextPageValueLabel.TabIndex = 6;
            nextPageValueLabel.Text = "Value:";
            // 
            // nextPageExactLabel
            // 
            nextPageExactLabel.AutoSize = true;
            nextPageExactLabel.Location = new System.Drawing.Point(6, 116);
            nextPageExactLabel.Name = "nextPageExactLabel";
            nextPageExactLabel.Size = new System.Drawing.Size(70, 13);
            nextPageExactLabel.TabIndex = 8;
            nextPageExactLabel.Text = "Exact Match:";
            // 
            // nextPagePropLabel
            // 
            nextPagePropLabel.AutoSize = true;
            nextPagePropLabel.Location = new System.Drawing.Point(27, 139);
            nextPagePropLabel.Name = "nextPagePropLabel";
            nextPagePropLabel.Size = new System.Drawing.Size(49, 13);
            nextPagePropLabel.TabIndex = 10;
            nextPagePropLabel.Text = "Property:";
            // 
            // splitRegexLabel
            // 
            splitRegexLabel.AutoSize = true;
            splitRegexLabel.Location = new System.Drawing.Point(3, 163);
            splitRegexLabel.Name = "splitRegexLabel";
            splitRegexLabel.Size = new System.Drawing.Size(64, 13);
            splitRegexLabel.TabIndex = 20;
            splitRegexLabel.Text = "Split Regex:";
            // 
            // splitIndexLabel
            // 
            splitIndexLabel.AutoSize = true;
            splitIndexLabel.Location = new System.Drawing.Point(109, 163);
            splitIndexLabel.Name = "splitIndexLabel";
            splitIndexLabel.Size = new System.Drawing.Size(59, 13);
            splitIndexLabel.TabIndex = 21;
            splitIndexLabel.Text = "Split Index:";
            // 
            // findRegexLabel
            // 
            findRegexLabel.AutoSize = true;
            findRegexLabel.Location = new System.Drawing.Point(2, 197);
            findRegexLabel.Name = "findRegexLabel";
            findRegexLabel.Size = new System.Drawing.Size(64, 13);
            findRegexLabel.TabIndex = 22;
            findRegexLabel.Text = "Find Regex:";
            // 
            // nextPageAttLabel
            // 
            this.nextPageAttLabel.AutoSize = true;
            this.nextPageAttLabel.Location = new System.Drawing.Point(27, 69);
            this.nextPageAttLabel.Name = "nextPageAttLabel";
            this.nextPageAttLabel.Size = new System.Drawing.Size(49, 13);
            this.nextPageAttLabel.TabIndex = 4;
            this.nextPageAttLabel.Text = "Attribute:";
            // 
            // SiteDefDB
            // 
            this.SiteDefDB.DataSetName = "DB";
            this.SiteDefDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AutoScroll = true;
            this.splitMain.Panel1.Controls.Add(this.btnCancel);
            this.splitMain.Panel1.Controls.Add(this.btnOK);
            this.splitMain.Panel1.Controls.Add(this.groupBox1);
            this.splitMain.Panel1MinSize = 200;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.AutoScroll = true;
            this.splitMain.Panel2.Controls.Add(this.SiteDetailsSplit);
            this.splitMain.Size = new System.Drawing.Size(704, 499);
            this.splitMain.SplitterDistance = 200;
            this.splitMain.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(12, 464);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sitesBindingNavigator);
            this.groupBox1.Controls.Add(this.sitesListBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sites";
            // 
            // sitesBindingNavigator
            // 
            this.sitesBindingNavigator.AddNewItem = null;
            this.sitesBindingNavigator.BindingSource = this.sitesBindingSource;
            this.sitesBindingNavigator.CountItem = null;
            this.sitesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sitesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sitesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.sitesBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.sitesBindingNavigator.MoveFirstItem = null;
            this.sitesBindingNavigator.MoveLastItem = null;
            this.sitesBindingNavigator.MoveNextItem = null;
            this.sitesBindingNavigator.MovePreviousItem = null;
            this.sitesBindingNavigator.Name = "sitesBindingNavigator";
            this.sitesBindingNavigator.PositionItem = null;
            this.sitesBindingNavigator.Size = new System.Drawing.Size(188, 25);
            this.sitesBindingNavigator.TabIndex = 0;
            this.sitesBindingNavigator.Text = "bindingNavigator1";
            // 
            // sitesBindingSource
            // 
            this.sitesBindingSource.DataMember = "Sites";
            this.sitesBindingSource.DataSource = this.SiteDefDB;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // sitesListBox
            // 
            this.sitesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sitesListBox.DataSource = this.sitesBindingSource;
            this.sitesListBox.DisplayMember = "Name";
            this.sitesListBox.FormattingEnabled = true;
            this.sitesListBox.Location = new System.Drawing.Point(6, 51);
            this.sitesListBox.Name = "sitesListBox";
            this.sitesListBox.Size = new System.Drawing.Size(182, 381);
            this.sitesListBox.TabIndex = 0;
            this.sitesListBox.ValueMember = "SiteID";
            // 
            // SiteDetailsSplit
            // 
            this.SiteDetailsSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiteDetailsSplit.Location = new System.Drawing.Point(0, 0);
            this.SiteDetailsSplit.Name = "SiteDetailsSplit";
            this.SiteDetailsSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SiteDetailsSplit.Panel1
            // 
            this.SiteDetailsSplit.Panel1.AutoScroll = true;
            this.SiteDetailsSplit.Panel1.Controls.Add(this.gbPaging);
            this.SiteDetailsSplit.Panel1.Controls.Add(this.gbSiteDetails);
            this.SiteDetailsSplit.Panel1MinSize = 250;
            // 
            // SiteDetailsSplit.Panel2
            // 
            this.SiteDetailsSplit.Panel2.Controls.Add(this.gbParams);
            this.SiteDetailsSplit.Size = new System.Drawing.Size(500, 499);
            this.SiteDetailsSplit.SplitterDistance = 250;
            this.SiteDetailsSplit.TabIndex = 7;
            // 
            // gbPaging
            // 
            this.gbPaging.Controls.Add(replaceRegexLabel);
            this.gbPaging.Controls.Add(this.replaceRegexTextBox);
            this.gbPaging.Controls.Add(findRegexLabel);
            this.gbPaging.Controls.Add(this.findRegexTextBox);
            this.gbPaging.Controls.Add(splitIndexLabel);
            this.gbPaging.Controls.Add(this.splitIndexTextBox);
            this.gbPaging.Controls.Add(splitRegexLabel);
            this.gbPaging.Controls.Add(this.splitRegexTextBox);
            this.gbPaging.Controls.Add(this.label5);
            this.gbPaging.Controls.Add(this.label4);
            this.gbPaging.Controls.Add(pagingTypeIDLabel);
            this.gbPaging.Controls.Add(this.pagingTypeIDComboBox);
            this.gbPaging.Controls.Add(this.nextPageAttLabel);
            this.gbPaging.Controls.Add(this.nextPageAttTextBox);
            this.gbPaging.Controls.Add(nextPageValueLabel);
            this.gbPaging.Controls.Add(this.nextPageValueTextBox);
            this.gbPaging.Controls.Add(nextPageExactLabel);
            this.gbPaging.Controls.Add(this.nextPageExactCheckBox);
            this.gbPaging.Controls.Add(nextPagePropLabel);
            this.gbPaging.Controls.Add(this.nextPagePropTextBox);
            this.gbPaging.Controls.Add(this.maxPagesAttTextBox);
            this.gbPaging.Controls.Add(this.maxPagesValueTextBox);
            this.gbPaging.Controls.Add(this.maxPagesExactCheckBox);
            this.gbPaging.Controls.Add(this.maxPagePropTextBox);
            this.gbPaging.Location = new System.Drawing.Point(245, 9);
            this.gbPaging.Name = "gbPaging";
            this.gbPaging.Size = new System.Drawing.Size(250, 238);
            this.gbPaging.TabIndex = 0;
            this.gbPaging.TabStop = false;
            this.gbPaging.Text = "Paging";
            // 
            // findRegexTextBox
            // 
            this.findRegexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "FindRegex", true));
            this.findRegexTextBox.Location = new System.Drawing.Point(6, 213);
            this.findRegexTextBox.Name = "findRegexTextBox";
            this.findRegexTextBox.Size = new System.Drawing.Size(100, 20);
            this.findRegexTextBox.TabIndex = 23;
            // 
            // sitePagesDetailsBindingSource
            // 
            this.sitePagesDetailsBindingSource.DataMember = "Sites_SitePagesDetails";
            this.sitePagesDetailsBindingSource.DataSource = this.sitesBindingSource;
            // 
            // splitIndexTextBox
            // 
            this.splitIndexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "SplitIndex", true));
            this.splitIndexTextBox.Location = new System.Drawing.Point(112, 177);
            this.splitIndexTextBox.Name = "splitIndexTextBox";
            this.splitIndexTextBox.Size = new System.Drawing.Size(64, 20);
            this.splitIndexTextBox.TabIndex = 22;
            // 
            // splitRegexTextBox
            // 
            this.splitRegexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "SplitRegex", true));
            this.splitRegexTextBox.Location = new System.Drawing.Point(6, 177);
            this.splitRegexTextBox.Name = "splitRegexTextBox";
            this.splitRegexTextBox.Size = new System.Drawing.Size(100, 20);
            this.splitRegexTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Max Page";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Next Page";
            // 
            // pagingTypeIDComboBox
            // 
            this.pagingTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sitePagesDetailsBindingSource, "PagingTypeID", true));
            this.pagingTypeIDComboBox.DataSource = this.pagingTypeBindingSource;
            this.pagingTypeIDComboBox.DisplayMember = "Type";
            this.pagingTypeIDComboBox.FormattingEnabled = true;
            this.pagingTypeIDComboBox.Location = new System.Drawing.Point(94, 16);
            this.pagingTypeIDComboBox.Name = "pagingTypeIDComboBox";
            this.pagingTypeIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.pagingTypeIDComboBox.TabIndex = 3;
            this.pagingTypeIDComboBox.ValueMember = "PagingTypeID";
            // 
            // pagingTypeBindingSource
            // 
            this.pagingTypeBindingSource.DataMember = "PagingType";
            this.pagingTypeBindingSource.DataSource = this.SiteDefDB;
            // 
            // nextPageAttTextBox
            // 
            this.nextPageAttTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "NextPageAttribute", true));
            this.nextPageAttTextBox.Location = new System.Drawing.Point(82, 66);
            this.nextPageAttTextBox.Name = "nextPageAttTextBox";
            this.nextPageAttTextBox.Size = new System.Drawing.Size(75, 20);
            this.nextPageAttTextBox.TabIndex = 5;
            // 
            // nextPageValueTextBox
            // 
            this.nextPageValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "NextPageValue", true));
            this.nextPageValueTextBox.Location = new System.Drawing.Point(82, 92);
            this.nextPageValueTextBox.Name = "nextPageValueTextBox";
            this.nextPageValueTextBox.Size = new System.Drawing.Size(75, 20);
            this.nextPageValueTextBox.TabIndex = 7;
            // 
            // nextPageExactCheckBox
            // 
            this.nextPageExactCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sitePagesDetailsBindingSource, "NextPageExact", true));
            this.nextPageExactCheckBox.Location = new System.Drawing.Point(118, 111);
            this.nextPageExactCheckBox.Name = "nextPageExactCheckBox";
            this.nextPageExactCheckBox.Size = new System.Drawing.Size(14, 24);
            this.nextPageExactCheckBox.TabIndex = 9;
            this.nextPageExactCheckBox.UseVisualStyleBackColor = true;
            // 
            // nextPagePropTextBox
            // 
            this.nextPagePropTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "NextPageProp", true));
            this.nextPagePropTextBox.Location = new System.Drawing.Point(82, 136);
            this.nextPagePropTextBox.Name = "nextPagePropTextBox";
            this.nextPagePropTextBox.Size = new System.Drawing.Size(75, 20);
            this.nextPagePropTextBox.TabIndex = 11;
            // 
            // maxPagesAttTextBox
            // 
            this.maxPagesAttTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "MaxPagesAttribute", true));
            this.maxPagesAttTextBox.Location = new System.Drawing.Point(163, 66);
            this.maxPagesAttTextBox.Name = "maxPagesAttTextBox";
            this.maxPagesAttTextBox.Size = new System.Drawing.Size(76, 20);
            this.maxPagesAttTextBox.TabIndex = 13;
            // 
            // maxPagesValueTextBox
            // 
            this.maxPagesValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "MaxPagesValue", true));
            this.maxPagesValueTextBox.Location = new System.Drawing.Point(163, 92);
            this.maxPagesValueTextBox.Name = "maxPagesValueTextBox";
            this.maxPagesValueTextBox.Size = new System.Drawing.Size(76, 20);
            this.maxPagesValueTextBox.TabIndex = 15;
            // 
            // maxPagesExactCheckBox
            // 
            this.maxPagesExactCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sitePagesDetailsBindingSource, "MaxPagesExact", true));
            this.maxPagesExactCheckBox.Location = new System.Drawing.Point(188, 111);
            this.maxPagesExactCheckBox.Name = "maxPagesExactCheckBox";
            this.maxPagesExactCheckBox.Size = new System.Drawing.Size(20, 24);
            this.maxPagesExactCheckBox.TabIndex = 17;
            this.maxPagesExactCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxPagePropTextBox
            // 
            this.maxPagePropTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "MaxPagesProp", true));
            this.maxPagePropTextBox.Location = new System.Drawing.Point(163, 136);
            this.maxPagePropTextBox.Name = "maxPagePropTextBox";
            this.maxPagePropTextBox.Size = new System.Drawing.Size(76, 20);
            this.maxPagePropTextBox.TabIndex = 19;
            // 
            // gbSiteDetails
            // 
            this.gbSiteDetails.Controls.Add(paramSeparatorLabel);
            this.gbSiteDetails.Controls.Add(this.paramSeparatorTextBox);
            this.gbSiteDetails.Controls.Add(baseParamSeparatorLabel);
            this.gbSiteDetails.Controls.Add(this.baseParamSeparatorTextBox);
            this.gbSiteDetails.Controls.Add(this.label1);
            this.gbSiteDetails.Controls.Add(this.hasPagesCheckBox);
            this.gbSiteDetails.Controls.Add(this.txtBaseURL);
            this.gbSiteDetails.Controls.Add(this.txtDescription);
            this.gbSiteDetails.Controls.Add(this.label3);
            this.gbSiteDetails.Controls.Add(this.label2);
            this.gbSiteDetails.Controls.Add(this.txtName);
            this.gbSiteDetails.Location = new System.Drawing.Point(6, 9);
            this.gbSiteDetails.Name = "gbSiteDetails";
            this.gbSiteDetails.Size = new System.Drawing.Size(235, 238);
            this.gbSiteDetails.TabIndex = 0;
            this.gbSiteDetails.TabStop = false;
            this.gbSiteDetails.Text = "Site Details";
            // 
            // paramSeparatorTextBox
            // 
            this.paramSeparatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitesBindingSource, "ParamSeparator", true));
            this.paramSeparatorTextBox.Location = new System.Drawing.Point(128, 149);
            this.paramSeparatorTextBox.Name = "paramSeparatorTextBox";
            this.paramSeparatorTextBox.Size = new System.Drawing.Size(100, 20);
            this.paramSeparatorTextBox.TabIndex = 4;
            // 
            // baseParamSeparatorTextBox
            // 
            this.baseParamSeparatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitesBindingSource, "FirstSeparator", true));
            this.baseParamSeparatorTextBox.Location = new System.Drawing.Point(8, 149);
            this.baseParamSeparatorTextBox.Name = "baseParamSeparatorTextBox";
            this.baseParamSeparatorTextBox.Size = new System.Drawing.Size(114, 20);
            this.baseParamSeparatorTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // hasPagesCheckBox
            // 
            this.hasPagesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sitesBindingSource, "HasPages", true));
            this.hasPagesCheckBox.Location = new System.Drawing.Point(8, 173);
            this.hasPagesCheckBox.Name = "hasPagesCheckBox";
            this.hasPagesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.hasPagesCheckBox.TabIndex = 5;
            this.hasPagesCheckBox.Text = "Has Pages";
            this.hasPagesCheckBox.UseVisualStyleBackColor = true;
            this.hasPagesCheckBox.CheckedChanged += new System.EventHandler(this.hasPagesCheckBox_CheckedChanged);
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitesBindingSource, "baseURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBaseURL.Location = new System.Drawing.Point(8, 110);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.Size = new System.Drawing.Size(220, 20);
            this.txtBaseURL.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitesBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescription.Location = new System.Drawing.Point(8, 71);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitesBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtName.Location = new System.Drawing.Point(8, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 0;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.parametersDataGridView);
            this.gbParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParams.Location = new System.Drawing.Point(0, 0);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(500, 245);
            this.gbParams.TabIndex = 1;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "Search Parameters";
            // 
            // parametersDataGridView
            // 
            this.parametersDataGridView.AutoGenerateColumns = false;
            this.parametersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parametersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParamName,
            this.ParamTypeID,
            this.formatStringDataGridViewTextBoxColumn});
            this.parametersDataGridView.DataSource = this.parametersBindingSource;
            this.parametersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.parametersDataGridView.Name = "parametersDataGridView";
            this.parametersDataGridView.Size = new System.Drawing.Size(494, 226);
            this.parametersDataGridView.TabIndex = 0;
            // 
            // ParamName
            // 
            this.ParamName.DataPropertyName = "Name";
            this.ParamName.HeaderText = "Name";
            this.ParamName.Name = "ParamName";
            // 
            // ParamTypeID
            // 
            this.ParamTypeID.DataPropertyName = "ParamTypeID";
            this.ParamTypeID.DataSource = this.paramTypeBindingSource;
            this.ParamTypeID.DisplayMember = "Type";
            this.ParamTypeID.HeaderText = "Type";
            this.ParamTypeID.Name = "ParamTypeID";
            this.ParamTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamTypeID.ValueMember = "ParamTypeID";
            // 
            // paramTypeBindingSource
            // 
            this.paramTypeBindingSource.DataMember = "ParamType";
            this.paramTypeBindingSource.DataSource = this.SiteDefDB;
            // 
            // formatStringDataGridViewTextBoxColumn
            // 
            this.formatStringDataGridViewTextBoxColumn.DataPropertyName = "FormatString";
            this.formatStringDataGridViewTextBoxColumn.HeaderText = "FormatString";
            this.formatStringDataGridViewTextBoxColumn.Name = "formatStringDataGridViewTextBoxColumn";
            // 
            // parametersBindingSource
            // 
            this.parametersBindingSource.DataMember = "Sites_Parameters";
            this.parametersBindingSource.DataSource = this.sitesBindingSource;
            // 
            // replaceRegexLabel
            // 
            replaceRegexLabel.AutoSize = true;
            replaceRegexLabel.Location = new System.Drawing.Point(109, 197);
            replaceRegexLabel.Name = "replaceRegexLabel";
            replaceRegexLabel.Size = new System.Drawing.Size(84, 13);
            replaceRegexLabel.TabIndex = 23;
            replaceRegexLabel.Text = "Replace Regex:";
            // 
            // replaceRegexTextBox
            // 
            this.replaceRegexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitePagesDetailsBindingSource, "ReplaceRegex", true));
            this.replaceRegexTextBox.Location = new System.Drawing.Point(112, 213);
            this.replaceRegexTextBox.Name = "replaceRegexTextBox";
            this.replaceRegexTextBox.Size = new System.Drawing.Size(100, 20);
            this.replaceRegexTextBox.TabIndex = 24;
            // 
            // SiteDefinition
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(704, 499);
            this.ControlBox = false;
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(691, 515);
            this.Name = "SiteDefinition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Site Definition";
            this.Load += new System.EventHandler(this.SiteDefinition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SiteDefDB)).EndInit();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingNavigator)).EndInit();
            this.sitesBindingNavigator.ResumeLayout(false);
            this.sitesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).EndInit();
            this.SiteDetailsSplit.Panel1.ResumeLayout(false);
            this.SiteDetailsSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SiteDetailsSplit)).EndInit();
            this.SiteDetailsSplit.ResumeLayout(false);
            this.gbPaging.ResumeLayout(false);
            this.gbPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitePagesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagingTypeBindingSource)).EndInit();
            this.gbSiteDetails.ResumeLayout(false);
            this.gbSiteDetails.PerformLayout();
            this.gbParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parametersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.GroupBox gbSiteDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.BindingSource sitesBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseURL;
        private System.Windows.Forms.ListBox sitesListBox;
        private System.Windows.Forms.DataGridView parametersDataGridView;
        private System.Windows.Forms.BindingSource parametersBindingSource;
        private System.Windows.Forms.BindingNavigator sitesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingSource paramTypeBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.SplitContainer SiteDetailsSplit;
        private System.Windows.Forms.CheckBox hasPagesCheckBox;
        private System.Windows.Forms.GroupBox gbPaging;
        private System.Windows.Forms.BindingSource sitePagesDetailsBindingSource;
        private System.Windows.Forms.TextBox paramSeparatorTextBox;
        private System.Windows.Forms.TextBox baseParamSeparatorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pagingTypeIDComboBox;
        private System.Windows.Forms.BindingSource pagingTypeBindingSource;
        private System.Windows.Forms.TextBox nextPageAttTextBox;
        private System.Windows.Forms.TextBox nextPageValueTextBox;
        private System.Windows.Forms.CheckBox nextPageExactCheckBox;
        private System.Windows.Forms.TextBox nextPagePropTextBox;
        private System.Windows.Forms.TextBox maxPagesAttTextBox;
        private System.Windows.Forms.TextBox maxPagesValueTextBox;
        private System.Windows.Forms.CheckBox maxPagesExactCheckBox;
        private System.Windows.Forms.TextBox maxPagePropTextBox;
        private System.Windows.Forms.Label nextPageAttLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ParamTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatStringDataGridViewTextBoxColumn;
        private DB SiteDefDB;
        private System.Windows.Forms.TextBox findRegexTextBox;
        private System.Windows.Forms.TextBox splitIndexTextBox;
        private System.Windows.Forms.TextBox splitRegexTextBox;
        private System.Windows.Forms.TextBox replaceRegexTextBox;
    }
}
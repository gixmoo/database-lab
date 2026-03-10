namespace DataBase
{
    partial class BrandFK1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandFK1));
            this.shoesDataSet = new DataBase.ShoesDataSet();
            this.brand1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand1TableAdapter = new DataBase.ShoesDataSetTableAdapters.Brand1TableAdapter();
            this.tableAdapterManager = new DataBase.ShoesDataSetTableAdapters.TableAdapterManager();
            this.brand1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.brand1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brand1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataDescTb = new System.Windows.Forms.TextBox();
            this.brandL1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeL1 = new System.Windows.Forms.Label();
            this.dataBrandCTb = new System.Windows.Forms.TextBox();
            this.nameL1 = new System.Windows.Forms.Label();
            this.dataNameTb = new System.Windows.Forms.TextBox();
            this.descL1 = new System.Windows.Forms.Label();
            this.dataCodeTb = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.descContTb = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brandContTb = new System.Windows.Forms.TextBox();
            this.nameContTb = new System.Windows.Forms.TextBox();
            this.codeContTb = new System.Windows.Forms.TextBox();
            this.descL = new System.Windows.Forms.Label();
            this.brandCL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.codeL = new System.Windows.Forms.Label();
            this.countryTableAdapter = new DataBase.ShoesDataSetTableAdapters.CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand1BindingNavigator)).BeginInit();
            this.brand1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brand1DataGridView)).BeginInit();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shoesDataSet
            // 
            this.shoesDataSet.DataSetName = "ShoesDataSet";
            this.shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brand1BindingSource
            // 
            this.brand1BindingSource.DataMember = "Brand1";
            this.brand1BindingSource.DataSource = this.shoesDataSet;
            this.brand1BindingSource.PositionChanged += new System.EventHandler(this.brand1BindingSource_PositionChanged);
            // 
            // brand1TableAdapter
            // 
            this.brand1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Brand1TableAdapter = this.brand1TableAdapter;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Lining_materialTableAdapter = null;
            this.tableAdapterManager.SeasonTableAdapter = null;
            this.tableAdapterManager.Shoes_catalogue1TableAdapter = null;
            this.tableAdapterManager.Shoes_catalogueTableAdapter = null;
            this.tableAdapterManager.Sole_materialTableAdapter = null;
            this.tableAdapterManager.StyleTableAdapter = null;
            this.tableAdapterManager.Target_audienceTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.ShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Upper_materialTableAdapter = null;
            // 
            // brand1BindingNavigator
            // 
            this.brand1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.brand1BindingNavigator.BindingSource = this.brand1BindingSource;
            this.brand1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.brand1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.brand1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.brand1BindingNavigatorSaveItem});
            this.brand1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.brand1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.brand1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.brand1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.brand1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.brand1BindingNavigator.Name = "brand1BindingNavigator";
            this.brand1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.brand1BindingNavigator.Size = new System.Drawing.Size(855, 25);
            this.brand1BindingNavigator.TabIndex = 0;
            this.brand1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // brand1BindingNavigatorSaveItem
            // 
            this.brand1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brand1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("brand1BindingNavigatorSaveItem.Image")));
            this.brand1BindingNavigatorSaveItem.Name = "brand1BindingNavigatorSaveItem";
            this.brand1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.brand1BindingNavigatorSaveItem.Text = "Save Data";
            this.brand1BindingNavigatorSaveItem.Click += new System.EventHandler(this.brand1BindingNavigatorSaveItem_Click);
            // 
            // brand1DataGridView
            // 
            this.brand1DataGridView.AutoGenerateColumns = false;
            this.brand1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brand1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.brand1DataGridView.DataSource = this.brand1BindingSource;
            this.brand1DataGridView.Location = new System.Drawing.Point(12, 28);
            this.brand1DataGridView.Name = "brand1DataGridView";
            this.brand1DataGridView.Size = new System.Drawing.Size(443, 309);
            this.brand1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Brand country";
            this.dataGridViewTextBoxColumn3.HeaderText = "Brand country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CountryName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CountryName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.editBtn);
            this.gb2.Controls.Add(this.delBtn);
            this.gb2.Controls.Add(this.addBtn);
            this.gb2.Controls.Add(this.dataDescTb);
            this.gb2.Controls.Add(this.brandL1);
            this.gb2.Controls.Add(this.comboBox2);
            this.gb2.Controls.Add(this.codeL1);
            this.gb2.Controls.Add(this.dataBrandCTb);
            this.gb2.Controls.Add(this.nameL1);
            this.gb2.Controls.Add(this.dataNameTb);
            this.gb2.Controls.Add(this.descL1);
            this.gb2.Controls.Add(this.dataCodeTb);
            this.gb2.Location = new System.Drawing.Point(461, 168);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(389, 169);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "Data bindings for edit";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(284, 125);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 20;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(156, 125);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 19;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 125);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataDescTb
            // 
            this.dataDescTb.Location = new System.Drawing.Point(138, 95);
            this.dataDescTb.Name = "dataDescTb";
            this.dataDescTb.Size = new System.Drawing.Size(221, 20);
            this.dataDescTb.TabIndex = 17;
            // 
            // brandL1
            // 
            this.brandL1.AutoSize = true;
            this.brandL1.Location = new System.Drawing.Point(27, 71);
            this.brandL1.Name = "brandL1";
            this.brandL1.Size = new System.Drawing.Size(73, 13);
            this.brandL1.TabIndex = 11;
            this.brandL1.Text = "Brand country";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.countryBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(251, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "Code";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.shoesDataSet;
            // 
            // codeL1
            // 
            this.codeL1.AutoSize = true;
            this.codeL1.Location = new System.Drawing.Point(27, 20);
            this.codeL1.Name = "codeL1";
            this.codeL1.Size = new System.Drawing.Size(32, 13);
            this.codeL1.TabIndex = 9;
            this.codeL1.Text = "Code";
            // 
            // dataBrandCTb
            // 
            this.dataBrandCTb.Location = new System.Drawing.Point(138, 71);
            this.dataBrandCTb.Name = "dataBrandCTb";
            this.dataBrandCTb.Size = new System.Drawing.Size(107, 20);
            this.dataBrandCTb.TabIndex = 15;
            // 
            // nameL1
            // 
            this.nameL1.AutoSize = true;
            this.nameL1.Location = new System.Drawing.Point(27, 44);
            this.nameL1.Name = "nameL1";
            this.nameL1.Size = new System.Drawing.Size(35, 13);
            this.nameL1.TabIndex = 10;
            this.nameL1.Text = "Name";
            // 
            // dataNameTb
            // 
            this.dataNameTb.Location = new System.Drawing.Point(138, 46);
            this.dataNameTb.Name = "dataNameTb";
            this.dataNameTb.Size = new System.Drawing.Size(221, 20);
            this.dataNameTb.TabIndex = 14;
            // 
            // descL1
            // 
            this.descL1.AutoSize = true;
            this.descL1.Location = new System.Drawing.Point(27, 98);
            this.descL1.Name = "descL1";
            this.descL1.Size = new System.Drawing.Size(60, 13);
            this.descL1.TabIndex = 12;
            this.descL1.Text = "Description";
            // 
            // dataCodeTb
            // 
            this.dataCodeTb.Location = new System.Drawing.Point(138, 20);
            this.dataCodeTb.Name = "dataCodeTb";
            this.dataCodeTb.Size = new System.Drawing.Size(221, 20);
            this.dataCodeTb.TabIndex = 13;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.descContTb);
            this.gb1.Controls.Add(this.comboBox1);
            this.gb1.Controls.Add(this.brandContTb);
            this.gb1.Controls.Add(this.nameContTb);
            this.gb1.Controls.Add(this.codeContTb);
            this.gb1.Controls.Add(this.descL);
            this.gb1.Controls.Add(this.brandCL);
            this.gb1.Controls.Add(this.nameL);
            this.gb1.Controls.Add(this.codeL);
            this.gb1.Location = new System.Drawing.Point(461, 28);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(389, 134);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Control bindings";
            // 
            // descContTb
            // 
            this.descContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand1BindingSource, "Description", true));
            this.descContTb.Location = new System.Drawing.Point(138, 101);
            this.descContTb.Name = "descContTb";
            this.descContTb.Size = new System.Drawing.Size(221, 20);
            this.descContTb.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.brand1BindingSource, "Brand country", true));
            this.comboBox1.DataSource = this.countryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Code";
            // 
            // brandContTb
            // 
            this.brandContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand1BindingSource, "Brand country", true));
            this.brandContTb.Location = new System.Drawing.Point(138, 77);
            this.brandContTb.Name = "brandContTb";
            this.brandContTb.Size = new System.Drawing.Size(107, 20);
            this.brandContTb.TabIndex = 6;
            // 
            // nameContTb
            // 
            this.nameContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand1BindingSource, "Name", true));
            this.nameContTb.Location = new System.Drawing.Point(138, 52);
            this.nameContTb.Name = "nameContTb";
            this.nameContTb.Size = new System.Drawing.Size(221, 20);
            this.nameContTb.TabIndex = 5;
            // 
            // codeContTb
            // 
            this.codeContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brand1BindingSource, "Code", true));
            this.codeContTb.Location = new System.Drawing.Point(138, 26);
            this.codeContTb.Name = "codeContTb";
            this.codeContTb.Size = new System.Drawing.Size(221, 20);
            this.codeContTb.TabIndex = 4;
            // 
            // descL
            // 
            this.descL.AutoSize = true;
            this.descL.Location = new System.Drawing.Point(27, 104);
            this.descL.Name = "descL";
            this.descL.Size = new System.Drawing.Size(60, 13);
            this.descL.TabIndex = 3;
            this.descL.Text = "Description";
            // 
            // brandCL
            // 
            this.brandCL.AutoSize = true;
            this.brandCL.Location = new System.Drawing.Point(27, 77);
            this.brandCL.Name = "brandCL";
            this.brandCL.Size = new System.Drawing.Size(73, 13);
            this.brandCL.TabIndex = 2;
            this.brandCL.Text = "Brand country";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(27, 50);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(35, 13);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "Name";
            // 
            // codeL
            // 
            this.codeL.AutoSize = true;
            this.codeL.Location = new System.Drawing.Point(27, 26);
            this.codeL.Name = "codeL";
            this.codeL.Size = new System.Drawing.Size(32, 13);
            this.codeL.TabIndex = 0;
            this.codeL.Text = "Code";
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // BrandFK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 344);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.brand1DataGridView);
            this.Controls.Add(this.brand1BindingNavigator);
            this.Name = "BrandFK1";
            this.Text = "BrandFK1";
            this.Load += new System.EventHandler(this.BrandFK1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand1BindingNavigator)).EndInit();
            this.brand1BindingNavigator.ResumeLayout(false);
            this.brand1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brand1DataGridView)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShoesDataSet shoesDataSet;
        private System.Windows.Forms.BindingSource brand1BindingSource;
        private ShoesDataSetTableAdapters.Brand1TableAdapter brand1TableAdapter;
        private ShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator brand1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton brand1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView brand1DataGridView;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox dataDescTb;
        private System.Windows.Forms.Label brandL1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label codeL1;
        private System.Windows.Forms.TextBox dataBrandCTb;
        private System.Windows.Forms.Label nameL1;
        private System.Windows.Forms.TextBox dataNameTb;
        private System.Windows.Forms.Label descL1;
        private System.Windows.Forms.TextBox dataCodeTb;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox descContTb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox brandContTb;
        private System.Windows.Forms.TextBox nameContTb;
        private System.Windows.Forms.TextBox codeContTb;
        private System.Windows.Forms.Label descL;
        private System.Windows.Forms.Label brandCL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label codeL;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private ShoesDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
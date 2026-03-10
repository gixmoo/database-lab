namespace DataBase
{
    partial class SeasonF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeasonF));
            this.shoesDataSet = new DataBase.ShoesDataSet();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seasonTableAdapter = new DataBase.ShoesDataSetTableAdapters.SeasonTableAdapter();
            this.tableAdapterManager = new DataBase.ShoesDataSetTableAdapters.TableAdapterManager();
            this.seasonBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.seasonBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.seasonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.codeL1 = new System.Windows.Forms.Label();
            this.nameL1 = new System.Windows.Forms.Label();
            this.dataNameTb = new System.Windows.Forms.TextBox();
            this.dataCodeTb = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.nameContTb = new System.Windows.Forms.TextBox();
            this.codeContTb = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.codeL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingNavigator)).BeginInit();
            this.seasonBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seasonDataGridView)).BeginInit();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shoesDataSet
            // 
            this.shoesDataSet.DataSetName = "ShoesDataSet";
            this.shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataMember = "Season";
            this.seasonBindingSource.DataSource = this.shoesDataSet;
            this.seasonBindingSource.PositionChanged += new System.EventHandler(this.seasonBindingSource_PositionChanged);
            // 
            // seasonTableAdapter
            // 
            this.seasonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Lining_materialTableAdapter = null;
            this.tableAdapterManager.SeasonTableAdapter = this.seasonTableAdapter;
            this.tableAdapterManager.Shoes_catalogueTableAdapter = null;
            this.tableAdapterManager.Sole_materialTableAdapter = null;
            this.tableAdapterManager.StyleTableAdapter = null;
            this.tableAdapterManager.Target_audienceTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.ShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Upper_materialTableAdapter = null;
            // 
            // seasonBindingNavigator
            // 
            this.seasonBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.seasonBindingNavigator.BindingSource = this.seasonBindingSource;
            this.seasonBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seasonBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.seasonBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.seasonBindingNavigatorSaveItem});
            this.seasonBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seasonBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seasonBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seasonBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seasonBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seasonBindingNavigator.Name = "seasonBindingNavigator";
            this.seasonBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seasonBindingNavigator.Size = new System.Drawing.Size(658, 25);
            this.seasonBindingNavigator.TabIndex = 0;
            this.seasonBindingNavigator.Text = "bindingNavigator1";
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
            // seasonBindingNavigatorSaveItem
            // 
            this.seasonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seasonBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seasonBindingNavigatorSaveItem.Image")));
            this.seasonBindingNavigatorSaveItem.Name = "seasonBindingNavigatorSaveItem";
            this.seasonBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seasonBindingNavigatorSaveItem.Text = "Save Data";
            this.seasonBindingNavigatorSaveItem.Click += new System.EventHandler(this.seasonBindingNavigatorSaveItem_Click);
            // 
            // seasonDataGridView
            // 
            this.seasonDataGridView.AutoGenerateColumns = false;
            this.seasonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.seasonDataGridView.DataSource = this.seasonBindingSource;
            this.seasonDataGridView.Location = new System.Drawing.Point(12, 28);
            this.seasonDataGridView.Name = "seasonDataGridView";
            this.seasonDataGridView.Size = new System.Drawing.Size(244, 190);
            this.seasonDataGridView.TabIndex = 1;
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
            // gb2
            // 
            this.gb2.Controls.Add(this.editBtn);
            this.gb2.Controls.Add(this.delBtn);
            this.gb2.Controls.Add(this.addBtn);
            this.gb2.Controls.Add(this.codeL1);
            this.gb2.Controls.Add(this.nameL1);
            this.gb2.Controls.Add(this.dataNameTb);
            this.gb2.Controls.Add(this.dataCodeTb);
            this.gb2.Location = new System.Drawing.Point(262, 119);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(389, 99);
            this.gb2.TabIndex = 7;
            this.gb2.TabStop = false;
            this.gb2.Text = "Data bindings for edit";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(284, 72);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 20;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(152, 72);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 19;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 72);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            // dataCodeTb
            // 
            this.dataCodeTb.Location = new System.Drawing.Point(138, 20);
            this.dataCodeTb.Name = "dataCodeTb";
            this.dataCodeTb.Size = new System.Drawing.Size(221, 20);
            this.dataCodeTb.TabIndex = 13;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.nameContTb);
            this.gb1.Controls.Add(this.codeContTb);
            this.gb1.Controls.Add(this.nameL);
            this.gb1.Controls.Add(this.codeL);
            this.gb1.Location = new System.Drawing.Point(262, 28);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(389, 85);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Text = "Control bindings";
            // 
            // nameContTb
            // 
            this.nameContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonBindingSource, "Name", true));
            this.nameContTb.Location = new System.Drawing.Point(138, 52);
            this.nameContTb.Name = "nameContTb";
            this.nameContTb.Size = new System.Drawing.Size(221, 20);
            this.nameContTb.TabIndex = 5;
            // 
            // codeContTb
            // 
            this.codeContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonBindingSource, "Code", true));
            this.codeContTb.Location = new System.Drawing.Point(138, 26);
            this.codeContTb.Name = "codeContTb";
            this.codeContTb.Size = new System.Drawing.Size(221, 20);
            this.codeContTb.TabIndex = 4;
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
            // SeasonF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 222);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.seasonDataGridView);
            this.Controls.Add(this.seasonBindingNavigator);
            this.Name = "SeasonF";
            this.Text = "a";
            this.Load += new System.EventHandler(this.SeasonF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingNavigator)).EndInit();
            this.seasonBindingNavigator.ResumeLayout(false);
            this.seasonBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seasonDataGridView)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShoesDataSet shoesDataSet;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private ShoesDataSetTableAdapters.SeasonTableAdapter seasonTableAdapter;
        private ShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator seasonBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton seasonBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView seasonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label codeL1;
        private System.Windows.Forms.Label nameL1;
        private System.Windows.Forms.TextBox dataNameTb;
        private System.Windows.Forms.TextBox dataCodeTb;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox nameContTb;
        private System.Windows.Forms.TextBox codeContTb;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label codeL;
    }
}
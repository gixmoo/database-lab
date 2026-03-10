namespace DataBase
{
    partial class SoleF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoleF));
            this.shoesDataSet = new DataBase.ShoesDataSet();
            this.sole_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sole_materialTableAdapter = new DataBase.ShoesDataSetTableAdapters.Sole_materialTableAdapter();
            this.tableAdapterManager = new DataBase.ShoesDataSetTableAdapters.TableAdapterManager();
            this.sole_materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sole_materialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sole_materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.dataDescTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.codeL1 = new System.Windows.Forms.Label();
            this.nameL1 = new System.Windows.Forms.Label();
            this.dataNameTb = new System.Windows.Forms.TextBox();
            this.dataCodeTb = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.descContTb = new System.Windows.Forms.TextBox();
            this.descL = new System.Windows.Forms.Label();
            this.nameContTb = new System.Windows.Forms.TextBox();
            this.codeContTb = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.codeL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sole_materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sole_materialBindingNavigator)).BeginInit();
            this.sole_materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sole_materialDataGridView)).BeginInit();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shoesDataSet
            // 
            this.shoesDataSet.DataSetName = "ShoesDataSet";
            this.shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sole_materialBindingSource
            // 
            this.sole_materialBindingSource.DataMember = "Sole material";
            this.sole_materialBindingSource.DataSource = this.shoesDataSet;
            this.sole_materialBindingSource.PositionChanged += new System.EventHandler(this.sole_materialBindingSource_PositionChanged);
            // 
            // sole_materialTableAdapter
            // 
            this.sole_materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Lining_materialTableAdapter = null;
            this.tableAdapterManager.SeasonTableAdapter = null;
            this.tableAdapterManager.Shoes_catalogueTableAdapter = null;
            this.tableAdapterManager.Sole_materialTableAdapter = this.sole_materialTableAdapter;
            this.tableAdapterManager.StyleTableAdapter = null;
            this.tableAdapterManager.Target_audienceTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.ShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Upper_materialTableAdapter = null;
            // 
            // sole_materialBindingNavigator
            // 
            this.sole_materialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sole_materialBindingNavigator.BindingSource = this.sole_materialBindingSource;
            this.sole_materialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sole_materialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sole_materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sole_materialBindingNavigatorSaveItem});
            this.sole_materialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sole_materialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sole_materialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sole_materialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sole_materialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sole_materialBindingNavigator.Name = "sole_materialBindingNavigator";
            this.sole_materialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sole_materialBindingNavigator.Size = new System.Drawing.Size(761, 25);
            this.sole_materialBindingNavigator.TabIndex = 0;
            this.sole_materialBindingNavigator.Text = "bindingNavigator1";
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
            // sole_materialBindingNavigatorSaveItem
            // 
            this.sole_materialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sole_materialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sole_materialBindingNavigatorSaveItem.Image")));
            this.sole_materialBindingNavigatorSaveItem.Name = "sole_materialBindingNavigatorSaveItem";
            this.sole_materialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sole_materialBindingNavigatorSaveItem.Text = "Save Data";
            this.sole_materialBindingNavigatorSaveItem.Click += new System.EventHandler(this.sole_materialBindingNavigatorSaveItem_Click);
            // 
            // sole_materialDataGridView
            // 
            this.sole_materialDataGridView.AutoGenerateColumns = false;
            this.sole_materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sole_materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sole_materialDataGridView.DataSource = this.sole_materialBindingSource;
            this.sole_materialDataGridView.Location = new System.Drawing.Point(12, 28);
            this.sole_materialDataGridView.Name = "sole_materialDataGridView";
            this.sole_materialDataGridView.Size = new System.Drawing.Size(344, 260);
            this.sole_materialDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.dataDescTb);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Controls.Add(this.editBtn);
            this.gb2.Controls.Add(this.delBtn);
            this.gb2.Controls.Add(this.addBtn);
            this.gb2.Controls.Add(this.codeL1);
            this.gb2.Controls.Add(this.nameL1);
            this.gb2.Controls.Add(this.dataNameTb);
            this.gb2.Controls.Add(this.dataCodeTb);
            this.gb2.Location = new System.Drawing.Point(362, 149);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(389, 139);
            this.gb2.TabIndex = 11;
            this.gb2.TabStop = false;
            this.gb2.Text = "Data bindings for edit";
            // 
            // dataDescTb
            // 
            this.dataDescTb.Location = new System.Drawing.Point(138, 72);
            this.dataDescTb.Name = "dataDescTb";
            this.dataDescTb.Size = new System.Drawing.Size(221, 20);
            this.dataDescTb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(284, 98);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 20;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(152, 98);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 19;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 98);
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
            this.gb1.Controls.Add(this.descContTb);
            this.gb1.Controls.Add(this.descL);
            this.gb1.Controls.Add(this.nameContTb);
            this.gb1.Controls.Add(this.codeContTb);
            this.gb1.Controls.Add(this.nameL);
            this.gb1.Controls.Add(this.codeL);
            this.gb1.Location = new System.Drawing.Point(362, 28);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(389, 107);
            this.gb1.TabIndex = 10;
            this.gb1.TabStop = false;
            this.gb1.Text = "Control bindings";
            // 
            // descContTb
            // 
            this.descContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sole_materialBindingSource, "Description", true));
            this.descContTb.Location = new System.Drawing.Point(138, 78);
            this.descContTb.Name = "descContTb";
            this.descContTb.Size = new System.Drawing.Size(221, 20);
            this.descContTb.TabIndex = 7;
            // 
            // descL
            // 
            this.descL.AutoSize = true;
            this.descL.Location = new System.Drawing.Point(27, 78);
            this.descL.Name = "descL";
            this.descL.Size = new System.Drawing.Size(60, 13);
            this.descL.TabIndex = 6;
            this.descL.Text = "Description";
            // 
            // nameContTb
            // 
            this.nameContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sole_materialBindingSource, "Name", true));
            this.nameContTb.Location = new System.Drawing.Point(138, 52);
            this.nameContTb.Name = "nameContTb";
            this.nameContTb.Size = new System.Drawing.Size(221, 20);
            this.nameContTb.TabIndex = 5;
            // 
            // codeContTb
            // 
            this.codeContTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sole_materialBindingSource, "Code", true));
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
            // SoleF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 297);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.sole_materialDataGridView);
            this.Controls.Add(this.sole_materialBindingNavigator);
            this.Name = "SoleF";
            this.Text = "SoleF";
            this.Load += new System.EventHandler(this.SoleF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sole_materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sole_materialBindingNavigator)).EndInit();
            this.sole_materialBindingNavigator.ResumeLayout(false);
            this.sole_materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sole_materialDataGridView)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShoesDataSet shoesDataSet;
        private System.Windows.Forms.BindingSource sole_materialBindingSource;
        private ShoesDataSetTableAdapters.Sole_materialTableAdapter sole_materialTableAdapter;
        private ShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sole_materialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sole_materialBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sole_materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox dataDescTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label codeL1;
        private System.Windows.Forms.Label nameL1;
        private System.Windows.Forms.TextBox dataNameTb;
        private System.Windows.Forms.TextBox dataCodeTb;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox descContTb;
        private System.Windows.Forms.Label descL;
        private System.Windows.Forms.TextBox nameContTb;
        private System.Windows.Forms.TextBox codeContTb;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label codeL;
    }
}
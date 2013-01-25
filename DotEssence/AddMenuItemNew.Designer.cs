namespace DotEssence
{
    partial class AddMenuItemNew
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
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.database1DataSet = new DotEssence.Database1DataSet();
            this.categoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTblTableAdapter = new DotEssence.Database1DataSetTableAdapters.CategoryTblTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxItemName = new System.Windows.Forms.TextBox();
            this.cBoxItemCategory = new System.Windows.Forms.ComboBox();
            this.cBoxItemSubCat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ckboxItemVisible = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ckboxQuickItem = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.categoryTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTblMenuItemTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemTblTableAdapter = new DotEssence.Database1DataSetTableAdapters.MenuItemTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblMenuItemTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCategory
            // 
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(32, 13);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(121, 21);
            this.cboxCategory.TabIndex = 0;
            this.cboxCategory.Text = "Choose Category";
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.cboxCategory_SelectedIndexChanged);
            this.cboxCategory.SelectionChangeCommitted += new System.EventHandler(this.cboxCategory_SelectionChangeCommitted);
            this.cboxCategory.SelectedValueChanged += new System.EventHandler(this.cboxCategory_SelectedValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTblBindingSource
            // 
            this.categoryTblBindingSource.DataMember = "CategoryTbl";
            this.categoryTblBindingSource.DataSource = this.database1DataSet;
            // 
            // categoryTblTableAdapter
            // 
            this.categoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Sub Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Button Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Item Visible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modifier Assignment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quick Item";
            // 
            // txtboxItemName
            // 
            this.txtboxItemName.Location = new System.Drawing.Point(382, 33);
            this.txtboxItemName.Name = "txtboxItemName";
            this.txtboxItemName.Size = new System.Drawing.Size(100, 20);
            this.txtboxItemName.TabIndex = 9;
            // 
            // cBoxItemCategory
            // 
            this.cBoxItemCategory.FormattingEnabled = true;
            this.cBoxItemCategory.Location = new System.Drawing.Point(382, 59);
            this.cBoxItemCategory.Name = "cBoxItemCategory";
            this.cBoxItemCategory.Size = new System.Drawing.Size(121, 21);
            this.cBoxItemCategory.TabIndex = 10;
            // 
            // cBoxItemSubCat
            // 
            this.cBoxItemSubCat.FormattingEnabled = true;
            this.cBoxItemSubCat.Location = new System.Drawing.Point(382, 86);
            this.cBoxItemSubCat.Name = "cBoxItemSubCat";
            this.cBoxItemSubCat.Size = new System.Drawing.Size(121, 21);
            this.cBoxItemSubCat.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Button Position";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ckboxItemVisible
            // 
            this.ckboxItemVisible.AutoSize = true;
            this.ckboxItemVisible.Location = new System.Drawing.Point(382, 147);
            this.ckboxItemVisible.Name = "ckboxItemVisible";
            this.ckboxItemVisible.Size = new System.Drawing.Size(44, 17);
            this.ckboxItemVisible.TabIndex = 13;
            this.ckboxItemVisible.Text = "Yes";
            this.ckboxItemVisible.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Assign Modifiers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ckboxQuickItem
            // 
            this.ckboxQuickItem.AutoSize = true;
            this.ckboxQuickItem.Location = new System.Drawing.Point(382, 212);
            this.ckboxQuickItem.Name = "ckboxQuickItem";
            this.ckboxQuickItem.Size = new System.Drawing.Size(44, 17);
            this.ckboxQuickItem.TabIndex = 15;
            this.ckboxQuickItem.Text = "Yes";
            this.ckboxQuickItem.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(155, 268);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(317, 268);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 18;
            this.btnSaveNew.Text = "Save/New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(398, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button6_Click);
            // 
            // categoryTblBindingSource1
            // 
            this.categoryTblBindingSource1.DataMember = "CategoryTbl";
            this.categoryTblBindingSource1.DataSource = this.database1DataSet;
            // 
            // categoryTblMenuItemTblBindingSource
            // 
            this.categoryTblMenuItemTblBindingSource.DataMember = "CategoryTbl_MenuItemTbl";
            this.categoryTblMenuItemTblBindingSource.DataSource = this.categoryTblBindingSource1;
            // 
            // menuItemTblTableAdapter
            // 
            this.menuItemTblTableAdapter.ClearBeforeFill = true;
            // 
            // AddMenuItemNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 402);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ckboxQuickItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ckboxItemVisible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxItemSubCat);
            this.Controls.Add(this.cBoxItemCategory);
            this.Controls.Add(this.txtboxItemName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cboxCategory);
            this.Name = "AddMenuItemNew";
            this.Text = "Menu Items";
            this.Load += new System.EventHandler(this.AddMenuItemNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblMenuItemTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.ListBox listBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource categoryTblBindingSource;
        private Database1DataSetTableAdapters.CategoryTblTableAdapter categoryTblTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxItemName;
        private System.Windows.Forms.ComboBox cBoxItemCategory;
        private System.Windows.Forms.ComboBox cBoxItemSubCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckboxItemVisible;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckboxQuickItem;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource categoryTblBindingSource1;
        private System.Windows.Forms.BindingSource categoryTblMenuItemTblBindingSource;
        private Database1DataSetTableAdapters.MenuItemTblTableAdapter menuItemTblTableAdapter;
    }
}
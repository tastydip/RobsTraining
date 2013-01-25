namespace DotEssence
{
    partial class AddMenuCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxcategoryName = new System.Windows.Forms.TextBox();
            this.txtboxcategoryRank = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listboxCatName = new System.Windows.Forms.ListBox();
            this.listBoxCatRank = new System.Windows.Forms.ListBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Rank";
            // 
            // txtboxcategoryName
            // 
            this.txtboxcategoryName.Location = new System.Drawing.Point(122, 10);
            this.txtboxcategoryName.Name = "txtboxcategoryName";
            this.txtboxcategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtboxcategoryName.TabIndex = 2;
            this.txtboxcategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtboxcategoryRank
            // 
            this.txtboxcategoryRank.Location = new System.Drawing.Point(122, 32);
            this.txtboxcategoryRank.Name = "txtboxcategoryRank";
            this.txtboxcategoryRank.Size = new System.Drawing.Size(100, 20);
            this.txtboxcategoryRank.TabIndex = 3;
            this.txtboxcategoryRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listboxCatName
            // 
            this.listboxCatName.FormattingEnabled = true;
            this.listboxCatName.Location = new System.Drawing.Point(289, 32);
            this.listboxCatName.Name = "listboxCatName";
            this.listboxCatName.Size = new System.Drawing.Size(107, 134);
            this.listboxCatName.TabIndex = 5;
            this.listboxCatName.SelectedIndexChanged += new System.EventHandler(this.listBoxCatRank_SelectedIndexChanged);
            // 
            // listBoxCatRank
            // 
            this.listBoxCatRank.FormattingEnabled = true;
            this.listBoxCatRank.Location = new System.Drawing.Point(394, 32);
            this.listBoxCatRank.Name = "listBoxCatRank";
            this.listBoxCatRank.Size = new System.Drawing.Size(111, 134);
            this.listBoxCatRank.TabIndex = 6;
            this.listBoxCatRank.SelectedIndexChanged += new System.EventHandler(this.listBoxCatRank_SelectedIndexChanged);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(307, 12);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(0, 13);
            this.lblCatName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(297, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Category Name";
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(414, 12);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(78, 13);
            this.labelRank.TabIndex = 9;
            this.labelRank.Text = "Category Rank";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(147, 143);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // AddMenuCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 262);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.listBoxCatRank);
            this.Controls.Add(this.listboxCatName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxcategoryRank);
            this.Controls.Add(this.txtboxcategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMenuCategoryForm";
            this.Text = "AddMenuCategoryForm";
            this.Load += new System.EventHandler(this.AddMenuCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxcategoryName;
        private System.Windows.Forms.TextBox txtboxcategoryRank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listboxCatName;
        private System.Windows.Forms.ListBox listBoxCatRank;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Button btndelete;
    }
}
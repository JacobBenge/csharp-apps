
namespace JBPart5INFO2200
{
    partial class AddProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNewCategory = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtBoxProdNum = new System.Windows.Forms.TextBox();
            this.TxtBoxDescription = new System.Windows.Forms.TextBox();
            this.TxtBoxUnitsOnHand = new System.Windows.Forms.TextBox();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.TxtBoxNewCategory = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Units On Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category";
            // 
            // LblNewCategory
            // 
            this.LblNewCategory.AutoSize = true;
            this.LblNewCategory.Location = new System.Drawing.Point(357, 218);
            this.LblNewCategory.Name = "LblNewCategory";
            this.LblNewCategory.Size = new System.Drawing.Size(40, 20);
            this.LblNewCategory.TabIndex = 0;
            this.LblNewCategory.Text = "New";
            this.LblNewCategory.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(167, 301);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(336, 43);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Add and Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(432, 403);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(153, 42);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtBoxProdNum
            // 
            this.TxtBoxProdNum.Location = new System.Drawing.Point(167, 31);
            this.TxtBoxProdNum.Name = "TxtBoxProdNum";
            this.TxtBoxProdNum.Size = new System.Drawing.Size(336, 26);
            this.TxtBoxProdNum.TabIndex = 0;
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.Location = new System.Drawing.Point(167, 77);
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(336, 26);
            this.TxtBoxDescription.TabIndex = 1;
            // 
            // TxtBoxUnitsOnHand
            // 
            this.TxtBoxUnitsOnHand.Location = new System.Drawing.Point(167, 123);
            this.TxtBoxUnitsOnHand.Name = "TxtBoxUnitsOnHand";
            this.TxtBoxUnitsOnHand.Size = new System.Drawing.Size(336, 26);
            this.TxtBoxUnitsOnHand.TabIndex = 2;
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Location = new System.Drawing.Point(167, 169);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(336, 26);
            this.TxtBoxPrice.TabIndex = 3;
            // 
            // TxtBoxNewCategory
            // 
            this.TxtBoxNewCategory.Location = new System.Drawing.Point(403, 215);
            this.TxtBoxNewCategory.Name = "TxtBoxNewCategory";
            this.TxtBoxNewCategory.Size = new System.Drawing.Size(100, 26);
            this.TxtBoxNewCategory.TabIndex = 5;
            this.TxtBoxNewCategory.Visible = false;
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(167, 215);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(157, 28);
            this.CbCategory.TabIndex = 4;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 457);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.TxtBoxNewCategory);
            this.Controls.Add(this.TxtBoxPrice);
            this.Controls.Add(this.TxtBoxUnitsOnHand);
            this.Controls.Add(this.TxtBoxDescription);
            this.Controls.Add(this.TxtBoxProdNum);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblNewCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProductForm";
            this.Text = "Add Product Form";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNewCategory;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBoxProdNum;
        private System.Windows.Forms.TextBox TxtBoxDescription;
        private System.Windows.Forms.TextBox TxtBoxUnitsOnHand;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.TextBox TxtBoxNewCategory;
        private System.Windows.Forms.ComboBox CbCategory;
    }
}
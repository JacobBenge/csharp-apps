
namespace JBPart5INFO2200
{
    partial class ProductSearchForm
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
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxProductDescription = new System.Windows.Forms.TextBox();
            this.BtnAddNewProd = new System.Windows.Forms.Button();
            this.BtnDeleteProd = new System.Windows.Forms.Button();
            this.CbProductId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(12, 12);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.Size = new System.Drawing.Size(776, 273);
            this.DgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Id";
            // 
            // TxtBoxProductDescription
            // 
            this.TxtBoxProductDescription.Location = new System.Drawing.Point(157, 321);
            this.TxtBoxProductDescription.Name = "TxtBoxProductDescription";
            this.TxtBoxProductDescription.Size = new System.Drawing.Size(235, 20);
            this.TxtBoxProductDescription.TabIndex = 2;
            this.TxtBoxProductDescription.TextChanged += new System.EventHandler(this.TxtBoxProductDescription_TextChanged);
            // 
            // BtnAddNewProd
            // 
            this.BtnAddNewProd.Location = new System.Drawing.Point(605, 317);
            this.BtnAddNewProd.Name = "BtnAddNewProd";
            this.BtnAddNewProd.Size = new System.Drawing.Size(159, 50);
            this.BtnAddNewProd.TabIndex = 3;
            this.BtnAddNewProd.Text = "Add New Product";
            this.BtnAddNewProd.UseVisualStyleBackColor = true;
            this.BtnAddNewProd.Click += new System.EventHandler(this.BtnAddNewProd_Click);
            // 
            // BtnDeleteProd
            // 
            this.BtnDeleteProd.Location = new System.Drawing.Point(605, 383);
            this.BtnDeleteProd.Name = "BtnDeleteProd";
            this.BtnDeleteProd.Size = new System.Drawing.Size(159, 50);
            this.BtnDeleteProd.TabIndex = 3;
            this.BtnDeleteProd.Text = "Delete Product";
            this.BtnDeleteProd.UseVisualStyleBackColor = true;
            this.BtnDeleteProd.Click += new System.EventHandler(this.BtnDeleteProd_Click);
            // 
            // CbProductId
            // 
            this.CbProductId.FormattingEnabled = true;
            this.CbProductId.Location = new System.Drawing.Point(478, 399);
            this.CbProductId.Name = "CbProductId";
            this.CbProductId.Size = new System.Drawing.Size(121, 21);
            this.CbProductId.TabIndex = 4;
            // 
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbProductId);
            this.Controls.Add(this.BtnDeleteProd);
            this.Controls.Add(this.BtnAddNewProd);
            this.Controls.Add(this.TxtBoxProductDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProducts);
            this.Name = "ProductSearchForm";
            this.Text = "Product Search Form";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxProductDescription;
        private System.Windows.Forms.Button BtnAddNewProd;
        private System.Windows.Forms.Button BtnDeleteProd;
        private System.Windows.Forms.ComboBox CbProductId;
    }
}
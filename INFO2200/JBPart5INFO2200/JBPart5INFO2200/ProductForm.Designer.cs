
namespace JBPart5INFO2200
{
    partial class ProductForm
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
            this.BtnProdSearch = new System.Windows.Forms.Button();
            this.BtnGroupCat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProdSearch
            // 
            this.BtnProdSearch.BackColor = System.Drawing.Color.DimGray;
            this.BtnProdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdSearch.ForeColor = System.Drawing.Color.White;
            this.BtnProdSearch.Location = new System.Drawing.Point(12, 393);
            this.BtnProdSearch.Name = "BtnProdSearch";
            this.BtnProdSearch.Size = new System.Drawing.Size(153, 58);
            this.BtnProdSearch.TabIndex = 1;
            this.BtnProdSearch.Text = "Product Search";
            this.BtnProdSearch.UseVisualStyleBackColor = false;
            this.BtnProdSearch.Click += new System.EventHandler(this.BtnProdSearch_Click);
            // 
            // BtnGroupCat
            // 
            this.BtnGroupCat.BackColor = System.Drawing.Color.DimGray;
            this.BtnGroupCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroupCat.ForeColor = System.Drawing.Color.White;
            this.BtnGroupCat.Location = new System.Drawing.Point(201, 393);
            this.BtnGroupCat.Name = "BtnGroupCat";
            this.BtnGroupCat.Size = new System.Drawing.Size(153, 58);
            this.BtnGroupCat.TabIndex = 1;
            this.BtnGroupCat.Text = "Group By Category";
            this.BtnGroupCat.UseVisualStyleBackColor = false;
            this.BtnGroupCat.Click += new System.EventHandler(this.BtnGroupCat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JBPart5INFO2200.Properties.Resources.before;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 463);
            this.Controls.Add(this.BtnGroupCat);
            this.Controls.Add(this.BtnProdSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductForm";
            this.Text = "Jacob\'s Clothes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnProdSearch;
        private System.Windows.Forms.Button BtnGroupCat;
    }
}


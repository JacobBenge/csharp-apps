
namespace JBAssignment5
{
    partial class LandingJBForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSearchFlavors = new System.Windows.Forms.Button();
            this.BtnShowCategories = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JBAssignment5.Properties.Resources.JellyBellyLogo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSearchFlavors
            // 
            this.BtnSearchFlavors.BackColor = System.Drawing.Color.Crimson;
            this.BtnSearchFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchFlavors.ForeColor = System.Drawing.Color.White;
            this.BtnSearchFlavors.Location = new System.Drawing.Point(96, 444);
            this.BtnSearchFlavors.Name = "BtnSearchFlavors";
            this.BtnSearchFlavors.Size = new System.Drawing.Size(311, 53);
            this.BtnSearchFlavors.TabIndex = 0;
            this.BtnSearchFlavors.Text = "Search Jelly Belly &Flavors";
            this.BtnSearchFlavors.UseVisualStyleBackColor = false;
            this.BtnSearchFlavors.Click += new System.EventHandler(this.BtnSearchFlavors_Click);
            // 
            // BtnShowCategories
            // 
            this.BtnShowCategories.BackColor = System.Drawing.Color.Crimson;
            this.BtnShowCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowCategories.ForeColor = System.Drawing.Color.White;
            this.BtnShowCategories.Location = new System.Drawing.Point(422, 444);
            this.BtnShowCategories.Name = "BtnShowCategories";
            this.BtnShowCategories.Size = new System.Drawing.Size(311, 53);
            this.BtnShowCategories.TabIndex = 1;
            this.BtnShowCategories.Text = "&Show Flavor Categories";
            this.BtnShowCategories.UseVisualStyleBackColor = false;
            this.BtnShowCategories.Click += new System.EventHandler(this.BtnShowCategories_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(331, 503);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(155, 53);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LandingJBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 580);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnShowCategories);
            this.Controls.Add(this.BtnSearchFlavors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LandingJBForm";
            this.Text = "Jelly Belly Central";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSearchFlavors;
        private System.Windows.Forms.Button BtnShowCategories;
        private System.Windows.Forms.Button BtnClose;
    }
}


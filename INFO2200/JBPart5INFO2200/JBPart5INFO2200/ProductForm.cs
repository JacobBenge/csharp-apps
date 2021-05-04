using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBPart5INFO2200
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens Product Search window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProdSearch_Click(object sender, EventArgs e)
        {
            // Instantiate the form
            ProductSearchForm productSearchForm = new ProductSearchForm();
            // Open the form in new window
            productSearchForm.ShowDialog();
        }

        /// <summary>
        /// Opens Category window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGroupCat_Click(object sender, EventArgs e)
        {
            // Instantiate the form
            CategoryForm categoryForm = new CategoryForm();
            // Open the form in new window
            categoryForm.ShowDialog();
        }
    }
}

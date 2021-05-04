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
    public partial class ProductSearchForm : Form
    {
        // connect to the Entity Framework database by calling it's constructor.
        ProductEntityDb db = new ProductEntityDb();

        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void BtnAddNewProd_Click(object sender, EventArgs e)
        {
            // Instantiate the form by calling it's constructor
            AddProductForm addProductForm = new AddProductForm();
            // Open the form in another window
            addProductForm.ShowDialog();
            // Update the table dgv
            List<Product> products = (from prod in db.Products select prod).ToList();
            //// Using LINQ. Works same as above.
            //List<Product> linqMethod = db.Products.ToList();

            // Load all products into the data grid view
            DgvProducts.DataSource = products;

            // Clear user input
            CbProductId.Items.Clear();

            // Load product numbers into combo box
            CbProductId.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
        }

        private void BtnDeleteProd_Click(object sender, EventArgs e)
        {
            // Find the product selected in the combo box, or default to null
            Product findProd = db.Products.FirstOrDefault(prod => prod.Product_Number == CbProductId.SelectedItem.ToString());

            // If product found
            if(findProd != null)
            {
                // remove
                db.Products.Remove(findProd);
                // save
                db.SaveChanges();
                // display success message
                MessageBox.Show($"{findProd.Product_Number} was successfully deleted from the database");
                // Load all database products into this list.
                List<Product> products = (from prod in db.Products select prod).ToList();
                //// Using LINQ. Works same as above.
                //List<Product> linqMethod = db.Products.ToList();

                // Load all products into the data grid view
                DgvProducts.DataSource = products;

                // Clear user input
                CbProductId.Items.Clear();

                // Load product numbers into combo box
                CbProductId.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
            }
            // product was not found
            else
            {
                // display error message
                MessageBox.Show($"Could not find {findProd.Product_Number} in the database");
            }
        }

        private void TxtBoxProductDescription_TextChanged(object sender, EventArgs e)
        {
            // Grab all products from DB that match the product description search box.
            List<Product> products = (from prod in db.Products 
                                      where prod.Description.Contains(TxtBoxProductDescription.Text) 
                                      select prod).ToList();

            //List<Product> linqMethod = db.Products.Where(prod => prod.Description.Contains(TxtBoxProductDescription.Text)).ToList();

            // update data grid view with new set of products
            DgvProducts.DataSource = products;

        }

        /// <summary>
        /// Load event occurs before user can see the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            // Load all database products into this list.
            List<Product> products = (from prod in db.Products select prod).ToList();
            //// Using LINQ. Works same as above.
            //List<Product> linqMethod = db.Products.ToList();

            // Load all products into the data grid view
            DgvProducts.DataSource = products;

            // Clear user input
            CbProductId.Items.Clear();

            // Load product numbers into combo box
            CbProductId.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
        }
    }
}

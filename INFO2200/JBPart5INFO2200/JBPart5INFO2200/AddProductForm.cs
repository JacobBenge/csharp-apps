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
    public partial class AddProductForm : Form
    {
        // connect to the database
        ProductEntityDb db = new ProductEntityDb();
        public AddProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load event occurs before user sees the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // Preload with New Category in combo box, so that we can add new categories

            CbCategory.Items.Add("New Category");
            // load unique, not null categories from the db
            var catItems = (from cat in db.Products
                            where cat.Category != null
                            group cat.Category by cat.Category into c
                            select new { Category = c.Key });
            // load the categories into the combo box
            CbCategory.Items.AddRange(catItems.Select(cats => cats.Category).ToArray());
        }

        /// <summary>
        /// Occurs when selected index changes in Combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCategory.SelectedIndex == 0)
            {
                // Show the hidden GUI features
                TxtBoxNewCategory.Show();
                LblNewCategory.Show();
            }
            else
            {
                // Hide the GUI features
                TxtBoxNewCategory.Hide();
                LblNewCategory.Hide();
            }
        }
        /// <summary>
        /// Occurs when save button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            decimal price;
            int uoh;
            string cat = "";

            // Validate user input before proceeding
            if(TxtBoxDescription.Text.Trim() != "" 
                && decimal.TryParse(TxtBoxPrice.Text, out price) 
                && int.TryParse(TxtBoxUnitsOnHand.Text, out uoh)
                && CbCategory.SelectedIndex > -1)
            {
                // Build a Product object by gathering user input
                Product newprod = new Product
                {
                    // depending if New Product is selected
                    Category = CbCategory.SelectedIndex == 0 ? TxtBoxNewCategory.Text: CbCategory.SelectedItem.ToString(),
                    Description = TxtBoxDescription.Text,
                    Price = price,
                    Product_Number = TxtBoxProdNum.Text,
                    Units_On_Hand = uoh
                };
                // add to db
                db.Products.Add(newprod);
                // save db
                db.SaveChanges();

                MessageBox.Show($"{newprod.Product_Number} was just added to the database");
                Close();
            }
            else
            {
                // default error message. Best practice do have one for each error.
                MessageBox.Show($"Please enter data for all inputs");
            }
        }
    }
}

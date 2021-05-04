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
    public partial class CategoryForm : Form
    {
        // connect to the db
        ProductEntityDb db = new ProductEntityDb();

        public CategoryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load event occurs before window is shown to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // Setup column headers
            LvCategories.Columns.Add("Category");
            LvCategories.Columns.Add("Count");

            // Obtain category counts and categories from db
            List<CatTotalViewModel> catTotals = (from cat in db.Products
                                                 group cat.Category by cat.Category into cats
                                                 select new CatTotalViewModel { ProdCat = cats.Key, CatCount = cats.Count() }).ToList();
            //List<CatTotalViewModel> linqMethod = db.Products.GroupBy(cat => cat.Category)
            //    .Select(cats => new CatTotalViewModel { ProdCat = cats.Key, CatCount = cats.Count() }).ToList();

            foreach (CatTotalViewModel item in catTotals)
            {
                // create a string with the product category and it's respective counts
                string[] listitems = { item.ProdCat, item.CatCount.ToString() };
                // call the constructor
                ListViewItem lvi = new ListViewItem(listitems);
                // add the item as a row in the list view
                LvCategories.Items.Add(lvi);
            }
            // Update column sizes adaptively
            LvCategories.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            LvCategories.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }

    public class CatTotalViewModel
    {
        public string ProdCat { get; set; }
        public int CatCount { get; set; }
    }
}

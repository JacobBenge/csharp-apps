using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBAssignment5
{
    public partial class JBCategoryForm : Form
    {
        // setup connection to database
        JBModelEntity db = new JBModelEntity();

        public JBCategoryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes the category window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Close the category window
            Close();
        }

        /// <summary>
        /// Load into the list view the categories and their counts after grouping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JBCategoryForm_Load(object sender, EventArgs e)
        {
            // Setup the column headers
            lvCategory.Columns.Add("Category");
            lvCategory.Columns.Add("Count");

            // query to group
            var jbCat2 = from j in db.JellyBellies
                         group j by j.category into x
                         select x;
            // to gather their counts
            foreach (IGrouping<String, JellyBelly> ct in jbCat2)
            {
                // store category and count in array
                String[] listValues = { ct.Key, ct.Count().ToString() };
                // call the constructor
                ListViewItem lvi = new ListViewItem(listValues);
                // add row to list view
                lvCategory.Items.Add(lvi);
            }
            lvCategory.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lvCategory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}

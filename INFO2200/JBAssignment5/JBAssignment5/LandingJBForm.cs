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
    public partial class LandingJBForm : Form
    {
        public LandingJBForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // close
            Close();
        }

        /// <summary>
        /// Open the search window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchFlavors_Click(object sender, EventArgs e)
        {
            // Instantiate the form by calling it's constructor method
            JBSearchForm jBSearchForm = new JBSearchForm();
            jBSearchForm.ShowDialog();
        }

        /// <summary>
        /// Open the categories window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowCategories_Click(object sender, EventArgs e)
        {
            // Instantiate the form by calling it's constructor method
            JBCategoryForm jBCategoryForm = new JBCategoryForm();
            jBCategoryForm.ShowDialog();

        }
    }
}

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
    public partial class JBSearchForm : Form
    {
        // setup connection to database
        JBModelEntity db = new JBModelEntity();

        public JBSearchForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes the Search Form window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // close the window
            Close();
        }

        /// <summary>
        /// Show all the rows of the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAll_Click(object sender, EventArgs e)
        {
            // Empty the search box, so all the rows show
            TxtBoxSearch.Clear();
        }
        /// <summary>
        /// Any time the textbox value changes, update the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Find all bellies that match the search box
            List<JellyBelly> jellyBellies = (from belly in db.JellyBellies
                                             where belly.jellyBellyFlavor.Contains(TxtBoxSearch.Text)
                                             select belly).ToList();
            // update the DGV
            DgvSearchForm.DataSource = jellyBellies;
        }
        /// <summary>
        /// On load, fill the table with all the products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JBSearchForm_Load(object sender, EventArgs e)
        {
            // obtain all the data and place in a list
            List<JellyBelly> jellyBellies = (from belly in db.JellyBellies
                                             select belly).ToList();
            //List<JellyBelly> linqMethod = db.JellyBellies.ToList();

            // Link up to the data grid view
            DgvSearchForm.DataSource = jellyBellies;
        }
    }
}

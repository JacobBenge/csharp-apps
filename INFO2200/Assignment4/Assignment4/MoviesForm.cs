using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200CrandallDataSet);

        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200CrandallDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200CrandallDataSet.Movie);

        }

        /// <summary>
        /// Asc Sort Btn Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSortAsc_Click(object sender, EventArgs e)
        {
            // Calls the SQL query to sort table by MovieTitle ascending order
            this.movieTableAdapter.FillByMovieTitleAsc(this.iNFO2200CrandallDataSet.Movie);
        }

        /// <summary>
        /// Desc Sort Btn Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSortDesc_Click(object sender, EventArgs e)
        {
            // Calls the SQL query to sort table by MovieTitle descending order
            this.movieTableAdapter.FillByMovieTitleDesc(this.iNFO2200CrandallDataSet.Movie);
        }

        /// <summary>
        /// Limit 20 Btn event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFirst20_Click(object sender, EventArgs e)
        {
            // Calls the SQL query to fill table with first 20 records ordered by ID
            this.movieTableAdapter.FillByFirst20(this.iNFO2200CrandallDataSet.Movie);
        }

        /// <summary>
        /// Populates the table with the rows that match the Movie Title search box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Uses the database name and textbox search box to find related record.
            this.movieTableAdapter.FillByMovieTitleSearch(this.iNFO2200CrandallDataSet.Movie, textBox1.Text);
        }

        /// <summary>
        /// Opens the Category Count dialog form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCategoryCount_Click(object sender, EventArgs e)
        {
            // Instantiate the form
            MovieDb movieDb = new MovieDb();
            // Open up a new window with the MovieDb window
            movieDb.ShowDialog();
        }
    }
}

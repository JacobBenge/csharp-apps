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
    public partial class MovieDb : Form
    {
        public MovieDb()
        {
            InitializeComponent();
        }

        private void MovieDb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200CrandallDataSet1.CountCategories' table. You can move, or remove it, as needed.
            this.countCategoriesTableAdapter.Fill(this.iNFO2200CrandallDataSet1.CountCategories);

        }
    }
}

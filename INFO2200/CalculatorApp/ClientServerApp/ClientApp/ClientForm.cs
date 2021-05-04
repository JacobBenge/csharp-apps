using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        // Load the SSC class into the form.
        SynchronousSocketClient ssc = new SynchronousSocketClient();

        public ClientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load event to load information into the form before the GUI is presented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientForm_Load(object sender, EventArgs e)
        {


        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Pass the request to the server, then load the result into the results txt box.
            TxtBoxResults.Text = ssc.ContactServer(TxtBoxRequest.Text);
        }
    }
}

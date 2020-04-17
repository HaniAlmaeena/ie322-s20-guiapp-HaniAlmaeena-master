using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hani_IE322
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                PicTry.Image = Image.FromFile("D:\\IE322_1847474\\Hani_IE322\\Blue.JPG");
            }
            catch (Exception)
            {
                MessageBox.Show("Image file not found!");
                throw;
            }
        }
    }
}

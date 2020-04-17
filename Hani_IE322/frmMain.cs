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
    public partial class frmMain : Form
    {
        string username = "Hani";
        string myPassword = "1234";
        int attempt = 1;
        int MaxAttempts = 3;
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BtnExit.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCheckBox frm = new frmCheckBox();
            frm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            while (attempt <= MaxAttempts)
            {
                if (TxtUsername.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++; 
                    return;
                }
                else
                {   // username is correct
                    // so check password                        
                    if (TxtPassword.Text != myPassword)
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 1; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        BtnLogin.Text = "Logout";
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while

            

            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPicture frm = new frmPicture();
            frm.ShowDialog();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void BtnManufacturingCell_Click(object sender, EventArgs e)
        {

        }

        private void BtnArduino_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCom_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnTalk_Click(object sender, EventArgs e)
        {
            
        }
    }
}

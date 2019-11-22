using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroidz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        //------------------------------------HANDLES BACKGROUND------------------------------------
        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            //this.Size = new Size(376, 720);
        }
        //------------------------------------------------------------------------------------------

        //-----------------------------------------BUTTONS------------------------------------------
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // check button text for proper functionality
            if (btn_Login.Text == "Login")
            {
                this.Close();
            }
            else
            {
                // check if password is correct
                if (txt_Password.Text == txt_Con_Password.Text && !string.IsNullOrWhiteSpace(txt_Password.Text) && !string.IsNullOrWhiteSpace(txt_UserName.Text))
                {
                    // close the form
                    this.Close();
                }
                else
                {
                    //-------if the password is not correct-------
                    // reset the inputs
                    txt_UserName.Text = "";
                    txt_Password.Text = "";
                    txt_Con_Password.Text = "";

                    // display error
                    lbl_LoginError.Visible = true;
                }
            }
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            // check button text for proper functionality
            if (btn_NewUser.Text == "New User")
            {
                // enable the extra inputs
                lbl_Con_Password.Visible = true;
                txt_Con_Password.Visible = true;
                txt_Con_Password.Enabled = true;

                // change button functions
                btn_Login.Text = "Create";
                btn_NewUser.Text = "Cancel";
            }
            else
            {
                // disable the extra inputs
                lbl_Con_Password.Visible = false;
                txt_Con_Password.Visible = false;
                txt_Con_Password.Enabled = false;

                // change button functions
                btn_Login.Text = "Login";
                btn_NewUser.Text = "New User";
            }
            
        }
        //------------------------------------------------------------------------------------------
    }
}

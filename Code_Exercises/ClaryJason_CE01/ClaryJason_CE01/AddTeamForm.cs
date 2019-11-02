using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
  Jason W. Clary
  Project & Portfolio 3 - 1911
  Code Exercise 01
 */

namespace ClaryJason_CE01
{
    public partial class AddTeamForm : Form
    {
      //------------------------------EVENT HANDLERS------------------------------
        public event EventHandler<TeamEventArgs> AddToMainForm;
        public event EventHandler AddButtonChecker;
      //--------------------------------------------------------------------------


        public AddTeamForm()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        // Image Background Handler
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

      //--------------------------EVENT HANDLER METHODS--------------------------
        public void MainForm_PopulateAddTeamForm(object sender, TeamEventArgs e)
        {
            // populate the user input controls from the selected ListBox object
            txt_TeamName.Text = e.TeamName;
            txt_City.Text = e.City;
            if (e.Division == "AFC")
            {
                rad_AFC.Checked = true;
            }
            else {rad_NFC.Checked = true;}
        }
      //-------------------------------------------------------------------------


      //------------------------------BUTTON CLICKS------------------------------
      // Closes the Form without changing anything
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (AddToMainForm != null)
            {
                // Create a TeamEventArgs to hold the information to pass to the main form
                TeamEventArgs newTeam = new TeamEventArgs();

                // fill in the newteam object with the user inputed information
                newTeam.TeamName = txt_TeamName.Text;
                newTeam.City = txt_City.Text;
                if (rad_AFC.Checked == true)
                {
                    newTeam.Division = rad_AFC.Text;
                }
                else { newTeam.Division = rad_NFC.Text; }

                // invoke the custom EventHandler and close form
                AddToMainForm(this, newTeam);
                this.Close();
            }

            // invoke the custom event handler
            AddButtonChecker?.Invoke(this, new EventArgs());
        }
      //-------------------------------------------------------------------------
    }
}

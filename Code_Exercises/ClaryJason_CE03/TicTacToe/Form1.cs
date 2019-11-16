using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME: Jason W. Clary
        // CLASS AND TERM: 1911
        // PROJECT: Tic Tac Toe

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */

        // Global variable to keep track of current player
        public int currentMove = 1;

        public frmTicTacToe()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        //------------------------HANDELS BACKGROUND IMAGE------------------------
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
        //------------------------------------------------------------------------

        //----------------------------------FILE----------------------------------
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //------------------------------------------------------------------------

        //----------------------------------VIEW----------------------------------
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // checks the blue option
            blueToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;

            // changes the imageList to blue
            r1c1button.ImageList = blueImages;
            r1c2button.ImageList = blueImages;
            r1c3button.ImageList = blueImages;
            r2c1button.ImageList = blueImages;
            r2c2button.ImageList = blueImages;
            r2c3button.ImageList = blueImages;
            r3c1button.ImageList = blueImages;
            r3c2button.ImageList = blueImages;
            r3c3button.ImageList = blueImages;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // checks the red option
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;

            // changes the imageList to red
            r1c1button.ImageList = redImages;
            r1c2button.ImageList = redImages;
            r1c3button.ImageList = redImages;
            r2c1button.ImageList = redImages;
            r2c2button.ImageList = redImages;
            r2c3button.ImageList = redImages;
            r3c1button.ImageList = redImages;
            r3c2button.ImageList = redImages;
            r3c3button.ImageList = redImages;
        }
        //------------------------------------------------------------------------

        //---------------------------------SELECT---------------------------------
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // checks the X option
            xToolStripMenuItem.Checked = true;
            oToolStripMenuItem.Checked = false;

            // sets the currentMove to appropriate number, 1 = "x"
            currentMove = 1;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // checks the O option
            oToolStripMenuItem.Checked = true;
            xToolStripMenuItem.Checked = false;

            // sets the currentMove to appropriate number, 0 = "o"
            currentMove = 0;
        }
        //------------------------------------------------------------------------

        //------------------------------BUTTON CLICKS-----------------------------
        void button_Click(Object sender, EventArgs e)
        {
            var button = sender as Button;

            // checks if the button is either null or has no image
            // if button has its image set, doesnt change it
            if (button != null && button.ImageIndex == -1)
            {
                switch (currentMove)
                {
                    case 0:
                        // checks the X option in select
                        xToolStripMenuItem.Checked = true;
                        oToolStripMenuItem.Checked = false;

                        // set the image 
                        button.ImageIndex = currentMove;

                        // increment counter
                        currentMove++;
                        break;
                    case 1:
                        // checks the O option in select
                        oToolStripMenuItem.Checked = true;
                        xToolStripMenuItem.Checked = false;

                        // set the image
                        button.ImageIndex = currentMove;

                        // decrement 
                        currentMove--;
                        break;
                    default:
                        break;
                }
            }
        }

        // clears the game by setting all the Image Index to -1
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // set current move back to X
            currentMove = 1;
            xToolStripMenuItem.Checked = true;
            oToolStripMenuItem.Checked = false;

            // reset all Tic Tac Toe buttons
            r1c1button.ImageIndex = -1;
            r1c2button.ImageIndex = -1;
            r1c3button.ImageIndex = -1;
            r2c1button.ImageIndex = -1;
            r2c2button.ImageIndex = -1;
            r2c3button.ImageIndex = -1;
            r3c1button.ImageIndex = -1;
            r3c2button.ImageIndex = -1;
            r3c3button.ImageIndex = -1;
        }
        //------------------------------------------------------------------------

        //--------------------------------FUNCTIONS-------------------------------
        private void CheckWinner()
        {
            // checks the top row
            if (r1c1button.ImageIndex != -1 && r1c2button.ImageIndex.Equals(r1c1button.ImageIndex) && r1c2button.ImageIndex.Equals(r1c3button.ImageIndex))
            {
                DisplayWinner(r1c1button.ImageIndex);
            }
        }

        private void DisplayWinner(int index)
        {
            // displays winning message
            switch (index)
            {
                case 0:
                    MessageBox.Show("O Wins!");
                    break;
                case 1:
                    MessageBox.Show("X Wins!");
                    break;
                default:
                    MessageBox.Show("Draw!");
                    break;
            }
        }


        //------------------------------------------------------------------------

    }
}

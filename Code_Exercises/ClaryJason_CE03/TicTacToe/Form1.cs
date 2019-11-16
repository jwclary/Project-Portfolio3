using System;
using System.Drawing;
using System.Windows.Forms;
// directive to add XMl
using System.Xml;

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

        // Global variables
        public int currentMove = 1;
        public bool defaultColor = true;

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
            try
            {
            // create the dialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\\";
            dlg.Filter = "XML Files|*.xml";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;

                // we want to make sure our reader gates only the XML
                // so we'll set it to ignore comments and whitespace
                settings.IgnoreComments = true;
                settings.IgnoreWhitespace = true;

                // using the XmlReader
                using (XmlReader reader = XmlReader.Create(dlg.FileName, settings))
                {
                    // skip the metadata
                    reader.MoveToContent();

                    // verify that this is our stock data
                    if (reader.Name != "Tic-Tac-Toe")
                    {
                        // return that this is not right
                        MessageBox.Show("These are not the data you're looking for.");
                        return;
                    }

                    // if it is, move through the data and get what we want
                    while (reader.Read())
                    {

                        // Game Color
                        if (reader.Name == "Game_Color" && reader.IsStartElement())
                        {
                            ChangeImageList(bool.Parse(reader.ReadElementContentAsString()));
                        }

                        // Row 1
                        if (reader.Name == "Row-1_Column-1" && reader.IsStartElement())
                        {
                            r1c1button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                        if (reader.Name == "Row-1_Column-2" && reader.IsStartElement())
                        {
                            r1c2button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                        if (reader.Name == "Row-1_Column-3" && reader.IsStartElement())
                        {
                            r1c3button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }

                        // Row 2
                        if (reader.Name == "Row-2_Column-1" && reader.IsStartElement())
                        {
                            r2c1button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                        if (reader.Name == "Row-2_Column-2" && reader.IsStartElement())
                        {
                            r2c2button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                        if (reader.Name == "Row-2_Column-3" && reader.IsStartElement())
                        {
                            r2c3button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }

                        // Row 3
                        if (reader.Name == "Row-3_Column-1" && reader.IsStartElement())
                        {
                            r3c1button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                        if (reader.Name == "Row-3_Column-2" && reader.IsStartElement())
                        {
                            r3c2button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                        if (reader.Name == "Row-3_Column-3" && reader.IsStartElement())
                        {
                            r3c3button.ImageIndex = int.Parse(reader.ReadElementContentAsString());
                        }
                    }
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Bad File!");
            }
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // first, we need a new instance of the Save Dialog
            SaveFileDialog dlg = new SaveFileDialog();

            // we'll also set the default extension
            dlg.DefaultExt = "xml";

            // if the user clicks the OK button
            if (DialogResult.OK == dlg.ShowDialog())
            {
                // we'll create a new instance of the XmlWriterSettings
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;

                // we'll also set the indentation of the XML
                settings.Indent = true;

                // now it's time to insrantiate the XmlWriter
                using (XmlWriter writer = XmlWriter.Create(dlg.FileName, settings))
                {
                    // the first element we want will define what the data is
                    writer.WriteStartElement("Tic-Tac-Toe");

                    // next, we'll create a child element for the stock name
                    writer.WriteStartElement("Game_Save");

                    // game color
                    writer.WriteElementString("Game_Color", defaultColor.ToString());

                    // Row 1
                    writer.WriteElementString("Row-1-Column-1", r1c1button.ImageIndex.ToString());
                    writer.WriteElementString("Row-1-Column-2", r1c2button.ImageIndex.ToString());
                    writer.WriteElementString("Row-1-Column-3", r1c3button.ImageIndex.ToString());
                    // Row 2                        
                    writer.WriteElementString("Row-2-Column-1", r2c1button.ImageIndex.ToString());
                    writer.WriteElementString("Row-2-Column-2", r2c2button.ImageIndex.ToString());
                    writer.WriteElementString("Row-2-Column-3", r2c3button.ImageIndex.ToString());
                    // Row 3                        
                    writer.WriteElementString("Row-3-Column-1", r3c1button.ImageIndex.ToString());
                    writer.WriteElementString("Row-3-Column-2", r3c2button.ImageIndex.ToString());
                    writer.WriteElementString("Row-3-Column-3", r3c3button.ImageIndex.ToString());


                    writer.WriteEndElement();

                    // close the initial element
                    writer.WriteEndElement();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //------------------------------------------------------------------------

        //----------------------------------VIEW----------------------------------
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the defaultColor bool
            defaultColor = true;
            ChangeImageList(defaultColor);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the defaultColor bool
            defaultColor = false;
            ChangeImageList(defaultColor);
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

                        // check for winner
                        CheckWinner();
                        break;
                    case 1:
                        // checks the O option in select
                        oToolStripMenuItem.Checked = true;
                        xToolStripMenuItem.Checked = false;

                        // set the image
                        button.ImageIndex = currentMove;

                        // decrement 
                        currentMove--;

                        // check for winner
                        CheckWinner();
                        break;
                    default:
                        break;
                }
            }
        }

        // clears the game by setting all the Image Index to -1
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        //------------------------------------------------------------------------

        //--------------------------------FUNCTIONS-------------------------------
        private void CheckWinner()
        {
            bool win = false;
            //------------------------------------------ROWS------------------------------------------
            // checks the top row
            if (r1c1button.ImageIndex != -1 && r1c2button.ImageIndex.Equals(r1c1button.ImageIndex) && r1c3button.ImageIndex.Equals(r1c1button.ImageIndex))
            {
                DisplayWinner(r1c1button.ImageIndex);
                win = true;
            }
            // checks the middle row
            if (r2c1button.ImageIndex != -1 && r2c2button.ImageIndex.Equals(r2c1button.ImageIndex) && r2c3button.ImageIndex.Equals(r2c1button.ImageIndex))
            {
                DisplayWinner(r2c1button.ImageIndex);
                win = true;
            }
            // checks the bottom row
            if (r3c1button.ImageIndex != -1 && r3c2button.ImageIndex.Equals(r3c1button.ImageIndex) && r3c3button.ImageIndex.Equals(r3c1button.ImageIndex))
            {
                DisplayWinner(r3c1button.ImageIndex);
                win = true;
            }

            //-----------------------------------------COLUMNS----------------------------------------
            // checks the first column
            if (r1c1button.ImageIndex != -1 && r2c1button.ImageIndex.Equals(r1c1button.ImageIndex) && r3c1button.ImageIndex.Equals(r1c1button.ImageIndex))
            {
                DisplayWinner(r1c1button.ImageIndex);
                win = true;
            }
            // checks the second column
            if (r1c2button.ImageIndex != -1 && r2c2button.ImageIndex.Equals(r1c2button.ImageIndex) && r3c2button.ImageIndex.Equals(r1c2button.ImageIndex))
            {
                DisplayWinner(r1c1button.ImageIndex);
                win = true;
            }
            // checks the third column
            if (r1c3button.ImageIndex != -1 && r2c3button.ImageIndex.Equals(r1c3button.ImageIndex) && r3c3button.ImageIndex.Equals(r1c3button.ImageIndex))
            {
                DisplayWinner(r1c3button.ImageIndex);
                win = true;
            }

            // ----------------------------------------DIAGANOLS---------------------------------------
            // checks the first column
            if (r1c1button.ImageIndex != -1 && r2c2button.ImageIndex.Equals(r1c1button.ImageIndex) && r3c3button.ImageIndex.Equals(r1c1button.ImageIndex))
            {
                DisplayWinner(r1c1button.ImageIndex);
                win = true;
            }
            // checks the second column
            if (r3c1button.ImageIndex != -1 && r2c2button.ImageIndex.Equals(r3c1button.ImageIndex) && r1c3button.ImageIndex.Equals(r3c1button.ImageIndex))
            {
                DisplayWinner(r3c1button.ImageIndex);
                win = true;
            }

            //------------------------------------------DRAW------------------------------------------
            // checks if all buttons are empty and theres still no winner
            if (r1c1button.ImageIndex > -1 && r1c2button.ImageIndex > -1 && r1c3button.ImageIndex > -1 &&
                r2c1button.ImageIndex > -1 && r2c2button.ImageIndex > -1 && r2c3button.ImageIndex > -1 &&
                r3c1button.ImageIndex > -1 && r3c2button.ImageIndex > -1 && r3c3button.ImageIndex > -1 &&
                win == false)
            {
                DisplayWinner(-1);
            }
        }

        private void DisplayWinner(int index)
        {
            // displays winning message
            switch (index)
            {
                case 0:
                    MessageBox.Show("O Wins!");
                    NewGame();
                    break;
                case 1:
                    MessageBox.Show("X Wins!");
                    NewGame();
                    break;
                default:
                    MessageBox.Show("Draw!");
                    NewGame();
                    break;
            }
        }

        private void NewGame()
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

        private void ChangeImageList(bool defaultColor)
        {
            switch (defaultColor)
            {
                case true:
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
                    break;
                case false:
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
                    break;
                default:
                    break;
            }
            //------------------------------------------------------------------------

        }
    }
}

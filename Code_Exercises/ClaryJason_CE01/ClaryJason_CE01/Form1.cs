using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
// directive to add XMl
using System.Xml;

namespace ClaryJason_CE01
{
    public partial class MainForm : Form
    {
      //------------------------------EVENT HANDLERS------------------------------
        public event EventHandler<TeamEventArgs> PopulateAddTeamForm;
      //--------------------------------------------------------------------------

      //-----------------------------GLOBAL VARIABLES-----------------------------
        public bool addButtonChecker = false;
      //--------------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();
            HandleClientWindowSize();

            // create initial data
            FootballTeam Bills = new FootballTeam("Bills", "Buffalo", "AFC");
            FootballTeam Dolphins = new FootballTeam("Dolphins", "Miami", "AFC");
            FootballTeam Patriots = new FootballTeam("Patriots", "New England", "AFC");
            FootballTeam Jets = new FootballTeam("Jets", "New York", "AFC");
            FootballTeam Cowboys = new FootballTeam("Cowboys", "Dallas", "NFC");
            FootballTeam Giants = new FootballTeam("Giants", "New York", "NFC");
            FootballTeam Eagles = new FootballTeam("Eagles", "Philadelphia", "NFC");
            FootballTeam Redskins = new FootballTeam("Redskins", "Washington", "NFC");

            // add to the lists
            lst_AFC.Items.Add(Bills);
            lst_AFC.Items.Add(Dolphins);
            lst_AFC.Items.Add(Patriots);
            lst_AFC.Items.Add(Jets);
            lst_NFC.Items.Add(Cowboys);
            lst_NFC.Items.Add(Giants);
            lst_NFC.Items.Add(Eagles);
            lst_NFC.Items.Add(Redskins);
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

      //-------------------------EVENT HANDLER METHODS-------------------------
        // event handler method to add the object to the ListBox
        public void AddToDivisionsLists(object sender, TeamEventArgs e)
        {
            // create the Character object
            FootballTeam team = new FootballTeam();
            team.TeamName = e.TeamName;
            team.City = e.City;
            team.Division = e.Division;

            // add that object to either ListBox
            if (team.Division == "AFC")
            {
                lst_AFC.Items.Add(team);
            }
            else {lst_NFC.Items.Add(team);}
        }

        // checks to see if add button was clicked when editing. deletes old object
        private void AddTeamForm_AddButtonChecker(object sender, EventArgs e)
        {
            addButtonChecker = true;

            if (addButtonChecker == true && lst_AFC.SelectedIndex > -1)
            {
                lst_AFC.Items.RemoveAt(lst_AFC.SelectedIndex);
                addButtonChecker = false;
            }
            else if (addButtonChecker == true && lst_NFC.SelectedIndex > -1)
            {
                lst_NFC.Items.RemoveAt(lst_NFC.SelectedIndex);
                addButtonChecker = false;
            }
            else { addButtonChecker = false; }
        }
      //-----------------------------------------------------------------------


      //------------------------------BUTTON CLICKS----------------------------
        private void btn_NewTeam_Click(object sender, EventArgs e)
        {
            //Instantiated new form
            AddTeamForm newTeam = new AddTeamForm();

            // subscribe to the event handler method
            newTeam.AddToMainForm += AddToDivisionsLists;

            // present the AddTeamForm
            newTeam.ShowDialog();

            // if there is any selected index reverts it to -1
            lst_AFC.SelectedIndex = -1;
            lst_NFC.SelectedIndex = -1;
        }

        private void lst_AFC_DoubleClick(object sender, EventArgs e)
        {
                //Instantiated new form
                AddTeamForm newTeam = new AddTeamForm();

                // subscribe to the event handler method
                PopulateAddTeamForm += newTeam.MainForm_PopulateAddTeamForm;
                newTeam.AddToMainForm += AddToDivisionsLists;
                newTeam.AddButtonChecker += AddTeamForm_AddButtonChecker;

                // cast the object as a Character
                FootballTeam team = (FootballTeam)lst_AFC.SelectedItem;

                // create the CharEventArgs to be sent
                TeamEventArgs args = new TeamEventArgs();
                args.TeamName = team.TeamName;
                args.City = team.City;
                args.Division = team.Division;

                // invoke the custom EventHandler
                PopulateAddTeamForm(this, args);

               // present the AddTeamForm
               newTeam.ShowDialog();

               lst_AFC.SelectedIndex = -1;
        }

        private void lst_NFC_DoubleClick(object sender, EventArgs e)
        {
                //Instantiated new form
                AddTeamForm newTeam = new AddTeamForm();

                // subscribe to the event handler method
                PopulateAddTeamForm += newTeam.MainForm_PopulateAddTeamForm;
                newTeam.AddToMainForm += AddToDivisionsLists;
                newTeam.AddButtonChecker += AddTeamForm_AddButtonChecker;
                
                // cast the object as a Character
                FootballTeam team = (FootballTeam)lst_NFC.SelectedItem;

                // create the CharEventArgs to be sent
                TeamEventArgs args = new TeamEventArgs();
                args.TeamName = team.TeamName;
                args.City = team.City;
                args.Division = team.Division;

                // invoke the custom EventHandler
                PopulateAddTeamForm(this, args);

                // present the AddTeamForm
                newTeam.ShowDialog();
               
                lst_NFC.SelectedIndex = -1;
        }

        private void lst_AFC_MouseClick(object sender, MouseEventArgs e)
        {
            // makes sure only one item is selected and activates the delete button
            lst_NFC.SelectedIndex = -1;

            btn_DeleteTeam.Enabled = true;
        }

        private void lst_NFC_MouseClick(object sender, MouseEventArgs e)
        {
            // makes sure only one item is selected and activates the delete button
            lst_AFC.SelectedIndex = -1;

            btn_DeleteTeam.Enabled = true;
        }

        private void btn_DeleteTeam_Click(object sender, EventArgs e)
        {
            // will delete an item based of the selected index then deactivate buton
            if (lst_AFC.SelectedIndex > -1)
            {
                lst_AFC.Items.RemoveAt(lst_AFC.SelectedIndex);
                btn_DeleteTeam.Enabled = false;
            }
            else
            {
                lst_NFC.Items.RemoveAt(lst_NFC.SelectedIndex);
                btn_DeleteTeam.Enabled = false;
            }
        }
        //-----------------------------------------------------------------------


        //------------------------------FILE MENU---------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
                    writer.WriteStartElement("NFL_Football_Teams");

                    // next, we'll create a child element for the stock name
                    foreach (FootballTeam item in lst_AFC.Items)
                    {
                        writer.WriteStartElement("Team");

                        writer.WriteElementString("Team_Name", item.TeamName);
                        writer.WriteElementString("City", item.City);
                        writer.WriteElementString("Division", item.Division);

                        writer.WriteEndElement();
                    }

                    foreach (FootballTeam item in lst_NFC.Items)
                    {
                        writer.WriteStartElement("Team");

                        writer.WriteElementString("Team_Name", item.TeamName);
                        writer.WriteElementString("City", item.City);
                        writer.WriteElementString("Division", item.Division);

                        writer.WriteEndElement();
                    }

                    // close the initial element
                    writer.WriteEndElement();
                }
            }
        }

            private void loadToolStripMenuItem_Click(object sender, EventArgs e)
            {
            // create the dialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\\";
            dlg.Filter = "XML Files|*.xml";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                // if clicked clear everything
                lst_AFC.Items.Clear();
                lst_NFC.Items.Clear();

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
                    if (reader.Name != "NFL_Football_Teams")
                    {
                        // return that this is not right
                        MessageBox.Show("These are not the data you're looking for.");
                        return;
                    }

                    // if it is, move through the data and get what we want
                    while (reader.Read())
                    {
                        // variable to hold retrieved data
                        string name = "";
                        string city = "";
                        string division = "";
                        if (reader.Name == "Team_Name" && reader.IsStartElement())
                        {
                            name = reader.ReadElementContentAsString();
                        }
                        if (reader.Name == "City" && reader.IsStartElement())
                        {
                            city = reader.ReadElementContentAsString();
                        }
                        if (reader.Name == "Division" && reader.IsStartElement())
                        {
                            division = reader.ReadElementContentAsString();
                        }

                        // creates a team then adds to appropriate list
                        if (division == "AFC")
                        {
                            FootballTeam team = new FootballTeam(name, city, division);
                            lst_AFC.Items.Add(team);
                        }
                        else if (division == "NFC")
                        {
                            FootballTeam team = new FootballTeam(name, city, division);
                            lst_NFC.Items.Add(team);
                        }
                    }
                }
            }
            }

            private void printToolStripMenuItem_Click(object sender, EventArgs e)
            {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Code to write the stream goes here.
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine("-----NFL Football Teams by Division-----");
                        sw.WriteLine();

                        sw.WriteLine("-------------AFC------------");
                        foreach (FootballTeam item in lst_AFC.Items)
                        {
                            sw.WriteLine($"\t{item.City} {item.TeamName}");
                        }

                        sw.WriteLine();

                        sw.WriteLine("-------------NFC------------");
                        foreach (FootballTeam item in lst_NFC.Items)
                        {
                            sw.WriteLine($"\t{item.City} {item.TeamName}");
                        }

                        sw.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Saving Data!");
            }
        }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
      //------------------------------------------------------------------------
    }


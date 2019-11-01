using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClaryJason_CE01
{
    public partial class MainForm : Form
    {
      //------------------------------EVENT HANDLERS------------------------------
        public event EventHandler<TeamEventArgs> PopulateAddTeamForm;
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
                lst_AFC.Items.Add(team.ToString());
            }
            else {lst_NFC.Items.Add(team.ToString());}
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
        }

        private void lst_AFC_DoubleClick(object sender, EventArgs e)
        {
                //Instantiated new form
                AddTeamForm newTeam = new AddTeamForm();

                // subscribe to the event handler method
                PopulateAddTeamForm += newTeam.MainForm_PopulateAddTeamForm;

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
      //-----------------------------------------------------------------------
    }
}

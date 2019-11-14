using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// directive to connect to Mysql
using MySql.Data.MySqlClient;

namespace ClaryJason_CE02
{
    public partial class MainForm : Form
    {
        // global of the database connection
        MySqlConnection conn = new MySqlConnection();
        DataTable itemData = new DataTable();
        // counter for the current row
        int currentRow = 0;
        int numOfRows = 0;
        int intIndex = 0;

        public MainForm()
        {
            InitializeComponent();
            HandleClientWindowSize();

            // invoke the method to build the connection string
            string connString = DBUtilities.BuildConnectionString();

            // invoke the method to make the connection
            conn = DBUtilities.Connect(connString);
            try
            {
                // get the data
                RetrieveData();               
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to connect to the database");
                Application.Exit();
            }

            // selects the first item and fills in the fields with its data
            lsv_Classes.Items[0].Selected = true;
            FillFields(lsv_Classes.Items[0]);
        }

      //------------------------------HANDLES BACKGROUND IMAGE------------------------------
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
      //------------------------------------------------------------------------------------

      //-------------------------------------MYSQL FUNCS------------------------------------
        private bool RetrieveData()
        {
            // create the SQL statement
            string sql = "SELECT * " +
                         "FROM Classes;";

            // create the data adapter
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

            // set the type for the SELECT command
            adr.SelectCommand.CommandType = CommandType.Text;

            // The fill method adds rows  to match the data source
            adr.Fill(itemData);

            // we can also get a couple of the rows
            numOfRows = itemData.Select().Length;

            // make sure we don't go out of range
            while (currentRow < itemData.Rows.Count)
            {
                // instantiate object to hold data
                FullSailClass course = new FullSailClass();

                course.ID = int.Parse(itemData.Rows[currentRow]["ID"].ToString());
                course.CourseName = itemData.Rows[currentRow]["CourseName"].ToString();
                course.CourseNumber = itemData.Rows[currentRow]["CourseNumber"].ToString();
                course.Term = int.Parse(itemData.Rows[currentRow]["Term"].ToString());
                course.CreditHours = double.Parse(itemData.Rows[currentRow]["CreditHours"].ToString());
                course.Track = itemData.Rows[currentRow]["Track"].ToString();

                // add to the list
                AddToClasses(course);

                // advance rows
                currentRow++;
            }
                     
            return true;
        }

        private bool UpdateData(FullSailClass course)
        {
            string stm = "UPDATE Classes " +
                         "SET CourseName = @CName, CourseNumber = @CNumber, Term = @Term, CreditHours = @CHours, Track = @Track " +
                         "WHERE ID = @itemId;";

            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@itemId", course.ID);
            cmd.Parameters.AddWithValue("@CName", course.CourseName);
            cmd.Parameters.AddWithValue("@CNumber", course.CourseNumber);
            cmd.Parameters.AddWithValue("@Term", course.Term);
            cmd.Parameters.AddWithValue("@CHours", course.CreditHours);
            cmd.Parameters.AddWithValue("@Track", course.Track);

            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();

            return true;
        }
        //------------------------------------------------------------------------------------

        //-------------------------------------FIELDS FUNCS-----------------------------------
        private bool ValidatesTextInputs(FullSailClass course)
        {
            // if textfields have all whitespace returns null
            if (string.IsNullOrWhiteSpace(txt_CName.Text))
            {
                course.CourseName = null;
            }
            else { course.CourseName = txt_CName.Text; }

            if (string.IsNullOrWhiteSpace(txt_CNumber.Text))
            {
                course.CourseNumber = null;
            }
            else { course.CourseNumber = txt_CNumber.Text; }

            return true;
        }

        private bool FillFields(ListViewItem item)
        {
            // fill in data from selected index item
            FullSailClass course = (FullSailClass)item.Tag;
            txt_CName.Text = course.CourseName;
            txt_CNumber.Text = course.CourseNumber;
            nud_Term.Value = course.Term;
            nud_Hours.Value = (decimal)course.CreditHours;
            cbx_Track.Text = course.Track;

            return true;
        }

        private bool AddToClasses(FullSailClass course)
        {
            ListViewItem item = new ListViewItem();
            item.Text = course.ToString();
            item.Tag = course;
            switch (course.Track)
            {
                case "Central":
                    item.ImageIndex = 0;
                    break;
                case "iOS":
                    item.ImageIndex = 1;
                    break;
                case "Android":
                    item.ImageIndex = 2;
                    break;
                default:
                    break;
            }
            lsv_Classes.Items.Add(item);

            return true;
        }
        //------------------------------------------------------------------------------------

        //------------------------------------BUTTON CLICKS-----------------------------------

        // button handles edit/save edit/save
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (btn_Edit.Text == "Save Edit")
            {
                // create a new object to hold the new data
                FullSailClass updatedCourse = (FullSailClass)lsv_Classes.SelectedItems[0].Tag;

                ValidatesTextInputs(updatedCourse);
                updatedCourse.Term = int.Parse(nud_Term.Value.ToString());
                updatedCourse.CreditHours = double.Parse(nud_Hours.Value.ToString());
                updatedCourse.Track = cbx_Track.Text;

                try
                {
                    // update the database
                    UpdateData(updatedCourse);

                    // equal the new data to the selected items
                    lsv_Classes.SelectedItems[0].Text = updatedCourse.ToString();
                    lsv_Classes.SelectedItems[0].Tag = updatedCourse;

                    // deactivate fields
                    txt_CName.Enabled = false;
                    txt_CNumber.Enabled = false;
                    nud_Term.Enabled = false;
                    nud_Hours.Enabled = false;
                    cbx_Track.Enabled = false;

                    // change buttons to origional purpose
                    btn_Edit.Text = "Edit";
                    btn_Delete.Text = "Delete";
                }
                catch (Exception)
                {
                    MessageBox.Show("Do Not Leave Blank");
                }
            }
            else if (btn_Edit.Text == "Add")
            {
                try
                {
                    // add new info to a new FullSailClass object
                    FullSailClass course = new FullSailClass();

                    ValidatesTextInputs(course);
                    course.Term = (int)nud_Term.Value;
                    course.CreditHours = (double)nud_Hours.Value;
                    course.Track = cbx_Track.Text;

                // gets the last added item from database and increments its ID for new item
                    FullSailClass temp = (FullSailClass)lsv_Classes.Items[lsv_Classes.Items.Count - 1].Tag;
                    course.ID = temp.ID + 1;

                    // add to the list
                    AddToClasses(course);

                    // add to database
                    string stm = "INSERT INTO Classes(ID, CourseName, CourseNumber, Term, CreditHours, Track) " +
                                 "VALUES(@itemId, @cName, @cNumber, @term, @cHours, @track)";

                    MySqlCommand cmd = new MySqlCommand(stm, conn);
                    cmd.Parameters.AddWithValue("@itemId", course.ID);
                    cmd.Parameters.AddWithValue("@cName", course.CourseName);
                    cmd.Parameters.AddWithValue("@cNumber", course.CourseNumber);
                    cmd.Parameters.AddWithValue("@term", course.Term);
                    cmd.Parameters.AddWithValue("@cHours", course.CreditHours);
                    cmd.Parameters.AddWithValue("@track", course.Track);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Close();

                    // change buttons to origional purpose
                    btn_Edit.Text = "Edit";
                    btn_Delete.Text = "Delete";
            }
                catch (Exception)
            {

                MessageBox.Show("Do Not Leave Blank");
            }
        }
            else
            {
                // enables changes
                txt_CName.Enabled = true;
                txt_CNumber.Enabled = true;
                nud_Term.Enabled = true;
                nud_Hours.Enabled = true;
                cbx_Track.Enabled = true;

                // change names of buttons to change the functionality
                btn_Edit.Text = "Save Edit";
                btn_Delete.Text = "Cancel";
            }
        }

        // button handles delete and cancel
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (btn_Delete.Text == "Cancel")
            {
                // refill in the feilds with the appropriate data
                FillFields(lsv_Classes.Items[0]);

                // deactivate fields
                txt_CName.Enabled = false;
                txt_CNumber.Enabled = false;
                nud_Term.Enabled = false;
                nud_Hours.Enabled = false;
                cbx_Track.Enabled = false;
                btn_NewCourse.Enabled = true;

                // change buttons to origional purpose
                btn_Edit.Text = "Edit";
                btn_Delete.Text = "Delete";
            }
            else
            {
                // deletes the course from the database
                FullSailClass course = (FullSailClass)lsv_Classes.SelectedItems[0].Tag;
                string stm = "DELETE FROM Classes " +
                             "WHERE ID = @itemId;";

                MySqlCommand cmd = new MySqlCommand(stm, conn);
                cmd.Parameters.AddWithValue("@itemId", course.ID);

                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();

                // deletes from view list
                lsv_Classes.SelectedItems[0].Remove();
            }
        }

        private void btn_NewCourse_Click(object sender, EventArgs e)
        {            
                // refill in the fields with the appropriate data
                txt_CName.Text = "";
                txt_CNumber.Text = "";
                nud_Term.Value = 0;
                nud_Hours.Value = 0;
                cbx_Track.SelectedIndex = 0;
           
            // deactivate fields
            txt_CName.Enabled = true;
            txt_CNumber.Enabled = true;
            nud_Term.Enabled = true;
            nud_Hours.Enabled = true;
            cbx_Track.Enabled = true;

            // deactivate button
            btn_NewCourse.Enabled = false;

                btn_Edit.Text = "Add";
            btn_Delete.Text = "Cancel";
        }

        private void lsv_Classes_MouseClick(object sender, MouseEventArgs e)
        {
            // sets the current item selected and fills in the information
            FillFields(lsv_Classes.SelectedItems[0]);

            intIndex = lsv_Classes.SelectedItems[0].Index;
            lsv_Classes.Items[intIndex].Selected = true;   
        }

        private void btn_Right_Click_1(object sender, EventArgs e)
        {
            intIndex++;
            if (intIndex < lsv_Classes.Items.Count)
            {
                // sets the current item selected and fills in the information
                lsv_Classes.Items[intIndex].Selected = true;
                FillFields(lsv_Classes.Items[intIndex]);
            }
            else { intIndex--; }//if at end of list deletes the index increment
        }

        private void btn_Left_Click_1(object sender, EventArgs e)
        {
            intIndex--;
            if (intIndex > lsv_Classes.Items[0].Index - 1)
            {
                // sets the current item selected and fills in the information
                lsv_Classes.Items[intIndex].Selected = true;
                FillFields(lsv_Classes.Items[intIndex]);
            }
            else { intIndex++; }//if at beggining of list increments index
        }
        //------------------------------------------------------------------------------------
    }
}

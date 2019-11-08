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

        public MainForm()
        {
            InitializeComponent();
            HandleClientWindowSize();

            // invoke the method to build the connection string
            string connString = DBUtilities.BuildConnectionString();

            // invoke the method to make the connection
            conn = DBUtilities.Connect(connString);

            // get the data
            RetrieveData();
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

      //-------------------------------------MYSQL PULL-------------------------------------
        private bool RetrieveData()
        {
            // instantiate object to hold data
            FullSailClass course = new FullSailClass();

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

            // now we can fill in the rows
            course.CourseName = itemData.Rows[currentRow]["CourseName"].ToString();
            course.CourseNumber = itemData.Rows[currentRow]["CourseNumber"].ToString();
            course.Term = int.Parse(itemData.Rows[currentRow]["Term"].ToString());
            course.CreditHours = double.Parse(itemData.Rows[currentRow]["CreditHours"].ToString());
            course.Track = itemData.Rows[currentRow]["Track"].ToString();

            // add object to listview
            ListViewItem item = new ListViewItem();
            item.Text = course.ToString();
            item.Tag = course;
            lsv_Classes.Items.Add(item);

            return true;
        }
      //------------------------------------------------------------------------------------
    }
}

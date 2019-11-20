using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// directive to include Newtonsoft
using Newtonsoft.Json.Linq;
using RestSharp;
// directive to include internet connectivity
using System.Net;

namespace Asteroidz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetAsteroids();
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

        //-----------------------------------------API PULLS----------------------------------------
        private void GetAsteroids()
        {
            // api connection
            var client = new RestClient("https://nasaapidimasv1.p.rapidapi.com/getClosestAsteroids");
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-rapidapi-host", "NasaAPIdimasV1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "048bf63835mshb667c766bc15207p19baf2jsnc9ebcdb82d16");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            //request.AddParameter("application/x-www-form-urlencoded", "api_key=Tr8C4eq3LEuJOzXUTUGRm5Ygo6SXux4Ot2ipXT2c", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            // parse
            JObject o = JObject.Parse(response.Content);

            //MessageBox.Show(o.ToString());

            // error check
            if (o["callback"].ToString() == "error")
            {
                if (o["contextWrites"]["to"]["status_code"].ToString() == "API_ERROR")
                {
                    MessageBox.Show($"{o["contextWrites"]["to"]["status_code"].ToString()}\n\n" +
                                $"{o["contextWrites"]["to"]["status_msg"]["error"]["message"].ToString()}");
                }
                
                if (o["contextWrites"]["to"]["status_code"].ToString() == "JSON_VALIDATION")
                {
                    MessageBox.Show($"{o["contextWrites"]["to"]["status_code"].ToString()}\n\n" +
                                $"{o["contextWrites"]["to"]["status_msg"].ToString()}");
                }
            }
            else
            {
                // specific data from the JSON
                string name = o["contextWrites"]["to"]["near_earth_objects"]["name"].ToString();
                double magnitude = double.Parse(o["contextWrites"]["to"]["near_earth_objects"][0]["absolute_magnitude_h"].ToString());
                double diameterMin = double.Parse(o["contextWrites"]["to"]["near_earth_objects"][0]["estimated_diameter"]["feet"]["estimated_diameter_min"].ToString());
                double diameterMax = double.Parse(o["contextWrites"]["to"]["near_earth_objects"][0]["estimated_diameter"]["feet"]["estimated_diameter_max"].ToString());
                bool hazardous = bool.Parse(o["contextWrites"]["to"]["near_earth_objects"][0]["is_potentially_hazardous_asteroid"].ToString());

                MessageBox.Show(name);
            }
        }
        //------------------------------------------------------------------------------------------
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Json;

namespace internet_demo
{
    public partial class Form1 : Form
    {
        const string apiKey = "1330434550430692";
        string jsonReceived;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void heroQuery(string heroName)
        {
            WebRequest heroSearchRequest;
            if(heroName == "random")
            {
                Random rand = new Random();
                string id = rand.Next(1, 730).ToString();
                heroSearchRequest = WebRequest.Create("https://www.superheroapi.com/api.php/"
               + apiKey + "/" + id);
            }
            else
            {
                heroSearchRequest = WebRequest.Create("https://www.superheroapi.com/api.php/"
               + apiKey + "/search/" + heroSearchBox.Text);
            }
            
            HttpWebResponse heroSearchResponse = (HttpWebResponse)heroSearchRequest.GetResponse();
            Stream dataStream = heroSearchResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(dataStream);
            jsonReceived = streamReader.ReadToEnd();

            streamReader.Close();
            dataStream.Close();

            dynamic heroData = JsonParser.Deserialize(jsonReceived);
            if (heroData.response != "error")
            {
                // Might be a better way to do this. Dynamically create progress bars for each key found
                // under powerstats
                WebRequest heroPicRequest;
                try
                {
                    if (heroName == "random")
                    {
                        heroSearchBox.Text = heroData.name;

                        intelligenceBar.Value = Convert.ToUInt16(heroData.powerstats.intelligence);
                        intelligencePercentLabel.Text = heroData.powerstats.intelligence + "/100";

                        strengthBar.Value = Convert.ToUInt16(heroData.powerstats.strength);
                        strengthPercentLabel.Text = heroData.powerstats.strength + " / 100";

                        speedBar.Value = Convert.ToUInt16(heroData.powerstats.speed);
                        speedPercentLabel.Text = heroData.powerstats.speed + " / 100";

                        durabilityBar.Value = Convert.ToUInt16(heroData.powerstats.durability);
                        durabilityPercentLabel.Text = heroData.powerstats.durability + "/100";

                        powerBar.Value = Convert.ToUInt16(heroData.powerstats.power);
                        powerPercentLabel.Text = heroData.powerstats.power + "/100";

                        combatBar.Value = Convert.ToUInt16(heroData.powerstats.combat);
                        combatPercentLabel.Text = heroData.powerstats.combat + "/100";

                        heroPicRequest = WebRequest.Create(heroData.image.url);
                    }
                    else
                    {
                        intelligenceBar.Value = Convert.ToUInt16(heroData.results[0]["powerstats"]["intelligence"]);
                        intelligencePercentLabel.Text = heroData.results[0]["powerstats"]["intelligence"] + "/100";

                        strengthBar.Value = Convert.ToUInt16(heroData.results[0]["powerstats"]["strength"]);
                        strengthPercentLabel.Text = heroData.results[0]["powerstats"]["strength"] + " / 100";

                        speedBar.Value = Convert.ToUInt16(heroData.results[0]["powerstats"]["speed"]);
                        speedPercentLabel.Text = heroData.results[0]["powerstats"]["speed"] + " / 100";

                        durabilityBar.Value = Convert.ToUInt16(heroData.results[0]["powerstats"]["durability"]);
                        durabilityPercentLabel.Text = heroData.results[0]["powerstats"]["durability"] + "/100";

                        powerBar.Value = Convert.ToUInt16(heroData.results[0]["powerstats"]["power"]);
                        powerPercentLabel.Text = heroData.results[0]["powerstats"]["power"] + "/100";

                        combatBar.Value = Convert.ToUInt16(heroData.results[0]["powerstats"]["combat"]);
                        combatPercentLabel.Text = heroData.results[0]["powerstats"]["combat"] + "/100";

                        heroPicRequest = WebRequest.Create(heroData.results[0]["image"]["url"]);
                    }

                    HttpWebResponse heroPicResponse = (HttpWebResponse)heroPicRequest.GetResponse();
                    Stream heroPicStream = heroPicResponse.GetResponseStream();
                    Image heroPortrait = Image.FromStream(heroPicStream);
                    heroPicStream.Close();
                    heroPortraitBoxRight.Image = heroPortrait;
                    heroPortraitBoxLeft.Image = heroPortrait;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Query Error");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error, could not find hero name");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            heroQuery(heroSearchBox.Text);   
        }
    }
}

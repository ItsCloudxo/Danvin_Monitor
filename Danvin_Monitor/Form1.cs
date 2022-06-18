using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Danvin_Monitor
{
    public partial class Form1 : Form
    {
        //News label co-ords.
        private int xPos = 0, yPos = 0;
        //String list for news.
        private List<string> newsList = new List<string>();
        //Index that starts on first news.
        private int newsIdx = 0;

        /// <summary>
        /// Method to retrieve text from Nordjyske RSS feed.
        /// </summary>
        public void readRSSFeed()
        {
            //Url to RSS newsfile.
            string url = "https://nordjyske.dk/rss/aalborg";
            //Create xml reader.
            XmlReader reader = XmlReader.Create(url);
            //Load feed from reader.
            SyndicationFeed feed = SyndicationFeed.Load(reader);           
            reader.Close();
            //Clear existing news.
            newsList.Clear();
            //Add each newsfeed to list.
            foreach (SyndicationItem item in feed.Items)
            {
                newsList.Add(item.Title.Text);
            }
        }
        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Initialize start co-ords.
            xPos = newsPanel.Width;
            yPos = newsLabel.Location.Y;


            readRSSFeed();
            //Initialize label with first news.
            newsLabel.Text = newsList[newsIdx];
        }




        /// <summary>
        /// Form initializes code upon load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Because our update5Min_Tick doesn't run unless 5 minutes have passed, we need to run it once upon load.
            update5Min_Tick(this, null);
            

        }



        private void update5Min_Tick(object sender, EventArgs e)
        {

            //Creates SoapClient.
            DVIService.monitorSoapClient webService = new DVIService.monitorSoapClient();
            
            //Variables for temperature and humidity inside the stock. "N2" defines the amount of decimals to display.
            string sTemp = webService.StockTemp().ToString("N2");
            string sHumidity = webService.StockHumidity().ToString("N2");
            //Sets the text to equal our variables, also there is used string text formatting for readability.
            stockTempText.Text = $"Temp:\t\t{sTemp}°C \rFugt:\t\t{sHumidity}%";

            string oTemp = webService.OutdoorTemp().ToString("N2");
            string oHumidity = webService.OutdoorHumidity().ToString("N2");
            outdoorTempText.Text = $"Temp:\t\t{oTemp}°C \rFugt:\t\t{oHumidity}%";


            //For each string in "StockItemsOverMax" the code within runs once.
            foreach (string sUnderMin in webService.StockItemsUnderMin())
            {
                //Because this function doesn't "print" text or the console equivalent(Console.Write), we need to use logic in the form of +=.
                //This piece of logic does it so for each itteration, it takes the current text and adds it to "sUnderMin" while also setting the text to "sUnderMin".
                //The first setup will be the first value in the array, after that it will be the first setup + the next value in the array.                       
                minStockText.Text += sUnderMin + "\r";
            }


            foreach (string sOverMax in webService.StockItemsOverMax())
            {
                maxStockText.Text += sOverMax + "\r";
            }

            foreach (string sMostSold in webService.StockItemsMostSold())
            {
                mostSoldText.Text += sMostSold + "\r";
            }

        }


        /// <summary>
        /// This is a time that updates the code within after the given interval has passed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clockUpdate_Tick(object sender, EventArgs e)
        {
            //Creates a new variable for a given timezone.
            DateTime dateTimeCph = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time"));
            //Because there are problems with displaying danish formatting, we have to create a sperate variable for the day in Danish.
            string dayCph = dateTimeCph.ToString("dddd", new CultureInfo("da-DK"));
            //The text is set to the day + the date/time in the danish format. If the format was unchanged, it would display time with punctuation instead of colon.
            copenhagenText.Text = $"{dayCph} - {dateTimeCph.ToString(new CultureInfo("da-DK"))}";

            DateTime dateTimeLdn = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            string dayLdn = dateTimeLdn.ToString("dddd", new CultureInfo("da-DK"));
            londonText.Text = $"{dayLdn} - {dateTimeLdn.ToString(new CultureInfo("da-DK"))}";

            DateTime dateTimeSg = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time"));
            string daySg = dateTimeSg.ToString("dddd", new CultureInfo("da-DK"));
            singaporeText.Text = $"{daySg} - {dateTimeSg.ToString(new CultureInfo("da-DK"))}";
        }

        /// <summary>
        /// Marquee ticker to move news label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void marqueeTick_Tick(object sender, EventArgs e)
        {
            //Set new location for label.
            this.newsLabel.Location = new System.Drawing.Point(xPos, yPos);
            if (xPos <= -newsLabel.Width)
            {
                //Set label start position.
                xPos = newsPanel.Width;
                //Roll news index count to next news.
                newsIdx = newsIdx < newsList.Count - 1 ? newsIdx + 1 : 0;
                //Set label text to next news.
                newsLabel.Text = newsList[newsIdx];
            }
            else
            {
                //Move label.
                xPos -= 2;
            }
        }
    }
}

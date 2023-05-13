using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        #region Ron
        public static void RonS()
        {
            var client = new HttpClient();
            
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; // Endpoint
           
            string ronResponse = client.GetStringAsync(ronURL).Result; // Send GET request to the API
            
            var ronObject = JArray.Parse(ronResponse); // Parse response into JArray
            
            
            Console.WriteLine($"With barely conatined disdain, Ron muttered, \"{ronObject[0]}\""); // [0] Removes brackets when response is displayed
        }
        #endregion

        #region Kanye
        public static void Kanye()
        {
            var client = new HttpClient();

            var kayneURL = "https://api.kanye.rest/"; // Endpoint

            string kayneResponse = client.GetStringAsync(kayneURL).Result; // Send GET request to the API
            
            var kayneObject = JObject.Parse(kayneResponse); // Parse response into JObject
            
            Console.WriteLine($"Kanya inanely stated, \"{kayneObject["quote"]}\""); // Value grabs the "joke" text 
        }

        #endregion
    }
}

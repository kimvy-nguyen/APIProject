using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace APIProject.Models
{
    public class RecipeDAL
    {

        public string GetData()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://www.recipepuppy.com/api/");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string ApiText = rd.ReadToEnd();

            return ApiText;
        }

        public JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }
    }
}

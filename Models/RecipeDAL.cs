using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIProject.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

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

        public Recipe ConvertAPIToRecipe(string APIText)
        {
            JToken t = JToken.Parse(text);
        }

        public JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }
    }
}

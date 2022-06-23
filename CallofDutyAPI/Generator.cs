using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallofDutyAPI
{
    public class Generator
    {
        public static IRestResponse CallOfDuty()
        {
            var client = new RestClient("https://call-of-duty-modern-warfare.p.rapidapi.com/weekly-stats/chacho_el_duro%25232741646/acti");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-RapidAPI-Key", "SIGN-UP-FOR-KEY");
            request.AddHeader("X-RapidAPI-Host", "call-of-duty-modern-warfare.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}

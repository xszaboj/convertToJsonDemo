using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToJsonDemo
{
    public class Converter
    {
        public string NewsById()
        {

            List<Newss> Lstnews = GetData();
            var JsonNews = Newtonsoft.Json.JsonConvert.SerializeObject(Lstnews);
            return JsonNews;
        }

        private List<Newss> GetData()
        {
            //here you would get data from database I will use just fake data
            return new List<Newss>(){
            new Newss{ CompanyId = 1, CompanyLegalName = "demo 1", NewsCompId = 2, NewsID = 3},
            new Newss{ CompanyId = 99, CompanyLegalName = "demo 2", NewsCompId = 98, NewsID = 97}
            };
        }
    }
}

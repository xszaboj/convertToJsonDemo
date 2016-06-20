using System;
using ConvertToJsonDemo;

namespace WCFDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            Converter c = new Converter();
            return c.NewsById();
        }

        public string GetDataWrapped(string value)
        {
            Converter c = new Converter();
            return c.NewsById();
        }

        public System.Collections.Generic.List<Newss> GetList(string value)
        {
            Converter c = new Converter();
            return c.NewsList();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }





        
    }
}

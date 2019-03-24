using System;
using System.Globalization;
using System.Text;

namespace StringRepresentations
{
    public class Customer
    {
        public string Name { get; set; }
        public decimal Revenue { get; set; }
        public string ContactPhone { get; set; }

        public string GetRevenue()
        {
            CultureInfo currentCulture = new CultureInfo("en-US", false);
            var revenue = String.Format(currentCulture, "{0:C0}", Revenue);
            return revenue;
        }

        public string ReceiveFullInfo()
        {
            var fullInfo = new StringBuilder();
            fullInfo.Append(Name + ", ");
            fullInfo.Append(ContactPhone + ", ");
            fullInfo.Append(GetRevenue());
            return fullInfo.ToString();
        }

        public string ReceiveNameAndPhone()
        {
            var fullInfo = new StringBuilder();
            fullInfo.Append(Name + ", ");
            fullInfo.Append(ContactPhone);
            return fullInfo.ToString();
        }

        public string ReceiveNameAndRevenue()
        {
            var fullInfo = new StringBuilder();
            fullInfo.Append(Name + ", ");
            fullInfo.Append(GetRevenue());
            return fullInfo.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
namespace Dr.Mustafa_Clinic
{
    class backend
    {
        public backend(List<string> numbers)
        {
            int i;
            for (i = 0; i < numbers.Count; i++)
            {
                string s = send(numbers[i]);
                //success ID
                //erorr
            }
        }
        string send(string number)
        {
            number = "2" + number;
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            client.QueryString.Add("user", "abdelwahab55");
            client.QueryString.Add("password", "cCSGUTIDWeQYTX");
            client.QueryString.Add("api_id", "3501635");
            client.QueryString.Add("to", number);
            client.QueryString.Add("text", "This is an example message");
            string baseurl = "http://api.clickatell.com/http/sendmsg";
            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return (s);
    }
}
}

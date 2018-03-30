using System;
using System.IO;
using System.Net;

namespace WindowsFormsApplication4
{
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            string url = "http://www.omdbapi.com/";

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url+endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error code: " + response.GetResponseStream());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return strResponseValue;
        }
    }
}
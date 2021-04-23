using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Essentials
    {
        public string sendRequest(string method, string AuthId, string AuthKey,string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ReadWriteTimeout = 100000;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = method;
            httpWebRequest.UserAgent = "GivenUserAgent";
            httpWebRequest.Headers.Add("X-Annature-Id", AuthId);
            httpWebRequest.Headers.Add("X-Annature-Key", AuthKey);
            using (HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader reader = new StreamReader(httpResponse.GetResponseStream());
                    return reader.ReadToEnd();
                }
                else
                {
                    return "Request Failed";
                }
            }
        }

        public string sendRequest(string method, string AuthId, string AuthKey, string url, string body)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ReadWriteTimeout = 100000;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = method;
            httpWebRequest.UserAgent = "GivenUserAgent";
            httpWebRequest.Headers.Add("X-Annature-Id", AuthId);
            httpWebRequest.Headers.Add("X-Annature-Key", AuthKey);

            if (body.Length > 0)
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(body);
                }
            }

            using (HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader reader = new StreamReader(httpResponse.GetResponseStream());
                    return reader.ReadToEnd();
                }
                else
                {
                    return "Request Failed";
                }
            }
        }
    }
}

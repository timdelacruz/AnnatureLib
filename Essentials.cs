using AnnatureLib.Models;
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
        public string sendRequest(string method, string url)
        {
            Headers headers = new Headers();
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ReadWriteTimeout = 100000;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = method;
            httpWebRequest.UserAgent = "GivenUserAgent";
            httpWebRequest.Headers.Add("X-Annature-Id", headers.AuthId);
            httpWebRequest.Headers.Add("X-Annature-Key", headers.AuthKey);
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

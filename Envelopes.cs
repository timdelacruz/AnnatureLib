using AnnatureLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Envelopes
    {
        public string getList()
        {
            Headers headers = new Headers();
            Essentials essen = new Essentials();

            string responseString = essen.sendRequest("GET", headers.BaseUrl + "/v1/envelopes");

            return responseString;
        }

        public string getEnvelope(string id)
        {
            Headers headers = new Headers();
            Essentials essen = new Essentials();

            string responseString = essen.sendRequest("GET", headers.BaseUrl + "/v1/envelopes/" + id);

            return responseString;
        }

        public string voidEnvelope(string id)
        {
            Headers headers = new Headers();
            Essentials essen = new Essentials();

            string responseString = essen.sendRequest("POST", headers.BaseUrl + "/v1/envelopes/" + id + "/void");

            return responseString;
        }
    }
}

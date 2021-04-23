using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    public class Envelopes
    {
        public string AuthId { get; set; }
        public string AuthKey { get; set; }
        public string BaseUrl { get; set; }

        public string getList()
        {
            Essentials essen = new Essentials();
            string responseString = essen.sendRequest("GET", AuthId, AuthKey, BaseUrl + "/v1/envelopes");

            return responseString;
        }

        public string getEnvelope(string id)
        {
            Essentials essen = new Essentials();
            string responseString = essen.sendRequest("GET", AuthId, AuthKey, BaseUrl + "/v1/envelopes/" + id);

            return responseString;
        }

        public string voidEnvelope(string id)
        {
            Essentials essen = new Essentials();
            string responseString = essen.sendRequest("POST", AuthId, AuthKey, BaseUrl + "/v1/envelopes/" + id + "/void");

            return responseString;
        }

        public string createEnvelope(string body)
        {
            Essentials essen = new Essentials();
            string responseString = essen.sendRequest("POST", AuthId, AuthKey, BaseUrl + "/v1/envelopes/", body);

            return responseString;
        }

    }
}

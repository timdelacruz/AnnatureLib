using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Envelopes
    {
        public string AuthId { get; set; }
        public string AuthKey { get; set; }
        public string BaseUrl { get; set; }

        public Essentials essen;
        public string getList()
        {
            string responseString = essen.sendRequest("GET", AuthId, AuthKey, BaseUrl + "/v1/envelopes");

            return responseString;
        }

        public string getEnvelope(string id)
        {
            string responseString = essen.sendRequest("GET", AuthId, AuthKey, BaseUrl + "/v1/envelopes/" + id);

            return responseString;
        }

        public string voidEnvelope(string id)
        {
            string responseString = essen.sendRequest("POST", AuthId, AuthKey, BaseUrl + "/v1/envelopes/" + id + "/void");

            return responseString;
        }

        public string createEnvelope(string body)
        {
            string responseString = essen.sendRequest("POST", AuthId, AuthKey, BaseUrl + "/v1/envelopes/", body);

            return responseString;
        }

    }
}

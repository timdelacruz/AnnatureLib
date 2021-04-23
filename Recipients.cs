using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Recipients
    {
        public string AuthId { get; set; }
        public string AuthKey { get; set; }
        public string BaseUrl { get; set; }

        public string updateRecipient(string id)
        {
            Essentials essen = new Essentials();
            string responseString = essen.sendRequest("PUT", AuthId, AuthKey, BaseUrl + "/v1/recipients/" + id);

            return responseString;
        }
    }
}

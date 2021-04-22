using AnnatureLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnatureLib
{
    class Recipients
    {
        public string updateRecipient(string id)
        {
            Headers headers = new Headers();
            Essentials essen = new Essentials();

            string responseString = essen.sendRequest("PUT", headers.BaseUrl + "/v1/recipients/" + id);

            return responseString;
        }
    }
}

# AnnatureLib
How to use the Annature Library

## ACCOUNTS
### Get Accounts List

```
using System;
using AnnatureLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts();

            accounts.AuthId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            accounts.AuthKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            accounts.BaseUrl = @"";

            var response = accounts.getList();
        }
    }
}
```

## ENVELOPES
### Get Envelope List

```
using System;
using AnnatureLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Envelopes envelope = new Envelopes();

            envelope.AuthId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            envelope.AuthKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            envelope.BaseUrl = @"";

            var response = envelope.getList();
        }
    }
}
```

### Retrive Envelope

```
using System;
using AnnatureLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Envelopes envelope = new Envelopes();

            envelope.AuthId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            envelope.AuthKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            envelope.BaseUrl = @"";

            string envelopeId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            var response = envelope.getEnvelope(envelopeId);
        }
```

### Void Envelope

```
using System;
using AnnatureLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Envelopes envelope = new Envelopes();

            envelope.AuthId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            envelope.AuthKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            envelope.BaseUrl = @"";

            string envelopeId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            var response = envelope.voidEnvelope(envelopeId);
        }
    }
}
```

### Create Envelope

```
using System;
using System.Collections.Generic;
using AnnatureLib;
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Envelopes env = new Envelopes();

            env.AuthId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            env.AuthKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            env.BaseUrl = @"";

            Envelope envelope = new Envelope();

            envelope.name = "Non disclosure agreement";
            envelope.message = "Lorem ipsum dolor sit amet.";
            envelope.shared = false;
            envelope.draft = false;
            envelope.account_id = "xxxxxxxxxxxxxxxxxxxxxx";
            envelope.group_id = "xxxxxxxxxxxxxxxxxxxxxx";
            envelope.Documents = new Documents
            {
                id = "xxxxxxxxxxxxxxxxxxxxxx",
                name = "Non disclosure agreement.pdf",
                Base = "xxxxxxxxxxxxxxxxxxxxxx"
            };
            envelope.Recipients = new Rec
            {
                name = "John Doe",
                email = "jdoe@example.com",
                mobile = "+61xxxxxxxxx",
                type = "xxxxx",
                message = "Lorem ipsum dolor sit amet.",
                password = "***********",
                muted = false,
                order = 1,
                Redirects = new Redirects
                {
                    session_completed = "https://..",
                    session_declined = "https://.."
                },
                Fields = new Fields
                {
                    id = "xxxxxxxxxxxxxxxxxxxxxx",
                    type = "signature",
                    anchor = "{{signature}}"
                }
            };
            envelope.metadata = new List<string>();
            

            string jsonBody = JsonConvert.SerializeObject(envelope);

            var response = env.createEnvelope(jsonBody);
        }
    }
}
```

## RECIPIENTS
### Update Recipient

```
using System;
using AnnatureLib;
using ConsoleApp1.Models;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipients recipients = new Recipients();

            recipients.AuthId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            recipients.AuthKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            recipients.BaseUrl = @"";

            string recipientId = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            Recipient recipient = new Recipient();

            recipient.name = "John Doe";
            recipient.email = "jdoe@example.com";
            recipient.mobile = "+61xxxxxxxxx";

            string jsonBody = JsonConvert.SerializeObject(recipient);

            var response = recipients.updateRecipient(recipientId, jsonBody);
        }
    }
}
```

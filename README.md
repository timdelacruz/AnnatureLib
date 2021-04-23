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

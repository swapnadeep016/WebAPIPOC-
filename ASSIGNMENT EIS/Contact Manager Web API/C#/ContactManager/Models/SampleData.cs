using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public static class SampleData
    {
        static Contact[] sampleContacts = new Contact[]
            {
                new Contact { ContactId = 1, Name = "Glenn Block", Address = "1 Microsoft Way", City = "Redmond", State = "WA", Zip = "98052", Email = "gblock@microsoft.com", Twitter = "gblock", Department = "HR" },
                new Contact { ContactId = 2, Name = "Howard Dierking", Address = "1 Microsoft Way", City = "Redmond", State = "WA", Zip = "98052", Email = "howard@microsoft.com", Twitter = "howard_dierking", Department = "Sales" },
                new Contact { ContactId = 3, Name = "Yavor Georgiev", Address = "1 Microsoft Way", City = "Redmond", State = "WA", Zip = "98052", Email = "yavorg@microsoft.com", Twitter = "digthepony", Department = "IT" },
                new Contact { ContactId = 4, Name = "Jeff Handley", Address = "1 Microsoft Way", City = "Redmond", State = "WA", Zip = "98052", Email = "jeff.handley@microsoft.com", Twitter = "jeffhandley", Department = "QA" },
                new Contact { ContactId = 5, Name = "Daniel Roth", Address = "1 Microsoft Way", City = "Redmond", State = "WA", Zip = "98052", Email = "daroth@microsoft.com", Twitter = "danroth27", Department = "Dev" },
            };

        public static Contact[] Contacts
        {
            get
            {
                return sampleContacts;
            }
        }
    }
}
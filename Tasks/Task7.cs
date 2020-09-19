using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task7
    {
        public static List<string> emails = new List<string> {
            { "email_1@gmail.com" },
            { "email_1@gmail.com" },
            { "email_2@gmail.com" },
            { "email_3@gmail.com" },
            { "email_3@gmail.com" },
            { "email_3@gmail.com" }
        };

        public static int ReplayEmailsCount(List<string> emails)
        {
            var temp = emails.GroupBy(email => email).Where(email => email.Count() > 2).Select(g => g.Key);
            return temp.Count();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var customersEmails = new List<string> { "a@a.com", "b@b.com", "c@c.com" };
                customersEmails.ForEach(async c => await SendEmail(c));
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error sending emails: {exception}");
                Console.ReadLine();
            }

            Console.WriteLine("Sent emails successfully!");
        }

        private static async Task SendEmail(string email)
        {
            Console.WriteLine($"Sending email to {email}");

            // Simulate a long running process for sending email
            await Task.Delay(1000);

            // Simulate an error while sending the email to one of the addreses
            if (email.Equals("b@b.com"))
            {
                throw new Exception($"Unable to send email to {email}");
            }
        }
    }
}

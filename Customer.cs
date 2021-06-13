using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackRatingApplicaiton
{
    class Customer
    {
        public string CustomerName { get; set; }
        public long CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public string CustomerAddress { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Feedback { get; set; }
        

        public Customer()
        {

        }


        public Customer(string customerName, long customerPhone, string customerEmail, string customerAddress, string date, string time, int feedback)
        {
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            CustomerEmail = customerEmail;
            CustomerAddress = customerAddress;
            Date = date;
            Time = time;
            Feedback = feedback;
        }

        public string ToCSVString()
        {
            string CSV = string.Format("\n{0}, {1}, {2}, {3}, {4}, {5}, {6},", CustomerName, CustomerPhone, CustomerEmail, CustomerAddress, Date, Time, Feedback);
            return CSV;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

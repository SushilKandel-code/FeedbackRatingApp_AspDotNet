using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FeedbackRatingApplicaiton
{
    class FeedbackCriteria
    {

        public List<Customer> Customerinfo;
        public List<Criteria> Criteriainfo;

        private readonly string CustomerFile = @"..\..\DataInformation\customer.csv";
        private readonly string CriteriaFile = @"..\..\DataInformation\criteria.csv";
        public FeedbackCriteria()
        {
            LoadFromFile();
        }

        public bool AddCustomer(Customer customer)
        {

            if (Customerinfo.Exists(x => x.CustomerName != customer.CustomerName))
            {
                Customerinfo.Add(customer);
                return true;
            }
            else
            {
                return false;
            } 
        }

        public bool AddCriteria(Criteria criteria) 
        {

            if (Criteriainfo.Exists(x => x.CriteriaType != criteria.CriteriaType))
            {
                Criteriainfo.Add(criteria);
                return true;
            }
            else
            {
                return false;
            } // end if
        }


        public List<Customer> GetCustomers()
        {
            return Customerinfo;
        }

        public List<Criteria>GetCriterias()
        {
            return Criteriainfo;
        }

        public void SaveToCustomerFile()
        {
            File.Delete(CustomerFile);

            //deletes the existing file
           
            File.AppendAllText(CustomerFile, string.Format("{0}, {1}, {2}, {3}, {4}, {5}","Name", "Phone", "Email","Address", "Date", "Time,"));
            string[] csvlines = System.IO.File.ReadAllLines(CriteriaFile);

            var criteria = new List<string>();

            for (int i = 1; i < csvlines.Length; i++)
                {
                string[] rowData = csvlines[i].Split(',');
                 criteria.Add(rowData[0]);
            }

            for (int i = 0; i < criteria.Count; i++)
            {
                Console.WriteLine(criteria[i]);
                File.AppendAllText(CustomerFile, string.Format(criteria[i]+","));
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(CustomerFile, true))
            {
                //file.WriteLine();
                file.Write(@""+"\n");

            }
           
        }


        public bool DropCriteria(int index)
        {
            if(Criteriainfo.Exists(c => c.CriteriaType != index.ToString()))
            {
                Criteriainfo.RemoveAt(index);
                return true;

            }
            else
            {
                return false;
            }
        }

      
        public void SaveToCriteriaFile()
        {
            // deletes the existing file
            File.Delete(CriteriaFile);
            File.AppendAllText(CriteriaFile, string.Format("Available Criteria") + Environment.NewLine);

            // append each customerList to the csv file
            for (int i = 0; i < Criteriainfo.Count; i++)
            {
                File.AppendAllText(CriteriaFile, Criteriainfo[i].ToCSVString());
            }
        }

        public void LoadFromFile()
        {
            Customerinfo = new List<Customer>();
            Criteriainfo = new List<Criteria>();

            if (File.Exists(CustomerFile))
            {
                using (StreamReader sr = new StreamReader(CustomerFile))
                {
                    sr.ReadLine();
                    while (sr.Peek() != -1)//
                    {
                        string line = sr.ReadLine();
                        List<string> lineValues = line.Split(',').ToList();
                        string customerName = lineValues[0];
                        long customerPhone = long.Parse(lineValues[1]);
                        string customerEmail = lineValues[2];
                        string address = lineValues[3];
                        string date = lineValues[4];
                        string time = lineValues[5];
                        int feedback = int.Parse(lineValues[6]);
                      
                        Customer current_customer = new Customer(customerName, customerPhone, customerEmail, address, date, time, feedback);
                        Customerinfo.Add(current_customer);
                    }
                }
            }

            if (File.Exists(CriteriaFile))
            {
                using (StreamReader sr = new StreamReader(CriteriaFile))
                {
                    sr.ReadLine();
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        List<string> lineValues = line.Split(',').ToList();
                        string criteriaName = lineValues[0];
                        Criteria current_criteria = new Criteria(criteriaName);
                        Criteriainfo.Add(current_criteria);
                    }
                }
            }
           
        }
    }
}

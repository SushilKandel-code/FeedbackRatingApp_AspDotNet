using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackRatingApplicaiton
{
    public partial class GivingFeedback : UserControl
    {
        readonly FeedbackCriteria feedbackCriteria = new FeedbackCriteria();
        private readonly string CustomerFile = @"..\..\DataInformation\customer.csv";
 
      
        public GivingFeedback()
        {
            InitializeComponent();
            PopulateDataGridViewCriteria();

        }

        public void PopulateDataGridViewCriteria()
        {
            CriteriaDataGrid.Rows.Clear();

            List<Criteria> criteria = feedbackCriteria.GetCriterias();

            foreach (Criteria x in criteria)
            {
                CriteriaDataGrid.Rows.Add(x.CriteriaType);
            }
        }
        private void ReviewButton_Click(object sender, System.EventArgs e)
        {
            
            if (File.Exists(CustomerFile))
            {
                Console.WriteLine(" ");
            }
            else
            {
                feedbackCriteria.SaveToCustomerFile();

            }

            DateTime dt = DateTime.Now;

            string CustomerName = customerNameBox.Text;
            long CustomerPhone = long.Parse(phoneNumberBox.Text);
            string Email = emailBox.Text;
            string Address = addressBox.Text;
            
            if (customerNameBox.Text == "")
            {
                CustomerName = "N/a";
            }
            else
            {
                CustomerName = customerNameBox.Text;
            }

            if (phoneNumberBox.Text == "")
            {
                CustomerPhone = 0;
            }
            else if (phoneNumberBox.TextLength != 10)
            {
                MessageBox.Show("Please enter mobile number with 10 digits!");
                return;
            }
            else
            {
                try
                {
                    CustomerPhone = long.Parse(phoneNumberBox.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid number", ex.ToString());
                    return;

                }
            }

            if (emailBox.Text == "") {
                Email = "N/a";
            }
            else
            {
                Email = emailBox.Text;
            }

            if (addressBox.Text == "") {
                Address = "N/a";
            }
            else
            {
                Address = addressBox.Text;
            }


            string date = dt.ToString("MM/dd/yyyy");
            string time = dt.ToString("hh:mm tt");
            int CriteriaValue = 0;





            for (int i = 0; i <= CriteriaDataGrid.Rows.Count - 1; i++)
            {
                Console.WriteLine(CriteriaDataGrid.Rows[i].Cells[0].Value.ToString());
                Console.ReadLine();
                try
                {
                    string Excellent;
                    string Average;
                    string Good;
                    string Dissatisfied;

                    if (CriteriaDataGrid.Rows[i].Cells[1].Value != null)
                    {
                        Excellent = CriteriaDataGrid.Rows[i].Cells[1].Value.ToString();
                        if (Excellent == "True")
                        {
                            CriteriaValue = 5;
                           
                        }
                    }

                    if (CriteriaDataGrid.Rows[i].Cells[2].Value != null)
                    {
                        Good = CriteriaDataGrid.Rows[i].Cells[2].Value.ToString();
                        if (Good == "True")
                        {
                            CriteriaValue = 4;
                            
                        }
                    }

                    if (CriteriaDataGrid.Rows[i].Cells[3].Value != null)
                    {
                        Average = CriteriaDataGrid.Rows[i].Cells[3].Value.ToString();
                        if (Average == "True")
                        {
                            CriteriaValue = 3;
                            
                        }
                    }

                    if (CriteriaDataGrid.Rows[i].Cells[4].Value != null)
                    {
                        Dissatisfied = CriteriaDataGrid.Rows[i].Cells[4].Value.ToString();
                        if (Dissatisfied == "True")
                        {
                            CriteriaValue = 1;
                            
                        }
                    }
                    else
                    {
                        CriteriaValue = 0;
                    }

                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(" " + ex);
                }

                if (i == 0)
                {
                    AddRecord(CustomerName, CustomerPhone, Email, Address, date, time, CriteriaValue, CustomerFile);

                }
                else
                {
                    AddRecord1(CriteriaValue, CustomerFile);
                }
            }
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(CustomerFile, true))
            {
                //file.WriteLine();
                file.Write(@"" + "\n");

            }
            
        }
        public void FeedbackFormControl_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome");
        }

        public void AddRecord(string name, long contact, string email, string address, string date, string time, int feedback, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    //file.WriteLine();
                    file.Write(@"" + name + "," + contact + "," + email + "," + address + "," + date + "," + time + "," + feedback + ",");

                }
                MessageBox.Show("Data Added");
                customerNameBox.Clear();
                emailBox.Clear();
                phoneNumberBox.Clear();
                addressBox.Clear();
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong!!!", ex);
            }
        }

        public void AddRecord1(int feedback, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.Write(feedback + ",");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong!!!", ex);
            }
        }

        public void AddRecord2(int overall, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    double final = (double)overall / CriteriaDataGrid.Rows.Count;
                    file.Write(Math.Round(final) + "\n");
                }
                Console.WriteLine("Data Added");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong!!!", ex);
            }
        }

        private void CriteriaDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = CriteriaDataGrid.CurrentCell.RowIndex;
            int column = CriteriaDataGrid.CurrentCell.ColumnIndex;
            if (column > 0)
            {
                for(int i = 1; i < CriteriaDataGrid.Columns.Count; i++)
                {
                    CriteriaDataGrid.Rows[row].Cells[i].Value = false;
                }
                CriteriaDataGrid.Rows[row].Cells[column].Value = true;
            }
        }
    }
}

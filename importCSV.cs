using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Windows;


namespace FeedbackRatingApplicaiton
{
    public partial class importCSV : UserControl
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private readonly string CustomerFile = @"..\..\DataInformation\customer.csv";
       


        public importCSV()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.ShowDialog();

            openFileDialog1.Filter = "CSV Files| *.csv";
            ReadFromCSV();
           


        }

        public void ReadFromCSV()
        {
            if (File.Exists(CustomerFile))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(CustomerFile);
                string[] columnnames = file.ReadLine().Split(',');
                DataTable dt = new DataTable();
                for (int i = 0; i < columnnames.Length - 1; i++)
                {
                    dt.Columns.Add(columnnames[i]);
                }
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    string[] values = newline.Split(',');
                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                file.Close();
                importdataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }


        }

     
    }    


   
 }

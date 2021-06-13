using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FeedbackRatingApplicaiton
{
    public partial class ReportGenerate : UserControl
    {

        private readonly string CustomerFile = @"..\..\DataInformation\customer.csv";
        private int[] rArray;
        private int[] averageRating;
        private string[] cArray;

        public ReportGenerate()
        {
            InitializeComponent();
        }

        public void getReport()
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
                reportGrid.DataSource = dt;
                file.Close();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }


        private void ReportGenerate_Load(object sender, EventArgs e)
        {
            getReport();
            showReport();


        }
        public void showReport()
        {
            CSVfileIntoGridview cgd = new CSVfileIntoGridview();
            cgd.ConvertToGridView(reportGrid);

            List<int> ratings = new List<int>();
            for (int i = 6; i < reportGrid.Columns.Count; i++)
            {

                int total = reportGrid.Rows.Cast<DataGridViewRow>()
                     .Sum(t => t.Cells[i].Value != DBNull.Value ? Convert.ToInt32(t.Cells[i].Value) : 0);

                ratings.Add(total);
            }

            rArray = ratings.ToArray();


            List<int> avgRating = new List<int>();
            foreach (int ratingValue in rArray)
            {
                int average = ratingValue / reportGrid.RowCount;
                avgRating.Add(average);
            }
            averageRating = avgRating.ToArray();

            //Console.WriteLine("New Length: " + rArray.Length);

            System.IO.StreamReader file = new System.IO.StreamReader((CustomerFile));
            string[] columnnames = file.ReadLine().Split(',');
            List<string> CriteriaArray = new List<string>();
            for (int i = 6; i < columnnames.Length - 1; i++)
            {
                CriteriaArray.Add(columnnames[i]);
            }
            cArray = CriteriaArray.ToArray();
            
            DataTable cdt = new DataTable();
            cdt.Columns.Add("Criteria Name", typeof(string));
            cdt.Columns.Add("Total Ratings", typeof(int));
            cdt.Columns.Add("Average Rating", typeof(int));

            for (int i = 0; i < rArray.Length; i++)
            {
                DataRow cdr = cdt.NewRow();
                cdr["Criteria Name"] = cArray[i];
                cdr["Total Ratings"] = rArray[i];
                cdr["Average Rating"] = averageRating[i];
                cdt.Rows.Add(cdr);
            }

            averageGrid.DataSource = cdt;
            file.Close();


        }




    }
}

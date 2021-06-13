using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace FeedbackRatingApplicaiton
{
    class CSVfileIntoGridview
    {

        private readonly string CustomerFile = @"..\..\DataInformation\customer.csv";

        public void ConvertToGridView(DataGridView dataGrid)
        {
            if (File.Exists(CustomerFile))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(CustomerFile);
                string[] columnnames = file.ReadLine().Split(',');
                DataTable datatable = new DataTable();
                for (int i = 0; i < columnnames.Length - 1; i++)
                {
                    datatable.Columns.Add(columnnames[i]);
                }
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow datarow = datatable.NewRow();
                    string[] values = newline.Split(',');
                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        datarow[i] = values[i];
                    }
                    datatable.Rows.Add(datarow);
                }
                file.Close();
                dataGrid.DataSource = datatable;
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }


    }
}

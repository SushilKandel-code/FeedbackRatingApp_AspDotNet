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
using System.Windows.Forms.DataVisualization.Charting;


namespace FeedbackRatingApplicaiton
{
    public partial class ChartGenerate : UserControl
    {
        private readonly string CustomerFile = @"..\..\DataInformation\customer.csv";

        public ChartGenerate()
        {
            InitializeComponent();
          
            
        }
        public void displayPieChart()
        {
            if (File.Exists(CustomerFile))
            {

                System.IO.StreamReader file = new System.IO.StreamReader((CustomerFile));
                string[] columnnames = file.ReadLine().Split(',');
                List<string> CriteriaArray = new List<string>();
                for (int i = 6; i < columnnames.Length - 1; i++)
                {
                    CriteriaArray.Add(columnnames[i]);
                }
                string[] criteriaArray = CriteriaArray.ToArray();
                file.Close();


                CSVfileIntoGridview csvGridview = new CSVfileIntoGridview();
                csvGridview.ConvertToGridView(dataGridView);

                int[] ratingArray = { };
                try
                {
                    List<int> ratings = new List<int>();
                    for (int i = 6; i < dataGridView.Columns.Count; i++)
                    {

                        int total = dataGridView.Rows.Cast<DataGridViewRow>()
                             .Sum(t => t.Cells[i].Value != DBNull.Value ? Convert.ToInt32(t.Cells[i].Value) : 0);
                        Console.WriteLine(total);
                        ratings.Add(total);
                    }

                    ratingArray = ratings.ToArray();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something wrong!\n No data in file");
                    return;
                }
                

                piechart.Series.Add("Total Rating");

                for (int i = 0; i < criteriaArray.Length; i++)
                {
                    piechart.Series[0].Points.AddXY(criteriaArray[i], ratingArray[i]);
                }

                this.piechart.Series[0]["PieLabelStyle"] = "Outside";

                // Set border width so that labels are shown on the outside
                this.piechart.Series[0].BorderWidth = 1;
                this.piechart.Series[0].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

                // Add a legend to the chart and dock it to the bottom-center
                //this.chart.Legends.Add("Legend2");
                this.piechart.Legends[0].Enabled = true;
                this.piechart.Legends[0].Docking = Docking.Bottom;
                this.piechart.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

                // Set the legend to display pie chart values as percentages
                // Again, the P2 indicates a precision of 2 decimals
                this.piechart.Series[0].LegendText = "#PERCENT{P2}";

                // By sorting the data points, they show up in proper ascending order in the legend
                this.piechart.DataManipulator.Sort(PointSortOrder.Descending, piechart.Series[0]);


                //chart.Series[0].ChartType = SeriesChartType.Column;
                piechart.Series[0].ChartType = SeriesChartType.Pie;

                piechart.Titles.Add("Pie Chart for Ratings on Service Criteria");
            }
            else
            {
                MessageBox.Show("No data availabe to show customer report");
                //this.Dispose();
            }

        }
        
        private void chartGenerateButton_Click_1(object sender, EventArgs e)
        {
           displayPieChart();
        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FeedbackRatingApplicaiton
{
    public partial class AddCriteria : UserControl
    {
        
        readonly FeedbackCriteria feedbackCriteria = new FeedbackCriteria(); // object of Feedback Criteria
        public AddCriteria()
        {
            InitializeComponent();
          
        }

       

        // Add the criteria data to the csv file when button is clicked
        private void CriteriaBtn_Click_1(object sender, EventArgs e)
        {
            Criteria criteria;

            string criteriaType = AddCriteria1.Text;

            criteria = new Criteria(criteriaType);
            feedbackCriteria.AddCriteria(criteria);
            feedbackCriteria.SaveToCriteriaFile();
            GivingFeedback form = new GivingFeedback();
            form.PopulateDataGridViewCriteria();

            String filePath = @"..\..\DataInformation\customer.csv";

            var csv = File.ReadLines(filePath) // not AllLines
              .Select((line, index) => index == 0
                 ? line + criteriaType + ","
                 : line + " " + ",")
              .ToList(); // we need to write into the same file, that´s why we materialize

            File.WriteAllLines(filePath, csv);
            MessageBox.Show("Criteria Added");
            AddCriteria1.Clear();

        }

        private void viewCriteria_Click(object sender, EventArgs e)
        {
            viewCriteria form = new viewCriteria();
            form.Show();
        }
    }
}

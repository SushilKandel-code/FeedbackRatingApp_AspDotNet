using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackRatingApplicaiton
{
    public partial class viewCriteria : Form
    {

        readonly FeedbackCriteria feedbackCriteria = new FeedbackCriteria(); // object of Feedback Criteria
        public viewCriteria()
        {
            InitializeComponent();
           
        }

        private void viewCriteria_Load(object sender, EventArgs e)
        {
            PopulateDataGridViewCriteria();

        }

        // To populate the criteria data in grid view when Criteria Add Button is clicked
        public void PopulateDataGridViewCriteria()
        {
            CriteriaGridData.Rows.Clear();

            List<Criteria> criteria = feedbackCriteria.GetCriterias();

            foreach (Criteria x in criteria)
            {
                CriteriaGridData.Rows.Add(x.CriteriaType);
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            int RemoveCriteria = CriteriaGridData.CurrentCell.RowIndex;
            DialogResult criteriaDel = MessageBox.Show(String.Format("Do you want to delete this criteria?", 
                RemoveCriteria), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (criteriaDel == DialogResult.Yes)
            {
                feedbackCriteria.DropCriteria(RemoveCriteria);
                feedbackCriteria.SaveToCriteriaFile();
                PopulateDataGridViewCriteria();
            }
        }

       
    }
}

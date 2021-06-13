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
    public partial class MainApplication : Form
    {
        static MainApplication _obj;

        public static MainApplication Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainApplication();
                }
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }
        public MainApplication()
        {
            InitializeComponent();
        
        }

        // application on load the Feedback Form and Login User Form is loaded
        private void Application_Load(object sender, System.EventArgs e)
        {

            _obj = this;

            GivingFeedback feedbackForm = new GivingFeedback
            {
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Add(feedbackForm);

            LoginControl loginUserControl = new LoginControl
            {
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Add(loginUserControl);

            ReportGenerate reportGenerate = new ReportGenerate
            {
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Add(reportGenerate);

            importCSV import = new importCSV
            {
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Add(import);

            ChartGenerate chart = new ChartGenerate
            {
                Dock = DockStyle.Fill

            };
            mainPanel.Controls.Add(chart);

        }


        // Login form will open when click in it
        private void CreateFeedback_Click(object sender, System.EventArgs e)
        {
          
            mainPanel.Controls["LoginUserControl"].BringToFront();
        }

        // Feedback form will open when click in it
        private void FeedbackForm_Click(object sender, System.EventArgs e)
        {
          
            mainPanel.Controls["GivingFeedback"].BringToFront();
            PopulateDataGridViewCriteria();
        }

        //report form will open when click in it
        private void reportButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["ReportGenerate"].BringToFront();
   
        }

        //import csv form will open when click in it
        private void importButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["importCSV"].BringToFront();
        }


        //chart form will open when click in it
        private void ChartForm_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["ChartGenerate"].BringToFront();
        }

        readonly GivingFeedback fedback = new GivingFeedback();
        readonly FeedbackCriteria feedbackCriteria = new FeedbackCriteria();
        public void PopulateDataGridViewCriteria()
        {
            fedback.CriteriaDataGrid.Rows.Clear();

            List<Criteria> criteria = feedbackCriteria.GetCriterias();

            foreach (Criteria x in criteria)
            {
                fedback.CriteriaDataGrid.Rows.Add(x.CriteriaType);
               /* Console.WriteLine(12);
                Console.ReadLine();*/
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

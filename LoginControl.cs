using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackRatingApplicaiton
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        
        private void Login_Click(object sender, EventArgs e)
        {
            if (!MainApplication.Instance.PanelContainer.Controls.ContainsKey("CreateFeedbackFormControl"))
            {
                AddCriteria createFeedbackFormControl = new AddCriteria()
                {
                    Dock = DockStyle.Fill
                };
                MainApplication.Instance.PanelContainer.Controls.Add(createFeedbackFormControl);
            }


            string username = textUsername.Text;
            string password = textPassword.Text;

            if (username == "")   //if username is empty
            {
                MessageBox.Show("Username Required", "Error");
            }
            else if (password == "")  //if password is empty
            {
                MessageBox.Show("Password Required", "Error");
            }
            else if (password == "admin" && username == "admin")  //giving values for textbox for login//
            {
                MessageBox.Show("Login Successful", "Login");
                this.Hide();
                MainApplication.Instance.PanelContainer.Controls["AddCriteria"].BringToFront();
            }

            else
            {
                MessageBox.Show("Invalid Username and Password! Please Try Again", "Error");
            }
            
            
           }

       
    }
}

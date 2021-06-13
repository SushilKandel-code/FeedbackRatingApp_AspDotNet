namespace FeedbackRatingApplicaiton
{
    partial class AddCriteria
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminLogin = new System.Windows.Forms.Label();
            this.AddCriteria1 = new System.Windows.Forms.TextBox();
            this.Criteria = new System.Windows.Forms.Label();
            this.AddCriteriaPanel = new System.Windows.Forms.Panel();
            this.CriteriaBtn = new System.Windows.Forms.Button();
            this.availableCriteriaPanel = new System.Windows.Forms.Panel();
            this.viewCriteria = new System.Windows.Forms.Button();
            this.AddCriteriaPanel.SuspendLayout();
            this.availableCriteriaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminLogin
            // 
            this.AdminLogin.AutoSize = true;
            this.AdminLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminLogin.Location = new System.Drawing.Point(273, 15);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(233, 35);
            this.AdminLogin.TabIndex = 1;
            this.AdminLogin.Text = "Welcome Admin";
            // 
            // AddCriteria1
            // 
            this.AddCriteria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCriteria1.Location = new System.Drawing.Point(215, 64);
            this.AddCriteria1.Name = "AddCriteria1";
            this.AddCriteria1.Size = new System.Drawing.Size(309, 34);
            this.AddCriteria1.TabIndex = 2;
            // 
            // Criteria
            // 
            this.Criteria.AutoSize = true;
            this.Criteria.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criteria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Criteria.Location = new System.Drawing.Point(277, 14);
            this.Criteria.Name = "Criteria";
            this.Criteria.Size = new System.Drawing.Size(173, 35);
            this.Criteria.TabIndex = 4;
            this.Criteria.Text = "Add Criteria";
            // 
            // AddCriteriaPanel
            // 
            this.AddCriteriaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddCriteriaPanel.Controls.Add(this.CriteriaBtn);
            this.AddCriteriaPanel.Controls.Add(this.AddCriteria1);
            this.AddCriteriaPanel.Controls.Add(this.Criteria);
            this.AddCriteriaPanel.Location = new System.Drawing.Point(16, 53);
            this.AddCriteriaPanel.Name = "AddCriteriaPanel";
            this.AddCriteriaPanel.Size = new System.Drawing.Size(725, 114);
            this.AddCriteriaPanel.TabIndex = 5;
            // 
            // CriteriaBtn
            // 
            this.CriteriaBtn.FlatAppearance.BorderSize = 0;
            this.CriteriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriteriaBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaBtn.Location = new System.Drawing.Point(554, 59);
            this.CriteriaBtn.Name = "CriteriaBtn";
            this.CriteriaBtn.Size = new System.Drawing.Size(99, 39);
            this.CriteriaBtn.TabIndex = 5;
            this.CriteriaBtn.Text = "Add";
            this.CriteriaBtn.UseVisualStyleBackColor = true;
            this.CriteriaBtn.Click += new System.EventHandler(this.CriteriaBtn_Click_1);
            // 
            // availableCriteriaPanel
            // 
            this.availableCriteriaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableCriteriaPanel.Controls.Add(this.viewCriteria);
            this.availableCriteriaPanel.Location = new System.Drawing.Point(16, 184);
            this.availableCriteriaPanel.Name = "availableCriteriaPanel";
            this.availableCriteriaPanel.Size = new System.Drawing.Size(725, 274);
            this.availableCriteriaPanel.TabIndex = 5;
            // 
            // viewCriteria
            // 
            this.viewCriteria.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCriteria.Location = new System.Drawing.Point(262, 100);
            this.viewCriteria.Name = "viewCriteria";
            this.viewCriteria.Size = new System.Drawing.Size(202, 41);
            this.viewCriteria.TabIndex = 0;
            this.viewCriteria.Text = "View Criteria";
            this.viewCriteria.UseVisualStyleBackColor = true;
            this.viewCriteria.Click += new System.EventHandler(this.viewCriteria_Click);
            // 
            // AddCriteria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.availableCriteriaPanel);
            this.Controls.Add(this.AddCriteriaPanel);
            this.Controls.Add(this.AdminLogin);
            this.MaximumSize = new System.Drawing.Size(755, 550);
            this.MinimumSize = new System.Drawing.Size(755, 550);
            this.Name = "AddCriteria";
            this.Size = new System.Drawing.Size(755, 550);
            this.AddCriteriaPanel.ResumeLayout(false);
            this.AddCriteriaPanel.PerformLayout();
            this.availableCriteriaPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLogin;
        private System.Windows.Forms.TextBox AddCriteria1;
        private System.Windows.Forms.Label Criteria;
        private System.Windows.Forms.Panel AddCriteriaPanel;
        private System.Windows.Forms.Panel availableCriteriaPanel;
        private System.Windows.Forms.Button CriteriaBtn;
        private System.Windows.Forms.Button viewCriteria;
    }
}

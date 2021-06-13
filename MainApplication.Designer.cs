namespace FeedbackRatingApplicaiton
{
    partial class MainApplication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartForm = new System.Windows.Forms.Button();
            this.FeedbackForm = new System.Windows.Forms.Button();
            this.AddCriteria = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.importButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titlePanel.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Sienna;
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(939, 55);
            this.titlePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO RATING SERVICE";
            // 
            // ChartForm
            // 
            this.ChartForm.BackColor = System.Drawing.Color.Gray;
            this.ChartForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChartForm.FlatAppearance.BorderSize = 0;
            this.ChartForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChartForm.Location = new System.Drawing.Point(3, 343);
            this.ChartForm.Name = "ChartForm";
            this.ChartForm.Size = new System.Drawing.Size(165, 48);
            this.ChartForm.TabIndex = 2;
            this.ChartForm.Text = "View Chart";
            this.ChartForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChartForm.UseVisualStyleBackColor = false;
            this.ChartForm.Click += new System.EventHandler(this.ChartForm_Click);
            // 
            // FeedbackForm
            // 
            this.FeedbackForm.BackColor = System.Drawing.Color.Gray;
            this.FeedbackForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeedbackForm.FlatAppearance.BorderSize = 0;
            this.FeedbackForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedbackForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FeedbackForm.Location = new System.Drawing.Point(3, 127);
            this.FeedbackForm.Name = "FeedbackForm";
            this.FeedbackForm.Size = new System.Drawing.Size(165, 48);
            this.FeedbackForm.TabIndex = 2;
            this.FeedbackForm.Text = "Give Feedback";
            this.FeedbackForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FeedbackForm.UseVisualStyleBackColor = false;
            this.FeedbackForm.Click += new System.EventHandler(this.FeedbackForm_Click);
            // 
            // AddCriteria
            // 
            this.AddCriteria.BackColor = System.Drawing.Color.Gray;
            this.AddCriteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCriteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCriteria.FlatAppearance.BorderSize = 0;
            this.AddCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCriteria.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCriteria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCriteria.Location = new System.Drawing.Point(3, 58);
            this.AddCriteria.Name = "AddCriteria";
            this.AddCriteria.Size = new System.Drawing.Size(165, 48);
            this.AddCriteria.TabIndex = 4;
            this.AddCriteria.Text = "Add Criteria";
            this.AddCriteria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCriteria.UseVisualStyleBackColor = false;
            this.AddCriteria.Click += new System.EventHandler(this.CreateFeedback_Click);
            // 
            // sideBar
            // 
            this.sideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideBar.BackColor = System.Drawing.Color.Maroon;
            this.sideBar.Controls.Add(this.importButton);
            this.sideBar.Controls.Add(this.reportButton);
            this.sideBar.Controls.Add(this.AddCriteria);
            this.sideBar.Controls.Add(this.FeedbackForm);
            this.sideBar.Controls.Add(this.ChartForm);
            this.sideBar.Location = new System.Drawing.Point(3, 57);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(171, 557);
            this.sideBar.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.Gray;
            this.importButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importButton.FlatAppearance.BorderSize = 0;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importButton.Location = new System.Drawing.Point(3, 198);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(165, 54);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import CSV";
            this.importButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.Gray;
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportButton.Location = new System.Drawing.Point(3, 276);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(165, 48);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "View Report";
            this.reportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gray;
            this.mainPanel.Location = new System.Drawing.Point(174, 57);
            this.mainPanel.MaximumSize = new System.Drawing.Size(755, 550);
            this.mainPanel.MinimumSize = new System.Drawing.Size(755, 550);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(755, 550);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "MainApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Rating Application";
            this.Load += new System.EventHandler(this.Application_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button ChartForm;
        private System.Windows.Forms.Button FeedbackForm;
        private System.Windows.Forms.Button AddCriteria;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button importButton;
    }
}


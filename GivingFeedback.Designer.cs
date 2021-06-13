namespace FeedbackRatingApplicaiton
{
    partial class GivingFeedback
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.feedbackMessage = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.contactNumber = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.CriteriaDataGrid = new System.Windows.Forms.DataGridView();
            this.Criteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excellent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dissatisfied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbackMessage
            // 
            this.feedbackMessage.AutoSize = true;
            this.feedbackMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedbackMessage.Location = new System.Drawing.Point(151, 0);
            this.feedbackMessage.Name = "feedbackMessage";
            this.feedbackMessage.Size = new System.Drawing.Size(433, 49);
            this.feedbackMessage.TabIndex = 1;
            this.feedbackMessage.Text = "FeedBack Review Form";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerName.Location = new System.Drawing.Point(19, 76);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(158, 23);
            this.customerName.TabIndex = 2;
            this.customerName.Text = "Customer Name:";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(179, 67);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(206, 30);
            this.customerNameBox.TabIndex = 3;
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contactNumber.Location = new System.Drawing.Point(18, 111);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(151, 23);
            this.contactNumber.TabIndex = 2;
            this.contactNumber.Text = "Phone Number:";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberBox.Location = new System.Drawing.Point(175, 105);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(205, 30);
            this.phoneNumberBox.TabIndex = 4;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(412, 74);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 23);
            this.email.TabIndex = 2;
            this.email.Text = "Email:";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(480, 67);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(249, 30);
            this.emailBox.TabIndex = 5;
            // 
            // CriteriaDataGrid
            // 
            this.CriteriaDataGrid.AllowUserToAddRows = false;
            this.CriteriaDataGrid.AllowUserToResizeColumns = false;
            this.CriteriaDataGrid.AllowUserToResizeRows = false;
            this.CriteriaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CriteriaDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.CriteriaDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CriteriaDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CriteriaDataGrid.ColumnHeadersHeight = 30;
            this.CriteriaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CriteriaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criteria,
            this.Excellent,
            this.Good,
            this.Average,
            this.Dissatisfied});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CriteriaDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CriteriaDataGrid.EnableHeadersVisualStyles = false;
            this.CriteriaDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.CriteriaDataGrid.Location = new System.Drawing.Point(23, 163);
            this.CriteriaDataGrid.Name = "CriteriaDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CriteriaDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CriteriaDataGrid.RowHeadersVisible = false;
            this.CriteriaDataGrid.RowHeadersWidth = 62;
            this.CriteriaDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.CriteriaDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CriteriaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CriteriaDataGrid.Size = new System.Drawing.Size(681, 321);
            this.CriteriaDataGrid.TabIndex = 6;
            this.CriteriaDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CriteriaDataGrid_CellContentClick);
            // 
            // Criteria
            // 
            this.Criteria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Criteria.DefaultCellStyle = dataGridViewCellStyle2;
            this.Criteria.FillWeight = 449.2386F;
            this.Criteria.HeaderText = "Criteria";
            this.Criteria.MinimumWidth = 15;
            this.Criteria.Name = "Criteria";
            this.Criteria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Criteria.Width = 128;
            // 
            // Excellent
            // 
            this.Excellent.FillWeight = 10.96739F;
            this.Excellent.HeaderText = "Excellent";
            this.Excellent.MinimumWidth = 8;
            this.Excellent.Name = "Excellent";
            // 
            // Good
            // 
            this.Good.FillWeight = 12.23024F;
            this.Good.HeaderText = "Good";
            this.Good.MinimumWidth = 8;
            this.Good.Name = "Good";
            // 
            // Average
            // 
            this.Average.FillWeight = 13.32437F;
            this.Average.HeaderText = "Average";
            this.Average.MinimumWidth = 8;
            this.Average.Name = "Average";
            // 
            // Dissatisfied
            // 
            this.Dissatisfied.FillWeight = 14.23941F;
            this.Dissatisfied.HeaderText = "Dissatisfied";
            this.Dissatisfied.MinimumWidth = 8;
            this.Dissatisfied.Name = "Dissatisfied";
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.ReviewButton.FlatAppearance.BorderSize = 0;
            this.ReviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReviewButton.Location = new System.Drawing.Point(285, 490);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(224, 46);
            this.ReviewButton.TabIndex = 7;
            this.ReviewButton.Text = "Give Review";
            this.ReviewButton.UseVisualStyleBackColor = false;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(412, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(503, 105);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(249, 30);
            this.addressBox.TabIndex = 9;
            // 
            // GivingFeedback
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReviewButton);
            this.Controls.Add(this.CriteriaDataGrid);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.feedbackMessage);
            this.MaximumSize = new System.Drawing.Size(755, 550);
            this.MinimumSize = new System.Drawing.Size(755, 550);
            this.Name = "GivingFeedback";
            this.Size = new System.Drawing.Size(755, 550);
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feedbackMessage;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button ReviewButton;
        public System.Windows.Forms.TextBox customerNameBox;
        public System.Windows.Forms.DataGridView CriteriaDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criteria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excellent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Good;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Average;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dissatisfied;
    }
}

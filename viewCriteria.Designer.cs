
namespace FeedbackRatingApplicaiton
{
    partial class viewCriteria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriaGridData = new System.Windows.Forms.DataGridView();
            this.CriteriaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Criteria";
            // 
            // CriteriaGridData
            // 
            this.CriteriaGridData.AllowUserToAddRows = false;
            this.CriteriaGridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CriteriaGridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CriteriaGridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CriteriaGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriteriaGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CriteriaType});
            this.CriteriaGridData.Location = new System.Drawing.Point(81, 100);
            this.CriteriaGridData.Name = "CriteriaGridData";
            this.CriteriaGridData.RowHeadersVisible = false;
            this.CriteriaGridData.RowHeadersWidth = 62;
            this.CriteriaGridData.RowTemplate.Height = 28;
            this.CriteriaGridData.Size = new System.Drawing.Size(263, 276);
            this.CriteriaGridData.TabIndex = 6;
           
            // 
            // CriteriaType
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CriteriaType.DefaultCellStyle = dataGridViewCellStyle2;
            this.CriteriaType.HeaderText = "Criteria";
            this.CriteriaType.MinimumWidth = 8;
            this.CriteriaType.Name = "CriteriaType";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(81, 415);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(189, 32);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete Criteria";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // viewCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(522, 599);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CriteriaGridData);
            this.Controls.Add(this.label1);
            this.Name = "viewCriteria";
            this.Text = "viewCriteria";
            this.Load += new System.EventHandler(this.viewCriteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CriteriaGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriteriaType;
        private System.Windows.Forms.Button delete;
    }
}

namespace FeedbackRatingApplicaiton
{
    partial class ChartGenerate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chartGenerateButton = new System.Windows.Forms.Button();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(525, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(17, 13);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Visible = false;
            // 
            // chartGenerateButton
            // 
            this.chartGenerateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartGenerateButton.Location = new System.Drawing.Point(100, 430);
            this.chartGenerateButton.Name = "chartGenerateButton";
            this.chartGenerateButton.Size = new System.Drawing.Size(164, 60);
            this.chartGenerateButton.TabIndex = 2;
            this.chartGenerateButton.Text = "Generate Chart";
            this.chartGenerateButton.UseVisualStyleBackColor = true;
            this.chartGenerateButton.Click += new System.EventHandler(this.chartGenerateButton_Click_1);
            // 
            // piechart
            // 
            this.piechart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.piechart.BackColor = System.Drawing.SystemColors.Window;
            this.piechart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.piechart.Legends.Add(legend1);
            this.piechart.Location = new System.Drawing.Point(100, 121);
            this.piechart.Margin = new System.Windows.Forms.Padding(2);
            this.piechart.Name = "piechart";
            this.piechart.Size = new System.Drawing.Size(316, 240);
            this.piechart.TabIndex = 5;
            this.piechart.Text = "chart";
            // 
            // ChartGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.piechart);
            this.Controls.Add(this.chartGenerateButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ChartGenerate";
            this.Size = new System.Drawing.Size(555, 527);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button chartGenerateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
    }
}

using System.ComponentModel;

namespace Manipulator.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.runSimulation = new System.Windows.Forms.Button();
            this.motorSpecificationGridView = new System.Windows.Forms.DataGridView();
            this.motorParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.motorSpecificationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // runSimulation
            // 
            this.runSimulation.BackColor = System.Drawing.Color.LimeGreen;
            this.runSimulation.Location = new System.Drawing.Point(635, 397);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(153, 41);
            this.runSimulation.TabIndex = 0;
            this.runSimulation.Text = "Начать моделирование";
            this.runSimulation.UseMnemonic = false;
            this.runSimulation.UseVisualStyleBackColor = false;
            this.runSimulation.Click += new System.EventHandler(this.runSimulation_Click);
            // 
            // motorSpecificationGridView
            // 
            this.motorSpecificationGridView.AllowUserToAddRows = false;
            this.motorSpecificationGridView.AllowUserToDeleteRows = false;
            this.motorSpecificationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.motorSpecificationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.motorParameterName, this.motorParameterValue});
            this.motorSpecificationGridView.Location = new System.Drawing.Point(6, 4);
            this.motorSpecificationGridView.Name = "motorSpecificationGridView";
            this.motorSpecificationGridView.ReadOnly = true;
            this.motorSpecificationGridView.Size = new System.Drawing.Size(246, 434);
            this.motorSpecificationGridView.TabIndex = 1;
            // 
            // motorParameterName
            // 
            this.motorParameterName.HeaderText = "Параметр";
            this.motorParameterName.Name = "motorParameterName";
            this.motorParameterName.ReadOnly = true;
            // 
            // motorParameterValue
            // 
            this.motorParameterValue.HeaderText = "Значение";
            this.motorParameterValue.Name = "motorParameterValue";
            this.motorParameterValue.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.motorSpecificationGridView);
            this.Controls.Add(this.runSimulation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Manipulator Controll App";
            ((System.ComponentModel.ISupportInitialize) (this.motorSpecificationGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn motorParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorParameterValue;

        private System.Windows.Forms.DataGridView motorSpecificationGridView;

        public System.Windows.Forms.Button runSimulation;

        #endregion
    }
}
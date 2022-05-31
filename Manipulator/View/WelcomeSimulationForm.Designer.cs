using System.ComponentModel;

namespace Manipulator.View
{
    partial class WelcomeSimulationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.controlObjectName = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(121, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя объекта управления";
            // 
            // controlObjectName
            // 
            this.controlObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.controlObjectName.Location = new System.Drawing.Point(121, 99);
            this.controlObjectName.Name = "controlObjectName";
            this.controlObjectName.Size = new System.Drawing.Size(313, 29);
            this.controlObjectName.TabIndex = 1;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Lime;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.continueButton.Location = new System.Drawing.Point(121, 147);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(313, 46);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Продолжить";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // WelcomeSimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 277);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.controlObjectName);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeSimulationForm";
            this.Text = "WelcomeSimulationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button continueButton;

        private System.Windows.Forms.TextBox controlObjectName;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
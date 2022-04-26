﻿using System.ComponentModel;
using ChartDirector;

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
            this.components = new System.ComponentModel.Container();
            this.runSimulation = new System.Windows.Forms.Button();
            this.motorSpecificationBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedRatioTextBox = new System.Windows.Forms.TextBox();
            this.windingResistanceTextBox = new System.Windows.Forms.TextBox();
            this.windingInductanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instantaneousFactorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlElementSecificationBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.springConstantTextBox = new System.Windows.Forms.TextBox();
            this.frictionCoefficientTextBox = new System.Windows.Forms.TextBox();
            this.inertiaMomentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.samplingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.controlSignalTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stopSimulationButton = new System.Windows.Forms.Button();
            this.winChartViewer = new ChartDirector.WinChartViewer();
            this.updateChart = new System.Windows.Forms.Timer(this.components);
            this.motorSpecificationBox.SuspendLayout();
            this.controlElementSecificationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.winChartViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // runSimulation
            // 
            this.runSimulation.BackColor = System.Drawing.Color.LimeGreen;
            this.runSimulation.Location = new System.Drawing.Point(102, 412);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(153, 41);
            this.runSimulation.TabIndex = 0;
            this.runSimulation.Text = "Начать моделирование";
            this.runSimulation.UseMnemonic = false;
            this.runSimulation.UseVisualStyleBackColor = false;
            this.runSimulation.Click += new System.EventHandler(this.runSimulation_Click);
            // 
            // motorSpecificationBox
            // 
            this.motorSpecificationBox.Controls.Add(this.label4);
            this.motorSpecificationBox.Controls.Add(this.label3);
            this.motorSpecificationBox.Controls.Add(this.speedRatioTextBox);
            this.motorSpecificationBox.Controls.Add(this.windingResistanceTextBox);
            this.motorSpecificationBox.Controls.Add(this.windingInductanceTextBox);
            this.motorSpecificationBox.Controls.Add(this.label2);
            this.motorSpecificationBox.Controls.Add(this.instantaneousFactorTextBox);
            this.motorSpecificationBox.Controls.Add(this.label1);
            this.motorSpecificationBox.Location = new System.Drawing.Point(12, 12);
            this.motorSpecificationBox.Name = "motorSpecificationBox";
            this.motorSpecificationBox.Size = new System.Drawing.Size(447, 120);
            this.motorSpecificationBox.TabIndex = 1;
            this.motorSpecificationBox.TabStop = false;
            this.motorSpecificationBox.Text = "Параметры двигателя";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скоростной коэффициент двигателя, Ke";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Активное сопротивление обмотки якоря двигателя, R";
            // 
            // speedRatioTextBox
            // 
            this.speedRatioTextBox.Location = new System.Drawing.Point(315, 91);
            this.speedRatioTextBox.Name = "speedRatioTextBox";
            this.speedRatioTextBox.Size = new System.Drawing.Size(105, 20);
            this.speedRatioTextBox.TabIndex = 5;
            // 
            // windingResistanceTextBox
            // 
            this.windingResistanceTextBox.Location = new System.Drawing.Point(315, 65);
            this.windingResistanceTextBox.Name = "windingResistanceTextBox";
            this.windingResistanceTextBox.Size = new System.Drawing.Size(105, 20);
            this.windingResistanceTextBox.TabIndex = 4;
            // 
            // windingInductanceTextBox
            // 
            this.windingInductanceTextBox.Location = new System.Drawing.Point(315, 39);
            this.windingInductanceTextBox.Name = "windingInductanceTextBox";
            this.windingInductanceTextBox.Size = new System.Drawing.Size(105, 20);
            this.windingInductanceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Индуктивность обмотки якоря двигателя, L";
            // 
            // instantaneousFactorTextBox
            // 
            this.instantaneousFactorTextBox.Location = new System.Drawing.Point(315, 12);
            this.instantaneousFactorTextBox.Name = "instantaneousFactorTextBox";
            this.instantaneousFactorTextBox.Size = new System.Drawing.Size(105, 20);
            this.instantaneousFactorTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Моментальный коэффициент двигателя, Kt";
            // 
            // controlElementSecificationBox
            // 
            this.controlElementSecificationBox.Controls.Add(this.label7);
            this.controlElementSecificationBox.Controls.Add(this.label6);
            this.controlElementSecificationBox.Controls.Add(this.springConstantTextBox);
            this.controlElementSecificationBox.Controls.Add(this.frictionCoefficientTextBox);
            this.controlElementSecificationBox.Controls.Add(this.inertiaMomentTextBox);
            this.controlElementSecificationBox.Controls.Add(this.label5);
            this.controlElementSecificationBox.Location = new System.Drawing.Point(12, 138);
            this.controlElementSecificationBox.Name = "controlElementSecificationBox";
            this.controlElementSecificationBox.Size = new System.Drawing.Size(446, 91);
            this.controlElementSecificationBox.TabIndex = 2;
            this.controlElementSecificationBox.TabStop = false;
            this.controlElementSecificationBox.Text = "Параметры объекта управления";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Коэффициент жёсткости пружины, K";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Коэффициент вязкого трения в подшипниках, C";
            // 
            // springConstantTextBox
            // 
            this.springConstantTextBox.Location = new System.Drawing.Point(315, 64);
            this.springConstantTextBox.Name = "springConstantTextBox";
            this.springConstantTextBox.Size = new System.Drawing.Size(105, 20);
            this.springConstantTextBox.TabIndex = 4;
            // 
            // frictionCoefficientTextBox
            // 
            this.frictionCoefficientTextBox.Location = new System.Drawing.Point(315, 38);
            this.frictionCoefficientTextBox.Name = "frictionCoefficientTextBox";
            this.frictionCoefficientTextBox.Size = new System.Drawing.Size(105, 20);
            this.frictionCoefficientTextBox.TabIndex = 3;
            // 
            // inertiaMomentTextBox
            // 
            this.inertiaMomentTextBox.Location = new System.Drawing.Point(315, 12);
            this.inertiaMomentTextBox.Name = "inertiaMomentTextBox";
            this.inertiaMomentTextBox.Size = new System.Drawing.Size(105, 20);
            this.inertiaMomentTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Момент инерции звена, J";
            // 
            // samplingTimeTextBox
            // 
            this.samplingTimeTextBox.Location = new System.Drawing.Point(327, 244);
            this.samplingTimeTextBox.Name = "samplingTimeTextBox";
            this.samplingTimeTextBox.Size = new System.Drawing.Size(105, 20);
            this.samplingTimeTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Шаг моделирования, t [c]";
            // 
            // controlSignalTextBox
            // 
            this.controlSignalTextBox.Location = new System.Drawing.Point(327, 270);
            this.controlSignalTextBox.Name = "controlSignalTextBox";
            this.controlSignalTextBox.Size = new System.Drawing.Size(105, 20);
            this.controlSignalTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Управляющий сигнал";
            // 
            // stopSimulationButton
            // 
            this.stopSimulationButton.BackColor = System.Drawing.Color.Red;
            this.stopSimulationButton.Location = new System.Drawing.Point(279, 412);
            this.stopSimulationButton.Name = "stopSimulationButton";
            this.stopSimulationButton.Size = new System.Drawing.Size(153, 41);
            this.stopSimulationButton.TabIndex = 10;
            this.stopSimulationButton.Text = "Остановить моделирование";
            this.stopSimulationButton.UseMnemonic = false;
            this.stopSimulationButton.UseVisualStyleBackColor = false;
            this.stopSimulationButton.Click += new System.EventHandler(this.stopSimulationButton_Click);
            // 
            // winChartViewer
            // 
            this.winChartViewer.Location = new System.Drawing.Point(483, 12);
            this.winChartViewer.Name = "winChartViewer";
            this.winChartViewer.Size = new System.Drawing.Size(740, 440);
            this.winChartViewer.TabIndex = 11;
            this.winChartViewer.TabStop = false;
            // 
            // updateChart
            // 
            this.updateChart.Tick += new System.EventHandler(this.updateChart_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1280, 479);
            this.Controls.Add(this.winChartViewer);
            this.Controls.Add(this.stopSimulationButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.controlSignalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.samplingTimeTextBox);
            this.Controls.Add(this.controlElementSecificationBox);
            this.Controls.Add(this.motorSpecificationBox);
            this.Controls.Add(this.runSimulation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Manipulator Controll App";
            this.motorSpecificationBox.ResumeLayout(false);
            this.motorSpecificationBox.PerformLayout();
            this.controlElementSecificationBox.ResumeLayout(false);
            this.controlElementSecificationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.winChartViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Timer updateChart;

        private ChartDirector.WinChartViewer winChartViewer;

        public System.Windows.Forms.Button stopSimulationButton;

        public System.Windows.Forms.TextBox controlSignalTextBox;
        private System.Windows.Forms.Label label9;

        public System.Windows.Forms.TextBox samplingTimeTextBox;
        private System.Windows.Forms.Label label8;

        public System.Windows.Forms.GroupBox controlElementSecificationBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox inertiaMomentTextBox;
        public System.Windows.Forms.TextBox frictionCoefficientTextBox;
        public System.Windows.Forms.TextBox springConstantTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox windingInductanceTextBox;
        public System.Windows.Forms.TextBox windingResistanceTextBox;
        public System.Windows.Forms.TextBox speedRatioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox motorSpecificationBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox instantaneousFactorTextBox;

        public System.Windows.Forms.Button runSimulation;

        public WinChartViewer ChartViewer;

        #endregion
    }
}
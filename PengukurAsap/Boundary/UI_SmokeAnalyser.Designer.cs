using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace PengukurAsap
{
    partial class UI_SmokeAnalyser
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
            this.components = new System.ComponentModel.Container();
            this.configButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.status = new System.Windows.Forms.Label();
            this.simpleReportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(518, 268);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(136, 23);
            this.configButton.TabIndex = 0;
            this.configButton.Text = "config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(518, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 53);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START ANALIZE";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(518, 312);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(135, 23);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "history";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox.Location = new System.Drawing.Point(13, 13);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(478, 322);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(13, 342);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 3;
            this.status.Text = "status";
            // 
            // simpleReportLabel
            // 
            this.simpleReportLabel.AutoSize = true;
            this.simpleReportLabel.Location = new System.Drawing.Point(498, 72);
            this.simpleReportLabel.Name = "simpleReportLabel";
            this.simpleReportLabel.Size = new System.Drawing.Size(0, 13);
            this.simpleReportLabel.TabIndex = 4;
            // 
            // UI_SmokeAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 366);
            this.Controls.Add(this.simpleReportLabel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.configButton);
            this.Name = "UI_SmokeAnalyser";
            this.Text = "SmokeAnalyser";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

       

        #endregion

        private Button configButton;
        private Button startButton;
        private Button historyButton;
        private Emgu.CV.UI.ImageBox imageBox;
        private Label status;
        private Label simpleReportLabel;
    }
}
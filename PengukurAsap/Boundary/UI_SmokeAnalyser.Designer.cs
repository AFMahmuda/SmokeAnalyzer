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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(498, 269);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(136, 23);
            this.configButton.TabIndex = 0;
            this.configButton.Text = "config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(497, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 53);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START ANALIZE";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(499, 312);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(135, 23);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "history";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(13, 13);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(478, 322);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // UI_SmokeAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 366);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.configButton);
            this.Name = "UI_SmokeAnalyser";
            this.Text = "SmokeAnalyser";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button historyButton;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}
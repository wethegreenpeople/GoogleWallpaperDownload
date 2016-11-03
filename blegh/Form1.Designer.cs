namespace blegh
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ResolutionList = new System.Windows.Forms.ListBox();
            this.LabelScreenRes = new System.Windows.Forms.Label();
            this.listBoxMonitorNum = new System.Windows.Forms.ListBox();
            this.labelMonitorNum = new System.Windows.Forms.Label();
            this.textBoxAddKeywords = new System.Windows.Forms.TextBox();
            this.labelAddKeywords = new System.Windows.Forms.Label();
            this.progressBarImageDownload = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download Wallpapers!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResolutionList
            // 
            this.ResolutionList.AllowDrop = true;
            this.ResolutionList.FormattingEnabled = true;
            this.ResolutionList.Items.AddRange(new object[] {
            "1920 x 1080",
            "1776 x 1000",
            "1680 x 1050",
            "1600 x 900",
            "1440 x 900"});
            this.ResolutionList.Location = new System.Drawing.Point(12, 12);
            this.ResolutionList.Name = "ResolutionList";
            this.ResolutionList.Size = new System.Drawing.Size(120, 30);
            this.ResolutionList.TabIndex = 1;
            this.ResolutionList.SelectedIndexChanged += new System.EventHandler(this.ResolutionList_SelectedIndexChanged);
            // 
            // LabelScreenRes
            // 
            this.LabelScreenRes.AutoSize = true;
            this.LabelScreenRes.Location = new System.Drawing.Point(138, 29);
            this.LabelScreenRes.Name = "LabelScreenRes";
            this.LabelScreenRes.Size = new System.Drawing.Size(94, 13);
            this.LabelScreenRes.TabIndex = 2;
            this.LabelScreenRes.Text = "Screen Resolution";
            this.LabelScreenRes.Click += new System.EventHandler(this.LabelScreenRes_Click);
            // 
            // listBoxMonitorNum
            // 
            this.listBoxMonitorNum.AllowDrop = true;
            this.listBoxMonitorNum.FormattingEnabled = true;
            this.listBoxMonitorNum.Items.AddRange(new object[] {
            "Single Monitor",
            "Dual Monitor"});
            this.listBoxMonitorNum.Location = new System.Drawing.Point(12, 48);
            this.listBoxMonitorNum.Name = "listBoxMonitorNum";
            this.listBoxMonitorNum.Size = new System.Drawing.Size(120, 30);
            this.listBoxMonitorNum.TabIndex = 3;
            this.listBoxMonitorNum.SelectedIndexChanged += new System.EventHandler(this.listBoxMonitorNum_SelectedIndexChanged);
            // 
            // labelMonitorNum
            // 
            this.labelMonitorNum.AutoSize = true;
            this.labelMonitorNum.Location = new System.Drawing.Point(138, 65);
            this.labelMonitorNum.Name = "labelMonitorNum";
            this.labelMonitorNum.Size = new System.Drawing.Size(81, 13);
            this.labelMonitorNum.TabIndex = 4;
            this.labelMonitorNum.Text = "Monitor Amount";
            // 
            // textBoxAddKeywords
            // 
            this.textBoxAddKeywords.Location = new System.Drawing.Point(12, 84);
            this.textBoxAddKeywords.Name = "textBoxAddKeywords";
            this.textBoxAddKeywords.Size = new System.Drawing.Size(120, 20);
            this.textBoxAddKeywords.TabIndex = 5;
            this.textBoxAddKeywords.TextChanged += new System.EventHandler(this.textBoxAddKeywords_TextChanged);
            // 
            // labelAddKeywords
            // 
            this.labelAddKeywords.AutoSize = true;
            this.labelAddKeywords.Location = new System.Drawing.Point(138, 91);
            this.labelAddKeywords.Name = "labelAddKeywords";
            this.labelAddKeywords.Size = new System.Drawing.Size(102, 13);
            this.labelAddKeywords.TabIndex = 6;
            this.labelAddKeywords.Text = "Additional Keywords";
            // 
            // progressBarImageDownload
            // 
            this.progressBarImageDownload.Location = new System.Drawing.Point(12, 197);
            this.progressBarImageDownload.Name = "progressBarImageDownload";
            this.progressBarImageDownload.Size = new System.Drawing.Size(260, 23);
            this.progressBarImageDownload.TabIndex = 7;
            this.progressBarImageDownload.Click += new System.EventHandler(this.progressBarImageDownload_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBarImageDownload);
            this.Controls.Add(this.labelAddKeywords);
            this.Controls.Add(this.textBoxAddKeywords);
            this.Controls.Add(this.labelMonitorNum);
            this.Controls.Add(this.listBoxMonitorNum);
            this.Controls.Add(this.LabelScreenRes);
            this.Controls.Add(this.ResolutionList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ResolutionList;
        private System.Windows.Forms.Label LabelScreenRes;
        private System.Windows.Forms.ListBox listBoxMonitorNum;
        private System.Windows.Forms.Label labelMonitorNum;
        private System.Windows.Forms.TextBox textBoxAddKeywords;
        private System.Windows.Forms.Label labelAddKeywords;
        private System.Windows.Forms.ProgressBar progressBarImageDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


namespace DetailDataser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.LogLabel = new System.Windows.Forms.Label();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(25, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter name:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(603, 35);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(185, 27);
            this.NameBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(25, 128);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(133, 20);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Enter date of birth:";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // DayBox
            // 
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayBox.Location = new System.Drawing.Point(603, 125);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(45, 28);
            this.DayBox.TabIndex = 3;
            // 
            // MonthBox
            // 
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.MonthBox.Location = new System.Drawing.Point(654, 125);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(44, 28);
            this.MonthBox.TabIndex = 4;
            // 
            // YearBox
            // 
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(704, 125);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(84, 28);
            this.YearBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(603, 185);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(185, 48);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit Details";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(609, 251);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(0, 20);
            this.LogLabel.TabIndex = 7;
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(11, 246);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(782, 401);
            this.DisplayText.TabIndex = 8;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(11, 191);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(231, 49);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Load Details";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox NameBox;
        private Label AgeLabel;
        private ComboBox DayBox;
        private ComboBox MonthBox;
        private ComboBox YearBox;
        private Button SubmitButton;
        private Label LogLabel;
        private TextBox DisplayText;
        private Button LoadButton;
    }
}
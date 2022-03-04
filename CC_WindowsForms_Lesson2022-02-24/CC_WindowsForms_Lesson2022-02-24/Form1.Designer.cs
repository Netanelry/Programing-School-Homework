namespace CC_WindowsForms_Lesson2022_02_24
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
            this.pageHeadline = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.bDayLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.bDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vegiChecker = new System.Windows.Forms.CheckBox();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.nonGenderRadio = new System.Windows.Forms.RadioButton();
            this.rgstrButton = new System.Windows.Forms.Button();
            this.genderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeadline
            // 
            this.pageHeadline.AutoSize = true;
            this.pageHeadline.Font = new System.Drawing.Font("Varela Round", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.pageHeadline.Location = new System.Drawing.Point(142, 9);
            this.pageHeadline.Name = "pageHeadline";
            this.pageHeadline.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pageHeadline.Size = new System.Drawing.Size(236, 77);
            this.pageHeadline.TabIndex = 0;
            this.pageHeadline.Text = "הרשמה";
            this.pageHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pageHeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Varela Round", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MailLabel.Location = new System.Drawing.Point(381, 84);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MailLabel.Size = new System.Drawing.Size(140, 33);
            this.MailLabel.TabIndex = 1;
            this.MailLabel.Text = "כתובת מייל:";
            this.MailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Varela Round", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(427, 162);
            this.passLabel.Name = "passLabel";
            this.passLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passLabel.Size = new System.Drawing.Size(94, 33);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "סיסמא:";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bDayLabel
            // 
            this.bDayLabel.AutoSize = true;
            this.bDayLabel.Font = new System.Drawing.Font("Varela Round", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.bDayLabel.Location = new System.Drawing.Point(384, 240);
            this.bDayLabel.Name = "bDayLabel";
            this.bDayLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bDayLabel.Size = new System.Drawing.Size(137, 33);
            this.bDayLabel.TabIndex = 3;
            this.bDayLabel.Text = "תאריך לידה";
            this.bDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDayLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Varela Round", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(467, 348);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.genderLabel.Size = new System.Drawing.Size(45, 33);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "מין";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genderLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(299, 120);
            this.MailBox.Name = "MailBox";
            this.MailBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MailBox.Size = new System.Drawing.Size(213, 27);
            this.MailBox.TabIndex = 6;
            this.MailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(299, 198);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passBox.Size = new System.Drawing.Size(213, 27);
            this.passBox.TabIndex = 7;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bDayDateTimePicker
            // 
            this.bDayDateTimePicker.Location = new System.Drawing.Point(262, 276);
            this.bDayDateTimePicker.Name = "bDayDateTimePicker";
            this.bDayDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.bDayDateTimePicker.TabIndex = 8;
            // 
            // vegiChecker
            // 
            this.vegiChecker.AutoSize = true;
            this.vegiChecker.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vegiChecker.Location = new System.Drawing.Point(385, 319);
            this.vegiChecker.Name = "vegiChecker";
            this.vegiChecker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vegiChecker.Size = new System.Drawing.Size(127, 26);
            this.vegiChecker.TabIndex = 9;
            this.vegiChecker.Text = "האם צמחוני?";
            this.vegiChecker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vegiChecker.UseVisualStyleBackColor = true;
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.femaleRadio);
            this.genderPanel.Controls.Add(this.maleRadio);
            this.genderPanel.Controls.Add(this.nonGenderRadio);
            this.genderPanel.Location = new System.Drawing.Point(262, 384);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(250, 100);
            this.genderPanel.TabIndex = 10;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.femaleRadio.Location = new System.Drawing.Point(177, 67);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.femaleRadio.Size = new System.Drawing.Size(70, 26);
            this.femaleRadio.TabIndex = 2;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "נקבה";
            this.femaleRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maleRadio.Location = new System.Drawing.Point(189, 35);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maleRadio.Size = new System.Drawing.Size(58, 26);
            this.maleRadio.TabIndex = 1;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "זכר";
            this.maleRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // nonGenderRadio
            // 
            this.nonGenderRadio.AutoSize = true;
            this.nonGenderRadio.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nonGenderRadio.Location = new System.Drawing.Point(148, 3);
            this.nonGenderRadio.Name = "nonGenderRadio";
            this.nonGenderRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nonGenderRadio.Size = new System.Drawing.Size(99, 26);
            this.nonGenderRadio.TabIndex = 0;
            this.nonGenderRadio.TabStop = true;
            this.nonGenderRadio.Text = "לא מוגדר";
            this.nonGenderRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nonGenderRadio.UseVisualStyleBackColor = true;
            // 
            // rgstrButton
            // 
            this.rgstrButton.Font = new System.Drawing.Font("Varela Round", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rgstrButton.Location = new System.Drawing.Point(181, 500);
            this.rgstrButton.Name = "rgstrButton";
            this.rgstrButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rgstrButton.Size = new System.Drawing.Size(151, 56);
            this.rgstrButton.TabIndex = 11;
            this.rgstrButton.Text = "הרשמה";
            this.rgstrButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 568);
            this.Controls.Add(this.rgstrButton);
            this.Controls.Add(this.genderPanel);
            this.Controls.Add(this.vegiChecker);
            this.Controls.Add(this.bDayDateTimePicker);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.bDayLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.pageHeadline);
            this.Name = "Form1";
            this.Text = "Form1";
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pageHeadline;
        private Label MailLabel;
        private Label passLabel;
        private Label bDayLabel;
        private Label genderLabel;
        private TextBox MailBox;
        private TextBox passBox;
        private DateTimePicker bDayDateTimePicker;
        private CheckBox vegiChecker;
        private Panel genderPanel;
        private RadioButton femaleRadio;
        private RadioButton maleRadio;
        private RadioButton nonGenderRadio;
        private Button rgstrButton;
    }
}
namespace ScheduleMaker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxLfriday = new System.Windows.Forms.ComboBox();
            this.cbxLthursday = new System.Windows.Forms.ComboBox();
            this.cbxLwednesday = new System.Windows.Forms.ComboBox();
            this.cbxLtuesday = new System.Windows.Forms.ComboBox();
            this.cbxLmonday = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxSfriday = new System.Windows.Forms.ComboBox();
            this.cbxSthursday = new System.Windows.Forms.ComboBox();
            this.cbxEfriday = new System.Windows.Forms.ComboBox();
            this.cbxEthursday = new System.Windows.Forms.ComboBox();
            this.cbxEwednesday = new System.Windows.Forms.ComboBox();
            this.cbxEtuesday = new System.Windows.Forms.ComboBox();
            this.cbxSwednesday = new System.Windows.Forms.ComboBox();
            this.cbxStuesday = new System.Windows.Forms.ComboBox();
            this.cbxEmonday = new System.Windows.Forms.ComboBox();
            this.cbxSmonday = new System.Windows.Forms.ComboBox();
            this.lblTfriday = new System.Windows.Forms.Label();
            this.lblTthursday = new System.Windows.Forms.Label();
            this.lblTwednesday = new System.Windows.Forms.Label();
            this.lblTtuesday = new System.Windows.Forms.Label();
            this.lblTmonday = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLMonday = new System.Windows.Forms.TextBox();
            this.txtLTuesday = new System.Windows.Forms.TextBox();
            this.txtLWednesday = new System.Windows.Forms.TextBox();
            this.txtLThursday = new System.Windows.Forms.TextBox();
            this.txtLFriday = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtLFriday);
            this.groupBox1.Controls.Add(this.txtLThursday);
            this.groupBox1.Controls.Add(this.txtLWednesday);
            this.groupBox1.Controls.Add(this.txtLTuesday);
            this.groupBox1.Controls.Add(this.txtLMonday);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbxLfriday);
            this.groupBox1.Controls.Add(this.cbxLthursday);
            this.groupBox1.Controls.Add(this.cbxLwednesday);
            this.groupBox1.Controls.Add(this.cbxLtuesday);
            this.groupBox1.Controls.Add(this.cbxLmonday);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxSfriday);
            this.groupBox1.Controls.Add(this.cbxSthursday);
            this.groupBox1.Controls.Add(this.cbxEfriday);
            this.groupBox1.Controls.Add(this.cbxEthursday);
            this.groupBox1.Controls.Add(this.cbxEwednesday);
            this.groupBox1.Controls.Add(this.cbxEtuesday);
            this.groupBox1.Controls.Add(this.cbxSwednesday);
            this.groupBox1.Controls.Add(this.cbxStuesday);
            this.groupBox1.Controls.Add(this.cbxEmonday);
            this.groupBox1.Controls.Add(this.cbxSmonday);
            this.groupBox1.Controls.Add(this.lblTfriday);
            this.groupBox1.Controls.Add(this.lblTthursday);
            this.groupBox1.Controls.Add(this.lblTwednesday);
            this.groupBox1.Controls.Add(this.lblTtuesday);
            this.groupBox1.Controls.Add(this.lblTmonday);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 249);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Week";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxLfriday
            // 
            this.cbxLfriday.FormattingEnabled = true;
            this.cbxLfriday.Items.AddRange(new object[] {
            "0:00",
            "0:15",
            "0:30",
            "0:45",
            "1:00",
            "1:15",
            "1:30"});
            this.cbxLfriday.Location = new System.Drawing.Point(530, 89);
            this.cbxLfriday.Name = "cbxLfriday";
            this.cbxLfriday.Size = new System.Drawing.Size(66, 24);
            this.cbxLfriday.TabIndex = 9;
            // 
            // cbxLthursday
            // 
            this.cbxLthursday.FormattingEnabled = true;
            this.cbxLthursday.Items.AddRange(new object[] {
            "0:00",
            "0:15",
            "0:30",
            "0:45",
            "1:00",
            "1:15",
            "1:30"});
            this.cbxLthursday.Location = new System.Drawing.Point(432, 89);
            this.cbxLthursday.Name = "cbxLthursday";
            this.cbxLthursday.Size = new System.Drawing.Size(66, 24);
            this.cbxLthursday.TabIndex = 8;
            // 
            // cbxLwednesday
            // 
            this.cbxLwednesday.FormattingEnabled = true;
            this.cbxLwednesday.Items.AddRange(new object[] {
            "0:00",
            "0:15",
            "0:30",
            "0:45",
            "1:00",
            "1:15",
            "1:30"});
            this.cbxLwednesday.Location = new System.Drawing.Point(333, 89);
            this.cbxLwednesday.Name = "cbxLwednesday";
            this.cbxLwednesday.Size = new System.Drawing.Size(66, 24);
            this.cbxLwednesday.TabIndex = 7;
            // 
            // cbxLtuesday
            // 
            this.cbxLtuesday.FormattingEnabled = true;
            this.cbxLtuesday.Items.AddRange(new object[] {
            "0:00",
            "0:15",
            "0:30",
            "0:45",
            "1:00",
            "1:15",
            "1:30"});
            this.cbxLtuesday.Location = new System.Drawing.Point(233, 89);
            this.cbxLtuesday.Name = "cbxLtuesday";
            this.cbxLtuesday.Size = new System.Drawing.Size(66, 24);
            this.cbxLtuesday.TabIndex = 6;
            // 
            // cbxLmonday
            // 
            this.cbxLmonday.FormattingEnabled = true;
            this.cbxLmonday.Items.AddRange(new object[] {
            "0:00",
            "0:15",
            "0:30",
            "0:45",
            "1:00",
            "1:15",
            "1:30"});
            this.cbxLmonday.Location = new System.Drawing.Point(134, 89);
            this.cbxLmonday.Name = "cbxLmonday";
            this.cbxLmonday.Size = new System.Drawing.Size(66, 24);
            this.cbxLmonday.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Lunch Break:";
            // 
            // cbxSfriday
            // 
            this.cbxSfriday.FormattingEnabled = true;
            this.cbxSfriday.Items.AddRange(new object[] {
            "0:00",
            "7:00",
            "7:15",
            "7:30",
            "7:45",
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00"});
            this.cbxSfriday.Location = new System.Drawing.Point(530, 51);
            this.cbxSfriday.Name = "cbxSfriday";
            this.cbxSfriday.Size = new System.Drawing.Size(66, 24);
            this.cbxSfriday.TabIndex = 4;
            // 
            // cbxSthursday
            // 
            this.cbxSthursday.FormattingEnabled = true;
            this.cbxSthursday.Items.AddRange(new object[] {
            "0:00",
            "7:00",
            "7:15",
            "7:30",
            "7:45",
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00"});
            this.cbxSthursday.Location = new System.Drawing.Point(432, 51);
            this.cbxSthursday.Name = "cbxSthursday";
            this.cbxSthursday.Size = new System.Drawing.Size(66, 24);
            this.cbxSthursday.TabIndex = 3;
            // 
            // cbxEfriday
            // 
            this.cbxEfriday.FormattingEnabled = true;
            this.cbxEfriday.Items.AddRange(new object[] {
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "1:00",
            "1:15",
            "1:30",
            "1:45",
            "2:00",
            "2:15",
            "2:30",
            "2:45",
            "3:00",
            "3:15",
            "3:30",
            "3:45",
            "4:00",
            "4:15",
            "4:30",
            "4:45",
            "5:00",
            ""});
            this.cbxEfriday.Location = new System.Drawing.Point(530, 175);
            this.cbxEfriday.Name = "cbxEfriday";
            this.cbxEfriday.Size = new System.Drawing.Size(66, 24);
            this.cbxEfriday.TabIndex = 14;
            // 
            // cbxEthursday
            // 
            this.cbxEthursday.FormattingEnabled = true;
            this.cbxEthursday.Items.AddRange(new object[] {
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "1:00",
            "1:15",
            "1:30",
            "1:45",
            "2:00",
            "2:15",
            "2:30",
            "2:45",
            "3:00",
            "3:15",
            "3:30",
            "3:45",
            "4:00",
            "4:15",
            "4:30",
            "4:45",
            "5:00",
            ""});
            this.cbxEthursday.Location = new System.Drawing.Point(432, 175);
            this.cbxEthursday.Name = "cbxEthursday";
            this.cbxEthursday.Size = new System.Drawing.Size(66, 24);
            this.cbxEthursday.TabIndex = 13;
            // 
            // cbxEwednesday
            // 
            this.cbxEwednesday.FormattingEnabled = true;
            this.cbxEwednesday.Items.AddRange(new object[] {
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "1:00",
            "1:15",
            "1:30",
            "1:45",
            "2:00",
            "2:15",
            "2:30",
            "2:45",
            "3:00",
            "3:15",
            "3:30",
            "3:45",
            "4:00",
            "4:15",
            "4:30",
            "4:45",
            "5:00",
            ""});
            this.cbxEwednesday.Location = new System.Drawing.Point(333, 175);
            this.cbxEwednesday.Name = "cbxEwednesday";
            this.cbxEwednesday.Size = new System.Drawing.Size(66, 24);
            this.cbxEwednesday.TabIndex = 12;
            // 
            // cbxEtuesday
            // 
            this.cbxEtuesday.FormattingEnabled = true;
            this.cbxEtuesday.Items.AddRange(new object[] {
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "1:00",
            "1:15",
            "1:30",
            "1:45",
            "2:00",
            "2:15",
            "2:30",
            "2:45",
            "3:00",
            "3:15",
            "3:30",
            "3:45",
            "4:00",
            "4:15",
            "4:30",
            "4:45",
            "5:00",
            ""});
            this.cbxEtuesday.Location = new System.Drawing.Point(233, 175);
            this.cbxEtuesday.Name = "cbxEtuesday";
            this.cbxEtuesday.Size = new System.Drawing.Size(66, 24);
            this.cbxEtuesday.TabIndex = 11;
            // 
            // cbxSwednesday
            // 
            this.cbxSwednesday.FormattingEnabled = true;
            this.cbxSwednesday.Items.AddRange(new object[] {
            "0:00",
            "7:00",
            "7:15",
            "7:30",
            "7:45",
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00"});
            this.cbxSwednesday.Location = new System.Drawing.Point(333, 51);
            this.cbxSwednesday.Name = "cbxSwednesday";
            this.cbxSwednesday.Size = new System.Drawing.Size(66, 24);
            this.cbxSwednesday.TabIndex = 2;
            // 
            // cbxStuesday
            // 
            this.cbxStuesday.FormattingEnabled = true;
            this.cbxStuesday.Items.AddRange(new object[] {
            "0:00",
            "7:00",
            "7:15",
            "7:30",
            "7:45",
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00"});
            this.cbxStuesday.Location = new System.Drawing.Point(233, 51);
            this.cbxStuesday.Name = "cbxStuesday";
            this.cbxStuesday.Size = new System.Drawing.Size(66, 24);
            this.cbxStuesday.TabIndex = 1;
            // 
            // cbxEmonday
            // 
            this.cbxEmonday.FormattingEnabled = true;
            this.cbxEmonday.Location = new System.Drawing.Point(134, 175);
            this.cbxEmonday.Name = "cbxEmonday";
            this.cbxEmonday.Size = new System.Drawing.Size(66, 24);
            this.cbxEmonday.TabIndex = 10;
            // 
            // cbxSmonday
            // 
            this.cbxSmonday.FormattingEnabled = true;
            this.cbxSmonday.Items.AddRange(new object[] {
            "0:00",
            "7:00",
            "7:15",
            "7:30",
            "7:45",
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00"});
            this.cbxSmonday.Location = new System.Drawing.Point(134, 51);
            this.cbxSmonday.Name = "cbxSmonday";
            this.cbxSmonday.Size = new System.Drawing.Size(66, 24);
            this.cbxSmonday.TabIndex = 0;
            // 
            // lblTfriday
            // 
            this.lblTfriday.AutoSize = true;
            this.lblTfriday.Location = new System.Drawing.Point(546, 212);
            this.lblTfriday.Name = "lblTfriday";
            this.lblTfriday.Size = new System.Drawing.Size(0, 16);
            this.lblTfriday.TabIndex = 22;
            // 
            // lblTthursday
            // 
            this.lblTthursday.AutoSize = true;
            this.lblTthursday.Location = new System.Drawing.Point(447, 212);
            this.lblTthursday.Name = "lblTthursday";
            this.lblTthursday.Size = new System.Drawing.Size(0, 16);
            this.lblTthursday.TabIndex = 21;
            // 
            // lblTwednesday
            // 
            this.lblTwednesday.AutoSize = true;
            this.lblTwednesday.Location = new System.Drawing.Point(335, 212);
            this.lblTwednesday.Name = "lblTwednesday";
            this.lblTwednesday.Size = new System.Drawing.Size(0, 16);
            this.lblTwednesday.TabIndex = 20;
            // 
            // lblTtuesday
            // 
            this.lblTtuesday.AutoSize = true;
            this.lblTtuesday.Location = new System.Drawing.Point(239, 212);
            this.lblTtuesday.Name = "lblTtuesday";
            this.lblTtuesday.Size = new System.Drawing.Size(0, 16);
            this.lblTtuesday.TabIndex = 19;
            // 
            // lblTmonday
            // 
            this.lblTmonday.AutoSize = true;
            this.lblTmonday.Location = new System.Drawing.Point(146, 212);
            this.lblTmonday.Name = "lblTmonday";
            this.lblTmonday.Size = new System.Drawing.Size(0, 16);
            this.lblTmonday.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "End Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Start Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Friday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thursday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Wednesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tuesday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Monday";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(22, 288);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(169, 46);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total Hours:";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(299, 291);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(0, 29);
            this.lblTotalHours.TabIndex = 35;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(540, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 46);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(228, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(495, 46);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 360);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Lunch Time:";
            // 
            // txtLMonday
            // 
            this.txtLMonday.Location = new System.Drawing.Point(134, 132);
            this.txtLMonday.Name = "txtLMonday";
            this.txtLMonday.Size = new System.Drawing.Size(66, 22);
            this.txtLMonday.TabIndex = 33;
            // 
            // txtLTuesday
            // 
            this.txtLTuesday.Location = new System.Drawing.Point(233, 132);
            this.txtLTuesday.Name = "txtLTuesday";
            this.txtLTuesday.Size = new System.Drawing.Size(66, 22);
            this.txtLTuesday.TabIndex = 34;
            // 
            // txtLWednesday
            // 
            this.txtLWednesday.Location = new System.Drawing.Point(333, 132);
            this.txtLWednesday.Name = "txtLWednesday";
            this.txtLWednesday.Size = new System.Drawing.Size(66, 22);
            this.txtLWednesday.TabIndex = 35;
            // 
            // txtLThursday
            // 
            this.txtLThursday.Location = new System.Drawing.Point(432, 132);
            this.txtLThursday.Name = "txtLThursday";
            this.txtLThursday.Size = new System.Drawing.Size(66, 22);
            this.txtLThursday.TabIndex = 36;
            // 
            // txtLFriday
            // 
            this.txtLFriday.Location = new System.Drawing.Point(530, 132);
            this.txtLFriday.Name = "txtLFriday";
            this.txtLFriday.Size = new System.Drawing.Size(66, 22);
            this.txtLFriday.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 407);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTfriday;
        private System.Windows.Forms.Label lblTthursday;
        private System.Windows.Forms.Label lblTwednesday;
        private System.Windows.Forms.Label lblTtuesday;
        private System.Windows.Forms.Label lblTmonday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cbxSmonday;
        private System.Windows.Forms.ComboBox cbxEmonday;
        private System.Windows.Forms.ComboBox cbxSfriday;
        private System.Windows.Forms.ComboBox cbxSthursday;
        private System.Windows.Forms.ComboBox cbxEfriday;
        private System.Windows.Forms.ComboBox cbxEthursday;
        private System.Windows.Forms.ComboBox cbxEwednesday;
        private System.Windows.Forms.ComboBox cbxEtuesday;
        private System.Windows.Forms.ComboBox cbxSwednesday;
        private System.Windows.Forms.ComboBox cbxStuesday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.ComboBox cbxLfriday;
        private System.Windows.Forms.ComboBox cbxLthursday;
        private System.Windows.Forms.ComboBox cbxLwednesday;
        private System.Windows.Forms.ComboBox cbxLtuesday;
        private System.Windows.Forms.ComboBox cbxLmonday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLFriday;
        private System.Windows.Forms.TextBox txtLThursday;
        private System.Windows.Forms.TextBox txtLWednesday;
        private System.Windows.Forms.TextBox txtLTuesday;
        private System.Windows.Forms.TextBox txtLMonday;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


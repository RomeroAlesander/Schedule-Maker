using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;




namespace ScheduleMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*TimeSpan Smonday;
            TimeSpan Emonday;
            TimeSpan Tmonday;

            Smonday = TimeSpan.Parse(txtSmonday.Text);
            Emonday = TimeSpan.Parse(txtEmonday.Text);
            Tmonday = Emonday - Smonday;
            lblTmonday.Text = Tmonday.ToString();
             */

            /*TimeSpan Smonday;
            TimeSpan Emonday;
            TimeSpan Tmonday;

            Smonday = TimeSpan.Parse(cbxSmonday.SelectedValue.ToString());
            Emonday = TimeSpan.Parse(cbxEmonday.SelectedValue.ToString());
            Tmonday = Emonday - Smonday;
            lblTmonday.Text = Tmonday.ToString();
             */
            try
            {
                TimeSpan Smonday = TimeSpan.Parse(cbxSmonday.SelectedItem.ToString());
                TimeSpan Emonday = TimeSpan.Parse(cbxEmonday.SelectedValue.ToString());
                TimeSpan Lmonday = TimeSpan.Parse(cbxLmonday.SelectedItem.ToString());
                TimeSpan Tmonday;


                Tmonday = Emonday - Smonday - Lmonday;
                lblTmonday.Text = Tmonday.TotalHours.ToString("#.00");

                TimeSpan Stuesday = TimeSpan.Parse(cbxStuesday.SelectedItem.ToString());
                TimeSpan Etuesday = TimeSpan.Parse(cbxEtuesday.SelectedValue.ToString());
                TimeSpan Ltuesday = TimeSpan.Parse(cbxLtuesday.SelectedItem.ToString());
                TimeSpan Ttuesday;


                Ttuesday = Etuesday - Stuesday - Ltuesday;
                lblTtuesday.Text = Ttuesday.TotalHours.ToString("#.00");

                TimeSpan Swednesday = TimeSpan.Parse(cbxSwednesday.SelectedItem.ToString());
                TimeSpan Ewednesday = TimeSpan.Parse(cbxEwednesday.SelectedValue.ToString());
                TimeSpan Lwednesday = TimeSpan.Parse(cbxLwednesday.SelectedItem.ToString());
                TimeSpan Twednesday;


                Twednesday = Ewednesday - Swednesday - Lwednesday;
                lblTwednesday.Text = Twednesday.TotalHours.ToString("#.00");

                TimeSpan Sthursday = TimeSpan.Parse(cbxSthursday.SelectedItem.ToString());
                TimeSpan Ethursday = TimeSpan.Parse(cbxEthursday.SelectedValue.ToString());
                TimeSpan Lthursday = TimeSpan.Parse(cbxLthursday.SelectedItem.ToString());
                TimeSpan Tthursday;


                Tthursday = Ethursday - Sthursday - Lthursday;
                lblTthursday.Text = Tthursday.TotalHours.ToString("#.00");

                TimeSpan Sfriday = TimeSpan.Parse(cbxSfriday.SelectedItem.ToString());
                TimeSpan Efriday = TimeSpan.Parse(cbxEfriday.SelectedValue.ToString());
                TimeSpan Lfriday = TimeSpan.Parse(cbxLfriday.SelectedItem.ToString());
                TimeSpan Tfriday;
                TimeSpan Total;
                decimal totalHoursDecimal;


                Tfriday = Efriday - Sfriday - Lfriday;
                lblTfriday.Text = Tfriday.TotalHours.ToString("#.00");

                //lblTotalHours.Text = (Tmonday + Ttuesday + Twednesday + Tthursday + Tfriday).ToString() + " Hours";

                //totalHoursDecimal = Convert.ToDecimal(Tmonday + Ttuesday + Twednesday + Tthursday + Tfriday);
                Total = (Tmonday + Ttuesday + Twednesday + Tthursday + Tfriday);
                lblTotalHours.Text = Total.TotalHours.ToString("#.00");
                //lblTotalHours.Text = Convert.ToDecimal(ts.TotalHours).ToString("#.00");

                totalHoursDecimal = Convert.ToDecimal(Total.TotalHours);
                if (totalHoursDecimal > 37.5M)
                {
                    this.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.BackColor = System.Drawing.Color.LimeGreen;
                }
            }
            catch
            {
                MessageBox.Show("Fill out all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*var hours = new Dictionary<string, string>();
            hours["13:00"] = "1:00";
            hours["13:15"] = "1:15";
            hours["13:30"] = "1:30";
            hours["13:45"] = "1:45";
            hours["14:00"] = "2:00";
            hours["15:00"] = "3:00";

            cbxEmonday.DataSource = new BindingSource(hours, null);
            cbxEmonday.DisplayMember = "Value";
            cbxEmonday.ValueMember = "Key";
            */



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var hours = new Dictionary<string, string>();
            hours[""] = "";
            hours["00:00"] = "00:00";
            hours["10:00"] = "10:00";
            hours["10:15"] = "10:15";
            hours["10:30"] = "10:30";
            hours["10:45"] = "10:45";
            hours["11:00"] = "11:00";
            hours["11:15"] = "11:15";
            hours["11:30"] = "11:30";
            hours["11:45"] = "11:45";
            hours["12:00"] = "12:00";
            hours["12:15"] = "12:15";
            hours["12:30"] = "12:30";
            hours["12:45"] = "12:45";
            hours["13:00"] = "1:00";
            hours["13:00"] = "1:00";
            hours["13:15"] = "1:15";
            hours["13:30"] = "1:30";
            hours["13:45"] = "1:45";
            hours["14:00"] = "2:00";
            hours["14:15"] = "2:15";
            hours["14:30"] = "2:30";
            hours["14:45"] = "2:45";
            hours["15:00"] = "3:00";
            hours["15:15"] = "3:15";
            hours["15:30"] = "3:30";
            hours["15:45"] = "3:45";
            hours["16:00"] = "4:00";
            hours["16:15"] = "4:15";
            hours["16:30"] = "4:30";
            hours["16:45"] = "4:45";
            hours["17:00"] = "5:00";


            cbxEmonday.DataSource = new BindingSource(hours, null);
            cbxEmonday.DisplayMember = "Value";
            cbxEmonday.ValueMember = "Key";

            cbxEtuesday.DataSource = new BindingSource(hours, null);
            cbxEtuesday.DisplayMember = "Value";
            cbxEtuesday.ValueMember = "Key";

            cbxEwednesday.DataSource = new BindingSource(hours, null);
            cbxEwednesday.DisplayMember = "Value";
            cbxEwednesday.ValueMember = "Key";

            cbxEthursday.DataSource = new BindingSource(hours, null);
            cbxEthursday.DisplayMember = "Value";
            cbxEthursday.ValueMember = "Key";

            cbxEfriday.DataSource = new BindingSource(hours, null);
            cbxEfriday.DisplayMember = "Value";
            cbxEfriday.ValueMember = "Key";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //this.Close();
        }

        private void CreateDocument()
        {
            try
            {
                string documentName = dateTimePicker1.Value.ToShortDateString();

                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                //winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible = false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document.PageSetup.PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperLetter;
                document.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;

                ////Add header into the document
                //foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                //{
                //    //Get the header range and add the header details.
                //    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                //    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                //    headerRange.Font.Size = 10;
                //    headerRange.Text = "Header text goes here";
                //}

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                    footerRange.Text = "11/22/11 – Brown County/RG";
                }

                //adding text to document
                document.Content.SetRange(0, 0);
                string documentBody = "Weekly Time Report For The Week Ending:  ";
                document.Content.Text = documentBody + documentName + Environment.NewLine;
                document.Content.Text += "Name: Emelie Fearson" + Environment.NewLine;
                document.Content.Bold = 1;
                document.Content.Font.Name = "Times New Roman";
                document.Content.Font.Size = 14;

                ////Add paragraph with Heading 1 style
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading1 = "Heading 1";
                //para1.Range.set_Style(ref styleHeading1);
                //para1.Range.Text = "Para 1 text";
                //para1.Range.InsertParagraphAfter();

                ////Add paragraph with Heading 2 style
                //Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading2 = "Heading 2";
                //para2.Range.set_Style(ref styleHeading2);
                //para2.Range.Text = "Para 2 text";
                //para2.Range.InsertParagraphAfter();

                //Create a 5X5 table and insert some records
                Table firstTable = document.Tables.Add(para1.Range, 5, 6, ref missing, ref missing);
                firstTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                firstTable.Columns[1].PreferredWidth = 80f;
                firstTable.Columns[2].PreferredWidth = 100f;
                firstTable.Columns[3].PreferredWidth = 100f;
                firstTable.Columns[4].PreferredWidth = 100f;
                firstTable.Columns[5].PreferredWidth = 100f;
                firstTable.Columns[6].PreferredWidth = 100f;

                firstTable.Range.Paragraphs.SpaceAfter = 14;
                firstTable.Range.Paragraphs.SpaceBefore = 14;
                firstTable.Borders.Enable = 1;

                firstTable.Cell(1, 2).Range.Text = "Monday";
                firstTable.Cell(1, 2).Range.Font.Bold = 1;
                firstTable.Cell(1, 2).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(1, 2).Range.Font.Size = 12;


                firstTable.Cell(1, 3).Range.Text = "Tuesday";
                firstTable.Cell(1, 3).Range.Font.Bold = 1;
                firstTable.Cell(1, 3).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(1, 3).Range.Font.Size = 12;

                firstTable.Cell(1, 4).Range.Text = "Wednesday";
                firstTable.Cell(1, 4).Range.Font.Bold = 1;
                firstTable.Cell(1, 4).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(1, 4).Range.Font.Size = 12;

                firstTable.Cell(1, 5).Range.Text = "Thursday";
                firstTable.Cell(1, 5).Range.Font.Bold = 1;
                firstTable.Cell(1, 5).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(1, 5).Range.Font.Size = 12;

                firstTable.Cell(1, 6).Range.Text = "Friday";
                firstTable.Cell(1, 6).Range.Font.Bold = 1;
                firstTable.Cell(1, 6).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(1, 6).Range.Font.Size = 12;

                firstTable.Cell(2, 1).Range.Text = "Time In";
                firstTable.Cell(2, 1).Range.Font.Bold = 1;
                firstTable.Cell(2, 1).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(2, 1).Range.Font.Size = 12;

                firstTable.Cell(3, 1).Range.Text = "Lunch/Break";
                firstTable.Cell(3, 1).Range.Font.Bold = 1;
                firstTable.Cell(3, 1).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(3, 1).Range.Font.Size = 12;

                firstTable.Cell(4, 1).Range.Text = "Time Out";
                firstTable.Cell(4, 1).Range.Font.Bold = 1;
                firstTable.Cell(4, 1).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(4, 1).Range.Font.Size = 12;

                firstTable.Cell(5, 1).Range.Text = "Total Hours Each Day";
                firstTable.Cell(5, 1).Range.Font.Bold = 1;
                firstTable.Cell(5, 1).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(5, 1).Range.Font.Size = 12;

                firstTable.Cell(2, 2).Range.Text = cbxSmonday.SelectedItem.ToString();
                firstTable.Cell(2, 2).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(2, 2).Range.Font.Size = 14;
                firstTable.Cell(2, 2).Range.Font.Bold = 0;
                firstTable.Cell(2, 2).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(2, 3).Range.Text = cbxStuesday.SelectedItem.ToString();
                firstTable.Cell(2, 3).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(2, 3).Range.Font.Size = 14;
                firstTable.Cell(2, 3).Range.Font.Bold = 0;
                firstTable.Cell(2, 3).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(2, 4).Range.Text = cbxSwednesday.SelectedItem.ToString();
                firstTable.Cell(2, 4).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(2, 4).Range.Font.Size = 14;
                firstTable.Cell(2, 4).Range.Font.Bold = 0;
                firstTable.Cell(2, 4).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(2, 5).Range.Text = cbxSthursday.SelectedItem.ToString();
                firstTable.Cell(2, 5).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(2, 5).Range.Font.Size = 14;
                firstTable.Cell(2, 5).Range.Font.Bold = 0;
                firstTable.Cell(2, 5).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(2, 6).Range.Text = cbxSfriday.SelectedItem.ToString();
                firstTable.Cell(2, 6).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(2, 6).Range.Font.Size = 14;
                firstTable.Cell(2, 6).Range.Font.Bold = 0;
                firstTable.Cell(2, 6).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                string monday;
                if (txtLMonday.Text == null)
                {
                    monday = "";
                }
                else
                {
                    monday = txtLMonday.Text;
                }
                string tuesday;
                if (txtLTuesday.Text == null)
                {
                    tuesday = "";
                }
                else
                {
                    tuesday = txtLTuesday.Text;
                }
                string wednesday;
                if (txtLWednesday.Text == null)
                {
                    wednesday = "";
                }
                else
                {
                    wednesday = txtLWednesday.Text;
                }
                string thursday;
                if (txtLThursday.Text == null)
                {
                    thursday = "";
                }
                else
                {
                    thursday = txtLThursday.Text;
                }
                string friday;
                if (txtLFriday.Text == null)
                {
                    friday = "";
                }
                else
                {
                    friday = txtLFriday.Text;
                }


                firstTable.Cell(3, 2).Range.Text = monday;
                firstTable.Cell(3, 2).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(3, 2).Range.Font.Size = 14;
                firstTable.Cell(3, 2).Range.Font.Bold = 0;
                firstTable.Cell(3, 2).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(3, 3).Range.Text = tuesday;
                firstTable.Cell(3, 3).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(3, 3).Range.Font.Size = 14;
                firstTable.Cell(3, 3).Range.Font.Bold = 0;
                firstTable.Cell(3, 3).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(3, 4).Range.Text = wednesday;
                firstTable.Cell(3, 4).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(3, 4).Range.Font.Size = 14;
                firstTable.Cell(3, 4).Range.Font.Bold = 0;
                firstTable.Cell(3, 4).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(3, 5).Range.Text = thursday;
                firstTable.Cell(3, 5).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(3, 5).Range.Font.Size = 14;
                firstTable.Cell(3, 5).Range.Font.Bold = 0;
                firstTable.Cell(3, 5).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(3, 6).Range.Text = friday;
                firstTable.Cell(3, 6).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(3, 6).Range.Font.Size = 14;
                firstTable.Cell(3, 6).Range.Font.Bold = 0;
                firstTable.Cell(3, 6).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;



                firstTable.Cell(4, 2).Range.Text = ReturnCorrectValue(cbxEmonday.SelectedValue.ToString());
                firstTable.Cell(4, 2).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(4, 2).Range.Font.Size = 14;
                firstTable.Cell(4, 2).Range.Font.Bold = 0;
                firstTable.Cell(4, 2).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(4, 3).Range.Text = ReturnCorrectValue(cbxEtuesday.SelectedValue.ToString());
                firstTable.Cell(4, 3).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(4, 3).Range.Font.Size = 14;
                firstTable.Cell(4, 3).Range.Font.Bold = 0;
                firstTable.Cell(4, 3).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(4, 4).Range.Text = ReturnCorrectValue(cbxEwednesday.SelectedValue.ToString());
                firstTable.Cell(4, 4).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(4, 4).Range.Font.Size = 14;
                firstTable.Cell(4, 4).Range.Font.Bold = 0;
                firstTable.Cell(4, 4).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(4, 5).Range.Text = ReturnCorrectValue(cbxEthursday.SelectedValue.ToString());
                firstTable.Cell(4, 5).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(4, 5).Range.Font.Size = 14;
                firstTable.Cell(4, 5).Range.Font.Bold = 0;
                firstTable.Cell(4, 5).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(4, 6).Range.Text = ReturnCorrectValue(cbxEfriday.SelectedValue.ToString());
                firstTable.Cell(4, 6).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(4, 6).Range.Font.Size = 14;
                firstTable.Cell(4, 6).Range.Font.Bold = 0;
                firstTable.Cell(4, 6).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(5, 2).Range.Text = lblTmonday.Text;
                firstTable.Cell(5, 2).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(5, 2).Range.Font.Size = 18;
                firstTable.Cell(5, 2).Range.Font.Bold = 0;
                firstTable.Cell(5, 2).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(5, 3).Range.Text = lblTtuesday.Text;
                firstTable.Cell(5, 3).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(5, 3).Range.Font.Size = 18;
                firstTable.Cell(5, 3).Range.Font.Bold = 0;
                firstTable.Cell(5, 3).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(5, 4).Range.Text = lblTwednesday.Text;
                firstTable.Cell(5, 4).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(5, 4).Range.Font.Size = 18;
                firstTable.Cell(5, 4).Range.Font.Bold = 0;
                firstTable.Cell(5, 4).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(5, 5).Range.Text = lblTthursday.Text;
                firstTable.Cell(5, 5).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(5, 5).Range.Font.Size = 18;
                firstTable.Cell(5, 5).Range.Font.Bold = 0;
                firstTable.Cell(5, 5).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;

                firstTable.Cell(5, 6).Range.Text = lblTfriday.Text;
                firstTable.Cell(5, 6).Range.Font.Name = ("Times New Roman");
                firstTable.Cell(5, 6).Range.Font.Size = 18;
                firstTable.Cell(5, 6).Range.Font.Bold = 0;
                firstTable.Cell(5, 6).Range.Font.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray30;


                //string documentBody2 = "Total Hours For The Week:  ";
                //document.Content.Text += documentBody2 + lblTotalHours.Text + Environment.NewLine;
                //document.Content.Text += "PTO Hours:  " + Environment.NewLine;
                //document.Content.Text += "Updates/Changes were made to this schedule on:  " + Environment.NewLine;
                //document.Content.Bold = 1;
                //document.Content.Font.Name = "Times New Roman";
                //document.Content.Font.Size = 14;

                document.Content.InsertAfter(Environment.NewLine + "Total Hours For The Week:  " + lblTotalHours.Text + Environment.NewLine + "PTO Hours:  " + Environment.NewLine + "Updates/Changes were made to this schedule on:  ");

                //Save the document

                //saveFileDialog1.InitialDirectory = @"C:\";
                //saveFileDialog1.Title = "Save File As...";
                //saveFileDialog1.DefaultExt = "doc";
                saveFileDialog1.Filter = "doc files (*.doc)|*.doc|All files (*.*)|*.*";
                //saveFileDialog1.ShowDialog();
                //object filename = @"c:\temp\temp1.docx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    object filename = saveFileDialog1.FileName; ;
                    document.SaveAs(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    MessageBox.Show("Document created successfully !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            CreateDocument();
        }

        public string ReturnCorrectValue(string value)
        {
            string time = "";


            switch (value)
            {
                case "00:00":
                    {
                        time = "00:00";
                        return time;
                    }
                case "10:00":
                    {
                        time = "10:00";
                        return time;
                    }
                case "10:15":
                    {
                        time = "10:15";
                        return time;
                    }
                case "10:30":
                    {
                        time = "10:30";
                        return time;
                    }
                case "10:45":
                    {
                        time = "10:45";
                        return time;
                    }
                case "11:00":
                    {
                        time = "11:00";
                        return time;
                    }
                case "11:15":
                    {
                        time = "11:15";
                        return time;
                    }
                case "11:30":
                    {
                        time = "11:30";
                        return time;
                    }
                case "11:45":
                    {
                        time = "11:45";
                        return time;
                    }
                case "12:00":
                    {
                        time = "12:00";
                        return time;
                    }
                case "12:15":
                    {
                        time = "12:15";
                        return time;
                    }
                case "12:30":
                    {
                        time = "12:30";
                        return time;
                    }
                case "12:45":
                    {
                        time = "12:45";
                        return time;
                    }
                case "13:00":
                    {
                        time = "1:00";
                        return time;
                    }
                case "13:15":
                    {
                        time = "1:15";
                        return time;
                    }
                case "13:30":
                    {
                        time = "1:30";
                        return time;
                    }
                case "13:45":
                    {
                        time = "1:45";
                        return time;
                    }
                case "14:00":
                    {
                        time = "2:00";
                        return time;
                    }
                case "14:15":
                    {
                        time = "2:15";
                        return time;
                    }
                case "14:30":
                    {
                        time = "2:30";
                        return time;
                    }
                case "14:45":
                    {
                        time = "2:45";
                        return time;
                    }
                case "15:00":
                    {
                        time = "3:00";
                        return time;
                    }
                case "15:15":
                    {
                        time = "3:15";
                        return time;
                    }
                case "15:30":
                    {
                        time = "3:30";
                        return time;
                    }
                case "15:45":
                    {
                        time = "3:45";
                        return time;
                    }
                case "16:00":
                    {
                        time = "4:00";
                        return time;
                    }
                case "16:15":
                    {
                        time = "4:15";
                        return time;
                    }
                case "16:30":
                    {
                        time = "4:30";
                        return time;
                    }
                case "16:45":
                    {
                        time = "4:45";
                        return time;
                    }
                case "17:00":
                    {
                        time = "5:00";
                        return time;
                    }


                default:
                    return time;


            }
        }
    }
}

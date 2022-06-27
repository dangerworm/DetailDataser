using MongoDB.Bson;
namespace DetailDataser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///Would like popluate my comboboxs with proper dates rather than manual fill all.
            ///They offer 31 days options in months that dont contain 31 days.
            ///Inputting dates that don't exist will be stopped by the DateTime parse on line 23.
            ///However, I want to stop the comboboxs even offering incorrect dates.
            DayBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YearBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 1920; i < 2022; i++)
            {
                YearBox.Items.Add(i.ToString());    
            }
        }
        public Details obBuild()
        {
            string dateInput = String.Concat(MonthBox.Text, " ", DayBox.Text, ", ", YearBox.Text);
            var parsedDate = DateTime.Parse(dateInput);
            Details record = new Details(NameBox.Text, parsedDate);
            return record;
        }
        public bool inp_check()
        {
            bool ans = true;
            if (NameBox.Text == "" | DayBox.Text == "" | MonthBox.Text == "" | YearBox.Text == "")
            {
                ans = false;
            }
            return ans;
        }
        public void disList(Details record)
        {
            List<BsonDocument> readList = record.ReadFrom();
            foreach (BsonDocument doc in readList)
            {
                ///Would like to display my date without the time on the end.
                DisplayText.Text = String.Concat(DisplayText.Text, Environment.NewLine, doc.GetValue("name"), Environment.NewLine, doc.GetValue("age"), Environment.NewLine); 
            }
        }
        private void AgeLabel_Click(object sender, EventArgs e)
        {
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "";
            try
            {
                bool check = inp_check();
                if (check is true)
                {
                    Details record = obBuild();
                    record.Submit();
                    DisplayText.Text = "Record submitted.";
                }
                else
                {
                    DisplayText.Text = "please make sure you fill all details correctly";
                }
            }
            catch 
            {
               DisplayText.Text = "Unexpected error";
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "";
            bool check = inp_check();
            if (check is true)
            {
                Details record = obBuild();
                disList(record);    
            }
            else
            {
                DateTime dt1 = new DateTime();
                Details record = new Details("Emp", dt1);
                disList(record);    
            }
        }
    }
}
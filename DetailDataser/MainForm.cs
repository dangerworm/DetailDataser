using System.Globalization;
using DetailDataser.Models;
using DetailDataser.Repositories;
using MongoDB.Bson;
namespace DetailDataser
{
    public partial class MainForm : Form
    {
        private readonly PersonRegistrationRepository _personRegistrationRepository;

        public MainForm()
        {
            InitializeComponent();

            _personRegistrationRepository = new PersonRegistrationRepository();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DisplayAllRecords();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var validationError = GetValidationErrorMessage();
            if (!string.IsNullOrWhiteSpace(validationError))
            {
                ShowError(validationError);
                return;
            }

            try
            {
                DisplayText.Clear();

                var record = BuildPersonRegistration();
                _personRegistrationRepository.Create(record);
                
                ShowSuccess("Record created successfully.");
            }
            catch (Exception exception)
            {
                ShowError($"Unexpected error: {exception.Message}");
            }
        }

        private PersonRegistration BuildPersonRegistration()
        {
            var parsedDate = DateTime.Parse(DateTimePicker.Text, CultureInfo.CurrentCulture);
            return new PersonRegistration(NameBox.Text, parsedDate);
        }

        private void DisplayAllRecords()
        {
            DisplayText.Clear();

            var records = _personRegistrationRepository.ReadAll();

            foreach (var record in records)
            {
                DisplayText.AppendText($"Name: {record.Name}{Environment.NewLine}");
                DisplayText.AppendText($"DOB: {record.DateOfBirth:dd/MM/yyyy}{Environment.NewLine}");
                DisplayText.AppendText(Environment.NewLine);
            }
        }

        private string GetValidationErrorMessage()
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                return "Please enter a name";
            }

            var canParseDate = DateTime.TryParse(
                DateTimePicker.Text,
                CultureInfo.CurrentCulture,
                DateTimeStyles.AdjustToUniversal,
                out var parsedDate);

            var dateOfBirthIsInThePast = canParseDate && parsedDate < DateTime.Today;

            if (!canParseDate || !dateOfBirthIsInThePast)
            {
                return "Please enter a valid date in the past";
            }

            return string.Empty;
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowSuccess(string message)
        {
            MessageBox.Show(message, @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
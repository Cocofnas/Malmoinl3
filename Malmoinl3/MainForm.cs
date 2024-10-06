using System;
using System.Windows.Forms;

namespace Malmoinl3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI(); // Initialize the ComboBox with activity levels
        }

        // Method to initialize the GUI components (e.g., ComboBox items)
        private void InitializeGUI()
        {
            // Populate the activity level ComboBox with enum values
            cmbActivityLevel.Items.AddRange(Enum.GetNames(typeof(ActivityLevel)));
            cmbActivityLevel.SelectedIndex = 0; // Default to "Low" activity level
        }

        // Event handler for the Calculate button click event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve height and weight from the input fields
                double height, weight;

                if (double.TryParse(txtHeight.Text, out height) && double.TryParse(txtWeight.Text, out weight))
                {
                    // Get the user's name from the txtName TextBox
                    string name = txtName.Text;

                    // Update the label to include the user's name
                    label10.Text = $"Recommended daily water consumption for {name}";

                    // Check if the user selected Imperial units and convert height/weight to Metric if necessary
                    if (rbtnImperial.Checked)
                    {
                        height *= 2.54; // Convert inches to cm
                        weight *= 0.453592; // Convert pounds to kg
                    }

                    // Determine the gender from the selected RadioButton
                    Gender gender = rbtnFemale.Checked ? Gender.Female : Gender.Male;

                    // Get the selected activity level from the ComboBox
                    ActivityLevel activityLevel = (ActivityLevel)cmbActivityLevel.SelectedIndex;

                    // Create a new Person object with the input data
                    Person person = new Person
                    {
                        Weight = weight,
                        Height = height,
                        Gender = gender,
                        ActivityLevel = activityLevel
                    };

                    // Perform water intake calculation using the WaterIntakeCalculator class
                    WaterIntakeCalculator calculator = new WaterIntakeCalculator(person);
                    double waterIntake = calculator.CalculateWaterIntake();
                    int glasses = calculator.CalculateGlasses(waterIntake);

                    // Display the results in the labels
                    lblWaterIntake.Text = $"Water Intake: {waterIntake:N2} ml";
                    lblGlasses.Text = $"Glasses: {glasses}";
                }
                else
                {
                    MessageBox.Show("Please enter valid numerical values for height and weight.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

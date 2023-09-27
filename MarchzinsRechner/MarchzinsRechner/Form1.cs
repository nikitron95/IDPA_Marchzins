namespace MarchzinsRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void getMarchInterest_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birthdate = Convert.ToDateTime(inputBirthday.Text);
                decimal day = birthdate.Day;

                decimal accountBalance = Convert.ToDecimal(inputAccountBalance.Text);
                decimal marchInterest = Convert.ToDecimal(inputInterest.Text);

                if (accountBalance < 0)
                {
                    outputMarchInterestTextBox.Text = "Der Kontostand darf nicht negativ sein.";
                    return;
                }

              
                if (marchInterest < 0)
                {
                    outputMarchInterestTextBox.Text = "Der Zins darf nicht negativ sein.";
                    return;
                }

                if (birthdate > DateTime.Now)
                {
                    outputMarchInterestTextBox.Text = "Das Geburtsdatum darf nicht in der Zukunft liegen.";
                }
                else
                {
                    decimal bonus = (accountBalance / 360 * day) * (marchInterest / 100);
                    bonus = Math.Round(bonus, 2); 
                    outputMarchInterestTextBox.Text = "Marchzins: " + bonus.ToString("0.00");

                    const decimal offsetTaxPercentage = 0.35m;
                    decimal offsetTax = bonus * offsetTaxPercentage;
                    offsetTax = Math.Round(offsetTax, 2); 
                    offsetTaxTextBox.Text = "Verrechnungsteuer: " + offsetTax.ToString("0.00"); 

                    decimal actualInterest = bonus - offsetTax;
                    actualInterest = Math.Round(actualInterest, 2); 
                    actualInterestTextBox.Text = "Erhaltende Marchzins: " + actualInterest.ToString("0.00");
                }
            }
            catch (FormatException)
            {
                outputMarchInterestTextBox.Text = "Ungültiges Datums- oder Zahlenformat.";
            }
            catch (OverflowException)
            {
                outputMarchInterestTextBox.Text = "Eingegebener Wert ist zu groß oder zu klein.";
            }
            catch (Exception ex)
            {
                outputMarchInterestTextBox.Text = "Ein Fehler ist aufgetreten: " + ex.Message;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void offsetTaxTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Kontostand_Click(object sender, EventArgs e)
        {

        }

        private void outputMarchInterest_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
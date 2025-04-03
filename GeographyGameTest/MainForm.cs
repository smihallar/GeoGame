using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GeographyGameTest
{
    public partial class MainForm : Form
    {
        CountryManager countryManager;
        private List<Country> usedCountries;
        private List<Country> allCountries;
        Country selectedCountry;
        string playerName;
        int numOfCorrectGuesses;
        int score;
        int numOfIncorrectGuesses;


        public MainForm()
        {
            countryManager = new CountryManager();
            countryManager.SetUp();
            usedCountries = new List<Country>();

            InitializeComponent();
            InitializeGUI();


        }

        private void InitializeGUI() // Start
        {
            btnGuess.Visible = false;
            btnNext.Visible = false;

            lblCountryCorrect.Visible = false;
            lblContinentCorrect.Visible = false;
            lblCapitalCorrect.Visible = false;

            btnStart.Visible = true;
            lblNamePrompt.Visible = true;
            lblScoreboard.Visible = false;

            //lblIncorrectGuesses.Visible = false;
            //lblCorrectGuesses.Visible = false;


            progressBarFlags.Visible = false;
            lblFinalScore.Visible = false;

            //lblNumOfCorrectGuesses.Visible = false;
            //lblNumOfIncorrectGuesses.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblNamePrompt.Visible = false;
            playerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                // Show error message if the player name is empty
                MessageBox.Show("Please enter your name to start the game.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                playerName = txtPlayerName.Text.Trim();
                btnStart.Visible = false;
                btnGuess.Visible = true;
                btnNext.Visible = true;
                btnNext.Enabled = false;
                lblScoreboard.Visible = true;
                lblFinalScore.Visible = true;

                //lblIncorrectGuesses.Visible = true;
                //lblCorrectGuesses.Visible = true;

                //lblNumOfCorrectGuesses.Visible = true;
                //lblNumOfIncorrectGuesses.Visible = true;

                PopulateBoxes();

                ShowRandomFlag();

                ShowProgressBar();

            }
        }

        private void ShowRandomFlag()
        {

            selectedCountry = GetNextCountry();
            if (selectedCountry != null)
            {
                pbxFlag.ImageLocation = selectedCountry.FlagPath;
                usedCountries.Add(selectedCountry);

                if (progressBarFlags.Value < progressBarFlags.Maximum)
                {
                    progressBarFlags.PerformStep();
                }
            }
            else
            {
                FinishGame();
            }

        }

        private Country GetNextCountry()
        {
            List<Country> availableCountries = allCountries.Except(usedCountries).ToList();
            if (availableCountries.Count == 0)
            {
                return null;
            }

            Random random = new Random();
            return availableCountries[random.Next(availableCountries.Count)];
        }

        private void PopulateBoxes()
        {
            allCountries = countryManager.GetallCountries();

            allCountries = allCountries.OrderBy(country => country.CountryName).ToList(); //LINQ
            cmbCountry.DataSource = allCountries;
            cmbCountry.DisplayMember = "CountryName";

            allCountries = allCountries.OrderBy(country => country.Capital).ToList(); //LINQ

            cmbCapital.DataSource = allCountries;
            cmbCapital.DisplayMember = "Capital";


            var continentOptions = allCountries
            .SelectMany(country => country.Continents.Count == 1
            ? country.Continents
            : new List<string> { string.Join(", ", country.Continents.OrderBy(continent => continent)) })
            .Distinct()
            .OrderBy(continent => continent)
            .ToList();

            cmbContinent.DataSource = continentOptions;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            btnGuess.Enabled = false;
            cmbCountry.Enabled = false;
            lblCountryCorrect.Visible = true;
            lblContinentCorrect.Visible = true;
            lblCapitalCorrect.Visible = true;

            HandleGuesses();

            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowRandomFlag();
            btnGuess.Enabled = true;
            cmbCountry.Enabled = true;

            lblCountryCorrect.Visible = false;
            lblContinentCorrect.Visible = false;
            lblCapitalCorrect.Visible = false;

            btnGuess.Enabled = true;
            btnNext.Enabled = false;
        }

        private void FinishGame()
        {

            ShowScoreBoard();
            var result = MessageBox.Show("Do you want to exit the program?",
                                "Quit program",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ShowScoreBoard()
        {

            lblFinalScore.Visible = true;
            lblFinalScore.Text = numOfCorrectGuesses.ToString();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            FinishGame();
        }

        private void HandleGuesses()
        {
            //COUNTRY
            Country selectedComboBoxCountry = cmbCountry.SelectedItem as Country;


            if (selectedComboBoxCountry != null && selectedComboBoxCountry.CountryName == selectedCountry.CountryName)
            {
                lblCountryCorrect.ForeColor = Color.Green;
                lblCountryCorrect.Text = "CORRECT - " + selectedCountry.CountryName;
                numOfCorrectGuesses++;

            }
            else
            {
                lblCountryCorrect.ForeColor = Color.Red;
                lblCountryCorrect.Text = "INCORRECT - " + selectedCountry.CountryName;
                numOfIncorrectGuesses++;
            }

            //CAPITAL

            Country selectedCmbCapital = cmbCapital.SelectedItem as Country;


            if (selectedCmbCapital != null && selectedCmbCapital.Capital == selectedCountry.Capital)
            {
                lblCapitalCorrect.ForeColor = Color.Green;
                lblCapitalCorrect.Text = "CORRECT - " + selectedCountry.Capital;
                numOfCorrectGuesses++;
            }
            else
            {
                lblCapitalCorrect.ForeColor = Color.Red;
                lblCapitalCorrect.Text = "INCORRECT - " + selectedCountry.Capital;
                numOfIncorrectGuesses++;
            }

            //CONTINENTS

            string selectedCmbContinent = cmbContinent.SelectedItem as string;


            if (selectedComboBoxCountry != null && selectedCmbContinent != null && selectedCountry.Continents.Contains(selectedCmbContinent))
            {
                lblContinentCorrect.ForeColor = Color.Green;
                lblContinentCorrect.Text = "CORRECT - " + selectedCmbContinent;
                numOfCorrectGuesses++;
            }
            else
            {
                lblContinentCorrect.ForeColor = Color.Red;
                lblContinentCorrect.Text = "INCORRECT - " + string.Join(", ", selectedCountry.Continents);
                numOfIncorrectGuesses++;
            }

            ShowScore();

        }

        private void ShowProgressBar()
        {
            progressBarFlags.Minimum = 0;
            progressBarFlags.Maximum = allCountries.Count;
            progressBarFlags.Value = 0;
            progressBarFlags.Step = 1;
            progressBarFlags.Visible = true;

        }

        private void ShowScore()
        {
            //lblNumOfCorrectGuesses.Text = numOfCorrectGuesses.ToString();
            //lblNumOfIncorrectGuesses.Text = numOfIncorrectGuesses.ToString();
            lblFinalScore.Text = numOfCorrectGuesses.ToString();
        }

     
    }

}

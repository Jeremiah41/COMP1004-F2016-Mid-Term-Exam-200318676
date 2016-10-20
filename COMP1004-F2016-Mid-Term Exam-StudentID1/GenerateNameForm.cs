using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// App name: DnD Character Generator
/// Author's name: Jeremiah Hughes
/// App	Creation date: 20/10/2016
/// App description: This form generates the random names for the characters.
/// </summary>
namespace COMP1004_F2016_Mid_Term_Exam_StudentID1
{
    public partial class GenerateNameForm : Form
    {
        private Random _random;

        public GenerateNameForm()
        {
            InitializeComponent();
            this._initalize();
        }

        private void _initalize()
        {
            this._random = new Random(); // Creates a new random
        }
        /// <summary>
        /// Calls the GenerateName method to generate names on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();
        }
        /// <summary>
        /// Generates an index from the lists firstname and lastname assigning them a value.
        /// </summary>
        private void GenerateName()
        {

            int FirstGeneratedIndex = _random.Next(0, FirstNameListBox.Items.Count);

            int SecondGeneratedIndex = _random.Next(0, LastNameListBox.Items.Count);
          //  Debug.WriteLine("F: " + f);
            FirstNameListBox.SelectedIndex = FirstGeneratedIndex;
            LastNameListBox.SelectedIndex = SecondGeneratedIndex;


            Program.character.FirstName = FirstNameListBox.SelectedItem.ToString();
            FirstNameTextBox.Text = Program.character.FirstName;

            Program.character.LastName = LastNameListBox.SelectedItem.ToString();
            LastNameTextBox.Text = Program.character.LastName;
        }
        /// <summary>
        /// Generates and shows the ability form whenever the next button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm AbilityForm = new AbilityGeneratorForm();
      
            AbilityForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Generates 2 names when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }
    }
}

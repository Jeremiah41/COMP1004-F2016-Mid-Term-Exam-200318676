using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateRandomName();
        }

        private void GenerateRandomName()
        {



            Program.character.FirstName = // I wanted to do the same here for FirstName
            FirstNameTextBox.Text = Program.character.FirstName;

            Program.character.LastName = // I wanted to search for the list index and send it as the string to Program.Character.LastName
            LastNameTextBox.Text = Program.character.FirstName;
        }

     //   private string RollName()
       // {
     //       int r = _random.Next(FirstNameListBox.count);
      //  }
    }
}

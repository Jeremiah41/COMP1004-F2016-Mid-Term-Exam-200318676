using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// App name: DnD Character Generator
/// Author's name: Jeremiah Hughes
/// App	Creation date: 20/10/2016
/// App description: This form generates and show the splash screen at start up.
/// </summary>
namespace COMP1004_F2016_Mid_Term_Exam_StudentID1
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;

            GenerateNameForm startForm = new GenerateNameForm();
            startForm.Show();
            this.Hide();
        }
    }
}

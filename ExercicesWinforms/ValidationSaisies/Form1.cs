using ClassLibraryToolsVerfications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generic methode for validate the content of the TextBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;

        }

        /// <summary>
        /// Test the text inside the nameInput TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            // if ClassVerifications.VerifName(this.nameInput.Text)
            Regex regexName = new Regex(@"^{a-Zz-A}*30$");
            if(!regexName.IsMatch(this.nameInput.Text))
            {
                // TO DO 
                this.errorProviderNom.SetError(input,"Le format du Nom n'est pas celui attendu: 30 caracteres de long au maximum et que des lettres!")
            }
        }

        /// <summary>
        /// Test the text inside the dateInput TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Regex regexName = new Regex(@"^{0-9}*2{/}{0-9}*2{/}{0$-9}*4$");
            if (!regexName.IsMatch(input.Text))
            {
                // TO DO
            }
        }

        /// <summary>
        /// test the text inside the amountInput TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amountInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Regex regexName = new Regex(@"^{0-9}*5");
            //check with parse
            if (!regexName.IsMatch(input.Text))
            {
                // TO DO
            }
        }

        /// <summary>
        /// Test the text inside the zipCode TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zipCodeInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Regex regexName = new Regex(@"^{0-9}*5$");
            if (!regexName.IsMatch(input.Text))
            {
                // TO DO
            }
        }

        /// <summary>
        /// Open a 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validate_Click(object sender, EventArgs e)
        {
            string message = "Nom : " +  nameInput.Text + "\n" + "Date : " + dateInput.Text + "\n" + "Montant : " + amountInput.Text + "\n" + "Code : " + zipCodeInput.Text;
            MessageBox.Show(message, "Validation saisie",MessageBoxButtons.OK);

        }
        /// <summary>
        /// Clear all the TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            nameInput.Clear();
            dateInput.Clear();
            amountInput.Clear();
            zipCodeInput.Clear();
        }
    }
}

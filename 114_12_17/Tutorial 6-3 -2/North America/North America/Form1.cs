using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName; // To hold the file name
            fileName = GetFileName(); // Get the file name
            GetCountries(fileName);
        }

        private string GetFileName()
        {
            string fileName; // To hold the file name
            // Create an OpenFileDialog object.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set the initial directory.
            openFileDialog.InitialDirectory = @"C:\Data";
            // Show the dialog box.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name.
                fileName = openFileDialog.FileName;
            }
            else
            {
                // If the user canceled, set fileName to an empty string.
                fileName = string.Empty;
            }
            return fileName;
        }

        private void GetCountries(string fileName)
        {
            // Clear the list box.
            countriesListBox.Items.Clear();
            // Check if a file name was provided.
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("No file selected.");
                return;
            }
            try
            {
                // Open the file.
                StreamReader reader = new StreamReader(fileName);
                // Read the file's contents and display them
                // in the list box.
                string country;
                while ((country = reader.ReadLine()) != null)
                {
                    countriesListBox.Items.Add(country);
                }
                // Close the file.
                reader.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}

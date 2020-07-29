using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.firstName = this.firstNameTextBox.Text;
            contact.lastName = this.lastNameTextBox.Text;
            contact.email = this.emailTextBox.Text;

            var fileResult = saveFileDialog.ShowDialog();
            if (fileResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Contact));
                TextWriter textWriter = new StreamWriter(fileName);
                xmlSerializer.Serialize(textWriter, contact);
                textWriter.Flush();
                textWriter.Close();

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.emailTextBox.Clear();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var fileResult = openFileDialog.ShowDialog();
            if(fileResult == DialogResult.OK)
            {
                using (var fileStream = openFileDialog.OpenFile())
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Contact));

                    Contact contact = (Contact)xmlSerializer.Deserialize(fileStream);

                    this.firstNameTextBox.Text = contact.firstName;
                    this.lastNameTextBox.Text = contact.lastName;
                    this.emailTextBox.Text = contact.email;
                }
            }
        }
    }
}

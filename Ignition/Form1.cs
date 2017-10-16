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

namespace Ignition
{
    public partial class Main : Form
    {
        int count = 0;
        bool load = true;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Program.APPLICATION_NAME;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string year = DateTime.Now.Year.ToString();
            string fileDirectory = Directory.GetCurrentDirectory() + "\\Files\\";

            string[] fileList = Directory.GetFiles(fileDirectory, "*.*");

            

            if (tbClientName.Text == "" || tbPurpose.Text == "")
            {
                MessageBox.Show("Please enter text into the Text boxes.");
                return;
            }
            string newDirectory = userPath + "\\Google Drive\\Client Folders\\"
                + tbClientName.Text + "\\" + year + " " + tbPurpose.Text + "\\";

            if (Directory.Exists(newDirectory))
            {
                MessageBox.Show("That Profile exists already.");
                return;
            }

            

            Directory.CreateDirectory(newDirectory);
            Directory.CreateDirectory(newDirectory + "Client Profile\\");
            Directory.CreateDirectory(newDirectory + "Emails\\");

            foreach (string file in fileList)
            {
                string fName = file.Substring(fileDirectory.Length);
                try
                {
                    // Will not overwrite if the destination file already exists.
                    File.Copy(Path.Combine(fileDirectory, fName), Path.Combine(newDirectory, fName));
                }
                catch (IOException copyError)
                {
                    MessageBox.Show(copyError.Message);
                    return;
                }
            }

            File.Create(newDirectory + "Emails\\Copied Emails.docx");

            tmrPB.Interval = new Random().Next(1, 6);
            tmrPB.Enabled = true;
        }

        private void tmrPB_Tick(object sender, EventArgs e)
        {
            if (load)
            {
                pbRandom.Increment(1);
                if (pbRandom.Value == pbRandom.Maximum)
                {
                    load = false;
                    count = 200;
                    lblDone.Visible = true;
                    tmrPB.Interval = 1;
                }
            }
            else
            {

                count--;
                if (count == 0)
                {
                    pbRandom.Value = 0;
                    pbRandom.Update();
                    lblDone.Visible = false;
                    load = true;
                    tmrPB.Enabled = false;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string fileDirectory = Directory.GetCurrentDirectory() + "\\Files\\";
            string[] fileList = Directory.GetFiles(fileDirectory, "*.*");
            foreach (string file in fileList)
            {
                string fName = file.Substring(fileDirectory.Length);
                lblClientName.Text = fName;
                
            }
            
            
        }
    }
}

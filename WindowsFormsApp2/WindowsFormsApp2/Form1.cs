using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class BuildGen : Form
    {
        public BuildGen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string var = richTextBox10.Text;
            string command = "set " + var + "=''";
            String EnviromentPath = System.Environment.GetEnvironmentVariable(var, 0);
            if (EnviromentPath == null)
            {
                richTextBox17.Text = "THIS ENVIRONMENT VAR DOES NOT EXIST YET";
                richTextBox17.BackColor = Color.Red;
            }
            else
            {
                richTextBox17.Text = "Success";
                richTextBox17.BackColor = Color.Green;
            }

            richTextBox12.AppendText("echo %TIME% Delete environment variable " + var + "\n");
            richTextBox12.AppendText(command + "\n");
            richTextBox12.AppendText("if errorlevel 1 echo Failed to remove variable" + var + " \n");
            richTextBox12.AppendText("\n");
            richTextBox12.AppendText("\n");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string source = richTextBox2.Text;
            string dest = richTextBox3.Text;
            string command = "move " + source + " " + dest;
            if (!File.Exists(source))
            {
                richTextBox17.Text = "THIS FILE DOES NOT EXIST YET";
                richTextBox17.BackColor = Color.Yellow;

            }
            else
            {
                richTextBox17.Text = "Success";
                richTextBox17.BackColor = Color.Green;
            }
            richTextBox12.AppendText("echo %TIME% Moving " + source + " to " + dest + "\n");
            richTextBox12.AppendText(command + "\n");
            richTextBox12.AppendText("if errorlevel 1 echo Failed to move " + source + " to " + dest + " \n");
            richTextBox12.AppendText("\n");
            richTextBox12.AppendText("\n");

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IP = richTextBox1.Text;
            if (!IsAddressValid(IP))
            {
                richTextBox17.Text = "BAD IP";
                richTextBox17.BackColor = Color.Red;
            }
            else
            {
                string drive = richTextBox16.Text;
                if (drive.Length != 1)
                {
                    richTextBox17.Text = "BAD DRIVE LETTER";
                    richTextBox17.BackColor = Color.Red;
                }
                else
                {
                    richTextBox17.Text = "Success";
                    richTextBox17.BackColor = Color.Green;
                    string share = richTextBox15.Text;
                    richTextBox12.AppendText("echo %TIME% creating share\n");
                    string command = "net use " + drive.ToUpper() + ": \\\\" + IP + "\\" + share;
                    richTextBox12.AppendText("if errorlevel 1 echo Failed to clear network connections \n");
                    richTextBox12.AppendText(command + "\n");
                    richTextBox12.AppendText("\n");
                    richTextBox12.AppendText("\n");

                }
            }
            
        }

        public bool IsAddressValid(string addrString)
        {
            IPAddress address;
            return IPAddress.TryParse(addrString, out address);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox12.AppendText("echo %TIME% Clearing network connections\n");
            richTextBox12.AppendText("net use /delete *\n");
            richTextBox12.AppendText("if errorlevel 1 echo Failed to clear network connections \n");
            richTextBox12.AppendText("echo .\n");
            richTextBox12.AppendText("echo .\n");
            richTextBox12.AppendText("echo .\n");
            richTextBox12.AppendText("echo .\n");
        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            // richTextBox2.Clear();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Clipboard.SetText(path);
            }
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string source = richTextBox4.Text;
            string dest = richTextBox5.Text;
            string command = "copy " + source + " " + dest;
            if (!File.Exists(source))
            {
                richTextBox17.Text = "THIS FILE DOES NOT EXIST YET";
                richTextBox17.BackColor = Color.Yellow;

            }
            else
            {
                richTextBox17.Text = "Success";
                richTextBox17.BackColor = Color.Green;
            }
            richTextBox12.AppendText("echo %TIME% Copy " + source + " to " + dest + "\n");
            richTextBox12.AppendText(command + "\n");
            richTextBox12.AppendText("if errorlevel 1 echo Failed to copy " + source + " to " + dest + " \n");
            richTextBox12.AppendText("\n");
            richTextBox12.AppendText("\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string file = richTextBox9.Text;
            string command = "del " + file;
            if (!File.Exists(file))
            {
                richTextBox17.Text = "THIS FILE DOES NOT EXIST YET";
                richTextBox17.BackColor = Color.Yellow;
            }
            else
            {
                richTextBox17.Text = "Success";
                richTextBox17.BackColor = Color.Green;
            }
            richTextBox12.AppendText("echo %TIME% Removing " + file + "\n");
            richTextBox12.AppendText(command + "\n");
            richTextBox12.AppendText("if errorlevel 1 echo Failed to delete " + file + " \n");
            richTextBox12.AppendText("\n");
            richTextBox12.AppendText("\n");
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = richTextBox6.Text;
            string value = richTextBox7.Text;
            string command = "set " + name + "=" + value + "\n";

            richTextBox12.AppendText("echo %TIME% Adding environment variable " + name + "=" + value + "\n");
            richTextBox12.AppendText(command + "\n");
            richTextBox12.AppendText("if errorlevel 1 echo Failed to create enironment variable " + name + " \n");
            richTextBox12.AppendText("\n");
            richTextBox12.AppendText("\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string script_loc = richTextBox11.Text;
            string[] tokens = script_loc.Split('\\');
            int len = tokens.Length;
            string prev_dir = "";
            for (int i = 0; i < len - 1; i ++)
            {
                prev_dir = prev_dir + tokens[i] + "\\";
            }
            if (!File.Exists(script_loc))
            {
                richTextBox17.Text = "THIS FILE DOES NOT EXIST YET";
                richTextBox17.BackColor = Color.Red;
            }
            else
            {
                richTextBox17.Text = "Success";
                richTextBox17.BackColor = Color.Green;
            }
            richTextBox12.AppendText("cd " + prev_dir + " \n");
            richTextBox12.AppendText("echo %TIME% running script " + tokens[len - 1] + " \n");
            // determin if python or batch 
            string ext = Path.GetExtension(script_loc);
            if (string.Equals(ext, "py"))
            {
                richTextBox12.AppendText("python " + script_loc + " \n");
            }
            else
            {
                richTextBox12.AppendText("call " + script_loc + " \n");
            }
            richTextBox12.AppendText("if errorlevel 1 echo script exited with an error code \n");
            richTextBox12.AppendText("\n");
            richTextBox12.AppendText("\n");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string txt = richTextBox8.Text;
            richTextBox12.AppendText("call :inputbox '" + txt + "' \n");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox12.AppendText("echo ###########\n");
            richTextBox12.AppendText("echo #     FINITO    #\n");
            richTextBox12.AppendText("echo ###########\n");
            richTextBox12.AppendText("echo HEHE ALL DONE NOW ^_^\n");
            richTextBox12.AppendText("echo Started : %StartTime%\n");
            richTextBox12.AppendText("echo Finished: %TIME%\n");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "bat files (*.bat)|*.bat|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            richTextBox12.Text = File.ReadAllText(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox12.Text = "@echo off\necho ###########\necho # STARTING #\necho ###########\nset StartTime=%TIME%\n";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

// Jeffrey Wong
// ICS3U
// January 10th 2024
// D12

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace D12___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        Button startButton;
        StreamReader fReader;
        StreamWriter fWriter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 100;
            this.Width = 200;

            startButton = new Button();
            startButton.Text = "Start";
            startButton.Click += StartButton_Click;
            startButton.Top = 25;
            startButton.Left = 50;

            this.Controls.Add(startButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string tempInput;

            if (File.Exists(Application.StartupPath + @"\input.txt"))
            {
                fReader = new StreamReader(Application.StartupPath + @"\input.txt");
                fWriter = new StreamWriter(Application.StartupPath + @"\output.txt", false);
                while (fReader.Peek() >= 0)
                {
                    tempInput = fReader.ReadLine();
                    fWriter.WriteLine(Convert.ToInt32(tempInput) * 42);
                }
                fReader.Close();
                fWriter.Close();

                MessageBox.Show("Done!");
            }
        }
    }
}

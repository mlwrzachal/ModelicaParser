using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

// Open File
        OpenFileDialog open = new OpenFileDialog();

        static string openpath;

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                openpath = open.FileName;
                textBox2.Text = "File OK";
            }
        }

// Run Translator  
        string OutputToFile;
        private void RunProgram_Click(object sender, EventArgs e)
        {
            LoopTroughFile LTF = new LoopTroughFile();
            OutputToFile = LTF.ExecuteTranslate(openpath);
        }

// Save File
        SaveFileDialog save = new SaveFileDialog();

        string savepath;
        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (save.ShowDialog() == DialogResult.OK)
            {
                savepath = save.FileName;
                textBox1.Text = savepath;

                FileStream OutputFile = new FileStream(savepath, FileMode.Create);
                StreamWriter writeout = new StreamWriter(OutputFile);
                writeout.Write(OutputToFile);
                writeout.Dispose();
            }

        }

    }
}
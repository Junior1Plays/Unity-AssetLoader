using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unity_AssetLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ual_path = "C:\\Users\\" + Environment.UserName + "\\Documents\\Unity AssetLoader\\";
        string ualassets_path = "C:\\Users\\" + Environment.UserName + "\\Documents\\Unity AssetLoader\\assets\\";
        string path;

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_rmga.Enabled = false;
            if (Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Documents\\Unity AssetLoader\\") == false)
            {
                Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Documents\\Unity AssetLoader\\");
                Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Documents\\Unity AssetLoader\\assets\\");
            }
        }

        private void btn_ga_Click(object sender, EventArgs e)
        {
            selectasset.ShowDialog();
        }

        private void btn_mga_Click(object sender, EventArgs e)
        {
            selectmodasset.ShowDialog();
        }

        private void selectasset_FileOk(object sender, CancelEventArgs e)
        {
            ga_selectedga.Text = selectasset.SafeFileName;
        }

        private void selectmodasset_FileOk(object sender, CancelEventArgs e)
        {
            mga_selectedmga.Text = selectmodasset.SafeFileName;
        }

        public void createPath()
        {
            path = ualassets_path + "asset-" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Millisecond;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (selectasset.FileName == string.Empty)
            {
                MessageBox.Show("Please select game asset.", "Unity AssetLoader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (selectmodasset.FileName == string.Empty)
                {
                    MessageBox.Show("Please select modified game asset.", "Unity AssetLoader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (selectasset.SafeFileName == selectmodasset.SafeFileName)
                    {
                        if (selectasset.FileName == selectmodasset.FileName)
                        {
                            MessageBox.Show("You cannot choose the same file!", "Unity AssetLoader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            createPath();
                            Directory.CreateDirectory(path);
                            File.Copy(selectasset.FileName, path + "\\" + selectasset.SafeFileName);
                            File.Delete(selectasset.FileName);
                            File.Copy(selectmodasset.FileName, selectasset.FileName);
                            btn_ga.Enabled = false;
                            btn_mga.Enabled = false;
                            btn_load.Enabled = false;
                            btn_rmga.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btn_rmga_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are you sure?", "Unity AssetLoader", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(selectasset.FileName);
                File.Copy(path + '\\' + selectasset.SafeFileName, selectasset.FileName);
                ga_selectedga.Text = "No files were selected.";
                mga_selectedmga.Text = "No files were selected.";
                selectasset.Reset();
                selectmodasset.Reset();
                btn_ga.Enabled = true;
                btn_mga.Enabled = true;
                btn_load.Enabled = true;
                btn_rmga.Enabled = false;
            }
        }
    }
}

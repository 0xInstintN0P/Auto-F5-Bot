using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite;
using AutoItX3Lib;

namespace S4LeagueAutoF5
{
    public partial class Form1 : MetroForm
    {
        AutoItX3 a = new AutoItX3();
        AutoIt at = new AutoIt();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tF5.Enabled = false;
            tAutoClick.Enabled = false;
            tEscape.Enabled = false;
            Application.Exit();          
        }

        private void metroChecker1_CheckedChanged(object sender, bool isChecked)
        {
            int ProcID = a.ProcessExists("xeroclient.exe");

            if(ProcID > 0)
            {
                if(this.metroChecker1.Checked == true)
                {
                    tF5.Start();
                    tAutoClick.Start();
                    tEscape.Start();
                }
                else
                {
                    tF5.Stop();
                    tAutoClick.Stop();
                    tEscape.Stop();
                }
            }
            else
            {
                MessageBox.Show("Game Close!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroChecker1.Enabled = false;
            }
        }

        private void tF5_Tick(object sender, EventArgs e)
        {
            at.F5();
        }

        private void tAutoClick_Tick(object sender, EventArgs e)
        {
            at.AutoClick();
        }

        private void tEscape_Tick(object sender, EventArgs e)
        {
            at.Escape();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach (string markak in Program.autok.Select(a => a.Marka).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = markak;
                cb.Checked = true;
                cb.Location = new Point(10, panel1.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(marka_valasztott);
                panel1.Controls.Add(cb);
            }
            updateAutoListBox();  //
        }

        private void marka_valasztott(object sender, EventArgs e)
        {
                updateAutoListBox();
        }

        private void updateAutoListBox()  
        {
            listBox1.Items.Clear();
            List<string> kivalasztottak = new List<string>();
            foreach (CheckBox cb in panel1.Controls)  
            {
                if (cb.Checked)
                {
                    kivalasztottak.Add(cb.Text);
                }
            }
            foreach (Auto auto in Program.autok)  
            {
                if (kivalasztottak.Contains(auto.Marka)) 
                {
                    listBox1.Items.Add(auto);
                }
            }
        }
       
        
        /*private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            updateAutoListBox();
        }*/

        private void felvitelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuto formAuto = new FormAuto("add");
            formAuto.ShowDialog();
            updateAutoListBox();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormAuto formAuto = new FormAuto("edit");  
            formAuto.ShowDialog();
            updateAutoListBox();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormAuto formAuto = new FormAuto("delete");
            formAuto.ShowDialog();
            updateAutoListBox();
        }

        //Nem kell
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nem kell!
        }
    }
}

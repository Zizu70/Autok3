using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Autok3
{
    public partial class FormAuto : Form
    {
        string muvelet;
        public FormAuto(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "add":
                    this.Text = "Felvitel";
                    button1.Text = "Felvitel";
                    button1.BackColor = Color.LightGreen;
                    button1.Click += new EventHandler(insertAuto); 
                    break;
                case "edit":
                    this.Text = "Módosítás";
                    button1.Text = "Módosítás";
                    button1.BackColor = Color.LightBlue;
                    button1.Click += new EventHandler(updateAuto);
                    adatokFeltoltese();
                    break;
                case "delete":
                    this.Text = "Törlés";
                    button1.Text = "Törlés";
                    button1.BackColor = Color.LightSalmon;
                    button1.Click += new EventHandler(deleteAuto);
                    adatokFeltoltese();
                    break;
            }
        }

        private void adatokFeltoltese()  
        {
            Auto auto = (Auto)Program.formMain.listBox1.SelectedItem;
            
                textBox1.Text = auto.Marka.ToString();
                textBox2.Text = auto.Modell.ToString();
                textBox3.Text = auto.Rendszam.ToString();
                dateTimePicker1.Value = auto.ForgalmiErvenyesseg;
                textBox4.Text = auto.Gyartasiev.ToString();
                textBox5.Text = auto.Kmallas.ToString();
                textBox6.Text = auto.Hengerurtartalom.ToString();
                textBox7.Text = auto.Tomeg.ToString();
                textBox8.Text = auto.Teljesitmeny.ToString();
                textBox9.Text = auto.Vetelar.ToString();
        }

        private void deleteAuto(object sender, EventArgs e)
        {
            Auto auto = (Auto)Program.formMain.listBox1.SelectedItem;
            Program.adatbazis.deleteAuto(auto);
            this.Close();
        }

        private void updateAuto(object sender, EventArgs e)
        {
            Auto auto = (Auto)Program.formMain.listBox1.SelectedItem;
                        
            auto.Marka = textBox1.Text;
            auto.Modell = textBox2.Text;
            auto.Rendszam = textBox3.Text;
            auto.Gyartasiev = int.Parse(textBox4.Text);
            auto.ForgalmiErvenyesseg = (DateTime)dateTimePicker1.Value;
            auto.Kmallas = int.Parse(textBox5.Text);
            auto.Hengerurtartalom = int.Parse(textBox6.Text);
            auto.Tomeg = int.Parse(textBox7.Text);
            auto.Teljesitmeny = int.Parse(textBox8.Text);
            auto.Vetelar = int.Parse(textBox9.Text);
                        
            Program.adatbazis.updateAuto(auto);  
            this.Close();
        }

        private void insertAuto(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            
            auto.Marka = textBox1.Text;
            auto.Modell = textBox2.Text;
            auto.Rendszam = textBox3.Text;
            auto.Gyartasiev = int.Parse(textBox4.Text);
            auto.Kmallas = int.Parse(textBox5.Text);
            auto.Hengerurtartalom = int.Parse(textBox6.Text);
            auto.Tomeg = int.Parse(textBox7.Text);
            auto.Teljesitmeny = int.Parse(textBox8.Text);
            auto.Vetelar = int.Parse(textBox9.Text);

            auto.ForgalmiErvenyesseg = dateTimePicker1.Value;

            Program.adatbazis.insertAuto(auto);
            this.Close();
        }




       // NEM KELLL
        private void label4_Click(object sender, EventArgs e)
        {
            // Nem kell!!!
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Nem kell!!!
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //Nem kell
        }

        
    }
}

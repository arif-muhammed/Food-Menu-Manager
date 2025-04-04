using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace odev
{
    public partial class Form1 : Form
    {
        private Menu m = new Menu();
        private double toplamTutar = 0; 

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Seçiniz", "Içecek", "Yiyecek", "Meyve", "Salata", "Tatli" });
            comboBox1.SelectedIndex = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0 && comboBox1.SelectedItem.ToString() == "Yiyecek")
            {
                label5.Visible = false;
                textBox5.Visible = false;
            }
            else
            {
                label5.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFieldColors();

            if (comboBox1.SelectedIndex == 0) 
            {
                comboBox1.BackColor = Color.LightCoral;
                return;
            }

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Any(char.IsDigit))
            {
                textBox1.BackColor = Color.LightCoral;
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Any(char.IsDigit))
            {
                textBox2.BackColor = Color.LightCoral;
                hasError = true;
            }

            if (!double.TryParse(textBox3.Text, out double fiyat)) { textBox3.BackColor = Color.LightCoral; hasError = true; }
            if (!double.TryParse(textBox4.Text, out double kdv)) { textBox4.BackColor = Color.LightCoral; hasError = true; }

            double kalori = 0;

            if (comboBox1.SelectedItem.ToString() != "Yiyecek")
            {
                if (!double.TryParse(textBox5.Text, out kalori)) { textBox5.BackColor = Color.LightCoral; hasError = true; }
            }

            if (hasError) return;

            Yiyecek s = null;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Yiyecek":
                    s = new Yiyecek(textBox1.Text, textBox2.Text, fiyat, kdv);
                    break;
                case "Meyve":
                    s = new Meyve(textBox1.Text, textBox2.Text, fiyat, kdv, kalori);
                    break;
                case "Salata":
                    s = new Salata(textBox1.Text, textBox2.Text, fiyat, kdv, kalori);
                    break;
                case "Tatli":
                    s = new Tatli(textBox1.Text, textBox2.Text, fiyat, kdv, kalori);
                    break;
                case "Içecek":
                    s = new Içecek(textBox1.Text, textBox2.Text, fiyat, kdv, kalori);
                    break;
            }

            if (s != null)
            {
                m.Ekle(s);
                listBox1.Items.Add($"{s.Yazdir()}  {comboBox1.SelectedItem.ToString()}");

                toplamTutar += fiyat;
                UpdateTutarListBox();

                ClearFields();
            }
        }

        private void UpdateTutarListBox()
        {
            listBox2.Items.Clear();
            listBox2.Items.Add($"Tutar : {toplamTutar:F2} TL");
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = 0;
            ResetFieldColors();
        }

        private void ResetFieldColors()
        {
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            textBox3.BackColor = SystemColors.Window;
            textBox4.BackColor = SystemColors.Window;
            textBox5.BackColor = SystemColors.Window;
            comboBox1.BackColor = SystemColors.Window;
        }
    }
}

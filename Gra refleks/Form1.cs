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

namespace Gra_refleks
{
    public partial class Form1 : Form
    {
        List<Ksywa> lista = new List<Ksywa>();
        Ksywa ksywa = null;
        Color kolor;
        int cyfra = 0;
        int y;
        int suma;
        DateTime start;
        DateTime stop;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                cyfra = 0;
                suma = 0;
                label4.Text = suma.ToString();
                start = DateTime.Now;
                progressBar1.Value = 0;
                button1.Enabled = false;
                Random x = new Random();
                y = x.Next(1, 17);
                cyfra = y;
                if (y == 1)
                {
                    button2.BackColor = Color.Red;
                }
                else if (y == 2)
                {
                    button3.BackColor = Color.Red;
                }
                else if (y == 3)
                {
                    button4.BackColor = Color.Red;
                }
                else if (y == 4)
                {
                    button5.BackColor = Color.Red;
                }
                else if (y == 5)
                {
                    button6.BackColor = Color.Red;
                }
                else if (y == 6)
                {
                    button7.BackColor = Color.Red;
                }
                else if (y == 7)
                {
                    button8.BackColor = Color.Red;
                }
                else if (y == 8)
                {
                    button9.BackColor = Color.Red;
                }
                else if (y == 9)
                {
                    button10.BackColor = Color.Red;
                }
                else if (y == 10)
                {
                    button11.BackColor = Color.Red;
                }
                else if (y == 11)
                {
                    button12.BackColor = Color.Red;
                }
                else if (y == 12)
                {
                    button13.BackColor = Color.Red;
                }
                else if (y == 13)
                {
                    button14.BackColor = Color.Red;
                }
                else if (y == 14)
                {
                    button15.BackColor = Color.Red;
                }
                else if (y == 15)
                {
                    button16.BackColor = Color.Red;
                }
                else if (y == 16)
                {
                    button17.BackColor = Color.Red;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bclick(button2);
        }
        public void Wyświetl()
        {
            listBox1.Items.Clear();
            Sortuj(lista);
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].miejsce = i + 1;
            }
            foreach (Ksywa k in lista)
            {
                listBox1.Items.Add(k.miejsce + ". " + k.ksywa + "  " + k.czas.TotalSeconds.ToString("0.00"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bclick(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bclick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bclick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bclick(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bclick(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bclick(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bclick(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bclick(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bclick(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bclick(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bclick(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bclick(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bclick(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bclick(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Bclick(button17);
        }
        public void Bclick(Button currentbutton)
        {
            if (currentbutton.BackColor == Color.Red)
            {
                if (suma < 20)
                {
                    suma++;
                    label4.Text = suma.ToString();
                    do
                    {
                        Random x = new Random();
                        y = x.Next(1, 17);
                    } while (y == cyfra);
                    cyfra = y;
                    if (y == 1)
                    {
                        button2.BackColor = Color.Red;
                    }
                    else if (y == 2)
                    {
                        button3.BackColor = Color.Red;
                    }
                    else if (y == 3)
                    {
                        button4.BackColor = Color.Red;
                    }
                    else if (y == 4)
                    {
                        button5.BackColor = Color.Red;
                    }
                    else if (y == 5)
                    {
                        button6.BackColor = Color.Red;
                    }
                    else if (y == 6)
                    {
                        button7.BackColor = Color.Red;
                    }
                    else if (y == 7)
                    {
                        button8.BackColor = Color.Red;
                    }
                    else if (y == 8)
                    {
                        button9.BackColor = Color.Red;
                    }
                    else if (y == 9)
                    {
                        button10.BackColor = Color.Red;
                    }
                    else if (y == 10)
                    {
                        button11.BackColor = Color.Red;
                    }
                    else if (y == 11)
                    {
                        button12.BackColor = Color.Red;
                    }
                    else if (y == 12)
                    {
                        button13.BackColor = Color.Red;
                    }
                    else if (y == 13)
                    {
                        button14.BackColor = Color.Red;
                    }
                    else if (y == 14)
                    {
                        button15.BackColor = Color.Red;
                    }
                    else if (y == 15)
                    {
                        button16.BackColor = Color.Red;
                    }
                    else if (y == 16)
                    {
                        button17.BackColor = Color.Red;
                    }
                    currentbutton.BackColor = kolor;
                    progressBar1.Value = progressBar1.Value + 1;
                }
                else
                {
                    ksywa = new Ksywa();
                    stop = DateTime.Now;
                    ksywa.ksywa = textBox1.Text;
                    ksywa.miejsce = 1;
                    ksywa.czas = stop - start;
                    lista.Add(ksywa);
                    Wyświetl();
                    button1.Enabled = true;
                    currentbutton.BackColor = kolor;
                    ksywa = null;
                }
            }
        }

        private void button_eksport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                for (int i = 0; i < lista.Count; i++)
                {
                    writer.WriteLine(lista[i].miejsce + "," + lista[i].ksywa + "," + lista[i].czas);
                }
                writer.Close();
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                lista.Clear();

                using (StreamReader r = new StreamReader(open.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        ksywa = new Ksywa();
                        string[] parts = line.Split(',');
                        ksywa.miejsce = Int32.Parse(parts[0]);
                        ksywa.ksywa = parts[1];
                        ksywa.czas = TimeSpan.Parse(parts[2]);
                        lista.Add(ksywa);
                        
                    }
                    foreach (Ksywa ksywa in lista)
                    {
                        listBox1.Items.Add(ksywa.miejsce + ". " + ksywa.ksywa + "  " + ksywa.czas.TotalSeconds.ToString("0.00"));
                    }
                }
            }
        }
        public void Sortuj(List<Ksywa> lista)
        {
            lista.Sort(delegate (Ksywa x, Ksywa y)
            {
                return x.czas.CompareTo(y.czas);
            });
        }
    }
}

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

namespace RTW_UV
{
    public partial class Form1 : Form
    {
        List<Unit> units;
        string[] txt;

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(Properties.Settings.Default.Path + @"\Data\export_descr_unit.txt"))
            {
                MessageBox.Show("Укажите путь до директории \"Rome - Total War\"");

                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && File.Exists(folderBrowserDialog1.SelectedPath + @"\Data\export_descr_unit.txt"))
                {
                    Properties.Settings.Default.Path = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Необходимые файлы не найдены — программа завершает работу.");
                    Environment.Exit(1);
                }
            }

            try
            {
                units = new List<Unit>();
                txt = File.ReadAllLines(Properties.Settings.Default.Path + @"\Data\export_descr_unit.txt");

                int t = 0, c = 0, o;
                for (int i = 0; i < txt.Length; ++i)
                {
                    o = 0;
                    if (txt[i].StartsWith("type "))
                        t = i;
                    if (txt[i].StartsWith("category "))
                        c = i;
                    if (txt[i].StartsWith("ownership "))
                        o = i;

                    if (o > 0)
                    {
                        units.Add(new Unit(txt[t], txt[c], txt[o]));
                    }
                }

                for (int i = 0; i < units.Count; ++i)
                    foreach (string s in units[i].ownership.Split(','))
                        if (!comboBox1.Items.Contains(s.Trim()))
                            comboBox1.Items.Add(s.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox2.Items.Clear();

            for (int i = 0; i < units.Count; ++i)
                if (units[i].ownership.Contains(comboBox1.SelectedItem.ToString()))
                {
                    listBox1.Items.Add(units[i].type);

                    if (!comboBox2.Items.Contains(units[i].category))
                        comboBox2.Items.Add(units[i].category);
                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < units.Count; ++i)
                if (units[i].ownership.Contains(comboBox1.SelectedItem.ToString()) && units[i].category.Contains(comboBox2.SelectedItem.ToString()))
                {
                    listBox1.Items.Add(units[i].type);
                }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int i = 0;
            while (i < txt.Length)
            {
                if (txt[i].Contains(listBox1.SelectedItem.ToString()))
                    while (txt[i].Trim() != "")
                    {
                        textBox1.Text += txt[i] + "\r\n";
                        ++i;
                    }
                ++i;
            }
        }
    }
}

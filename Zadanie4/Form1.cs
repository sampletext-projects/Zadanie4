using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetArea_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            double d;
            if (double.TryParse(textBoxD.Text.Replace(".", ","), out d))
            {
                double area = module.Area6(d);
                MessageBox.Show("Площадь шестиугольника: " + area.ToString());
            }
            else
            {
                MessageBox.Show("Допущена ошибка в вводе!");
            }
        }

        private void buttonConvertBase_Click(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(textBoxVal.Text, out val))
            {
                if (val.ToString().Contains("8") || val.ToString().Contains("9"))
                {
                    MessageBox.Show("Ошибка! Заданное число не в 8 с.с.");
                }
                else
                {
                    string res = Module.ConvertBase82(val);
                    MessageBox.Show("Результат перевода:\n" + res);
                }
            }
            else
            {
                MessageBox.Show("Допущена ошибка в вводе!");
            }
        }
    }
}
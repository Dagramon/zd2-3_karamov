using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_3_karamov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Shop> shops = new List<Shop>();

        private void UpdateListBox() //Обновление значений в ListBox по выбранному магазину
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex != -1)
            {
                label4.Text = shops[comboBox1.SelectedIndex].Profit.ToString();
                foreach (Product product in shops[comboBox1.SelectedIndex].Products.Keys)
                {
                    shops[comboBox1.SelectedIndex].Products.TryGetValue(product, out int amount);
                    listBox1.Items.Add($"{product.GetInfo()} Кол-во {amount}");
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) //Переключение между заданиями
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //Переключение между заданиями
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) //Создание нового магазина и добавление его в список
        {
            if (textBox1.Text != string.Empty && !comboBox1.Items.Contains(textBox1.Text))
            {
                Shop newShop = new Shop();
                newShop.Name = textBox1.Text;
                shops.Add(newShop);
                comboBox1.Items.Add(newShop.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Загрузка данных в listbox для выбранного магазина
        {
            UpdateListBox();
        }

        private void button3_Click(object sender, EventArgs e) //Добавление нового продукта
        {
            if (comboBox1.SelectedIndex != -1 && textBox2.Text != string.Empty && !listBox1.Items.Contains(textBox2.Text))
            {
                shops[comboBox1.SelectedIndex].CreateProduct(textBox2.Text, numericUpDown1.Value, Convert.ToInt16(numericUpDown2.Value));
            }
            UpdateListBox();
        }

        private void button4_Click(object sender, EventArgs e) //Продажа выбраного продукта из listbox
        {
            if (listBox1.SelectedIndex != -1)
            {
                MessageBox.Show(shops[comboBox1.SelectedIndex].Sell(listBox1.SelectedItem.ToString().Substring(0, listBox1.SelectedItem.ToString().IndexOf("|"))));
            }
            UpdateListBox();
        }

        private void button5_Click(object sender, EventArgs e) //Вывод всех продуктов при помощи метода объекта
        {
            if (comboBox1.SelectedIndex != -1)
            {
                MessageBox.Show(shops[comboBox1.SelectedIndex].WriteAllProducts());
            }
        }

        private void button6_Click(object sender, EventArgs e) //Вывод прибыли магазина при помощи метода объекта
        {
            if (comboBox1.SelectedIndex != -1)
            {
                MessageBox.Show(shops[comboBox1.SelectedIndex].ShopProfit());
            }
        }
    }
}

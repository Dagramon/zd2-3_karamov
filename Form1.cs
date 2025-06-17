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
        Playlist playlist = new Playlist();

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
        //задание 3

        public void UpdatePlaylist()
        {
            listBox2.Items.Clear();
            numericIndex.Maximum = playlist.GetList().Count - 1;
            numericIndex.Minimum = 0;
            foreach (Song song in playlist.GetList())
            {
                listBox2.Items.Add(song.Title);
            }
            if (listBox2.Items.Count > 0)
            {
                listBox2.SelectedIndex = playlist.CurrentIndex;
            }
        }

        public void LoadSong()
        {
            Song currentSong = playlist.CurrentSong();
            label7.Text = currentSong.Title;
            label13.Text = currentSong.Author;
            label9.Text = currentSong.Filename;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != string.Empty)
            {
                string name = comboBox2.Text.Substring(0, comboBox2.Text.IndexOf('|'));
                string filename = comboBox2.Text.Substring(comboBox2.Text.IndexOf('|') + 1, comboBox2.Text.LastIndexOf('|') - comboBox2.Text.IndexOf('|') - 1);
                string author = comboBox2.Text.Substring(comboBox2.Text.LastIndexOf('|') + 1, comboBox2.Text.Length - comboBox2.Text.LastIndexOf('|') - 1);
                if (!listBox2.Items.Contains(name))
                {
                    Song song = new Song();
                    song.Title = name;
                    song.Filename = filename;
                    song.Author = author;
                    playlist.AddSong(song);
                    LoadSong();
                    UpdatePlaylist();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty)
            {
                if (!listBox2.Items.Contains(textBox3.Text))
                {
                    playlist.AddSong(textBox3.Text, textBox4.Text, textBox5.Text);
                    LoadSong();
                    UpdatePlaylist();
                }
                else
                {
                    MessageBox.Show("Песня уже существует");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            playlist.ClearPlaylist();
            UpdatePlaylist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playlist.MoveToPrevious();
            LoadSong();
            UpdatePlaylist();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            playlist.MoveToNext();
            LoadSong();
            UpdatePlaylist();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            playlist.CurrentIndex = (Convert.ToInt16(numericIndex.Value));
            LoadSong();
            UpdatePlaylist();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            playlist.RemoveSong(Convert.ToInt16(numericIndex.Value));
            UpdatePlaylist();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            playlist.RemoveSong(playlist.CurrentSong());
            UpdatePlaylist();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            playlist.CurrentIndex = 0;
            LoadSong();
            UpdatePlaylist();
        }
    }
}

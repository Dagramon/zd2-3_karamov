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

namespace zd2_3_karamov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFromFile();
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

        public void SaveToFile()
        {
            using (StreamWriter sw = File.CreateText("Playlist.txt"))
            {
                foreach (Song song in playlist.GetList())
                {
                    sw.WriteLine($"{song.Title}|{song.Filename}|{song.Author}");
                }
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists("Playlist.txt"))
            {
                string[] arr = File.ReadAllLines("Playlist.txt");
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] info = arr[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Song song = new Song();
                    song.Title = info[0];
                    song.Filename = info[1];
                    song.Author = info[2];
                    playlist.AddSong(song);
                }
                UpdatePlaylist();
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }

        public void UpdatePlaylist() //Добавление изменений в listBox
        {
            listBoxSongs.Items.Clear();
            numericIndex.Maximum = playlist.GetList().Count - 1;
            numericIndex.Minimum = 0;
            foreach (Song song in playlist.GetList())
            {
                listBoxSongs.Items.Add(song.Title);
            }
            if (listBoxSongs.Items.Count > 0)
            {
                listBoxSongs.SelectedIndex = playlist.CurrentIndex;
            }
            SaveToFile();
        }

        public void LoadSong() //Загрузка песни для отображения
        {
            Song currentSong = playlist.CurrentSong();
            SongNameLabel.Text = currentSong.Title;
            AuthorLabel.Text = currentSong.Author;
            FileLabel.Text = currentSong.Filename;
        }

        private void button9_Click(object sender, EventArgs e) //Добавление существующей песни
        {
            if (comboBoxSongs.Text != string.Empty)
            {
                string name = comboBoxSongs.Text.Substring(0, comboBoxSongs.Text.IndexOf('|'));
                string filename = comboBoxSongs.Text.Substring(comboBoxSongs.Text.IndexOf('|') + 1, comboBoxSongs.Text.LastIndexOf('|') - comboBoxSongs.Text.IndexOf('|') - 1);
                string author = comboBoxSongs.Text.Substring(comboBoxSongs.Text.LastIndexOf('|') + 1, comboBoxSongs.Text.Length - comboBoxSongs.Text.LastIndexOf('|') - 1);
                if (!listBoxSongs.Items.Contains(name))
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

        private void button8_Click(object sender, EventArgs e) //Добавление новой песни
        {
            if (textBoxName.Text != string.Empty && textBoxFilename.Text != string.Empty)
            {
                if (textBoxAuthor.Text != string.Empty)
                {
                    if (!listBoxSongs.Items.Contains(textBoxName.Text))
                    {
                        playlist.AddSong(textBoxName.Text, textBoxFilename.Text, textBoxAuthor.Text);
                        LoadSong();
                        UpdatePlaylist();
                    }
                    else
                    {
                        MessageBox.Show("Песня уже существует");
                    }
                }
                else
                {
                    if (!listBoxSongs.Items.Contains(textBoxName.Text))
                    {
                        playlist.AddSong(textBoxName.Text, textBoxFilename.Text);
                        LoadSong();
                        UpdatePlaylist();
                    }
                    else
                    {
                        MessageBox.Show("Песня уже существует");
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e) //Очистка плейлиста
        {
            playlist.ClearPlaylist();
            UpdatePlaylist();
        }

        private void button1_Click(object sender, EventArgs e) //Перемещение назад по плейлисту
        {
            playlist.MoveToPrevious();
            LoadSong();
            UpdatePlaylist();
        }

        private void button7_Click(object sender, EventArgs e) //Перемещение вперёд по плейлисту
        {
            playlist.MoveToNext();
            LoadSong();
            UpdatePlaylist();
        }

        private void button10_Click(object sender, EventArgs e) //Перемещение по индексу
        {
            playlist.CurrentIndex = (Convert.ToInt16(numericIndex.Value));
            LoadSong();
            UpdatePlaylist();
        }

        private void button11_Click(object sender, EventArgs e) //Удаление по индексу
        {
            playlist.RemoveSong(Convert.ToInt16(numericIndex.Value));
            UpdatePlaylist();
        }

        private void button13_Click(object sender, EventArgs e) //Удаление текущей песни
        {
            playlist.RemoveSong(playlist.CurrentSong());
            UpdatePlaylist();
        }

        private void button14_Click(object sender, EventArgs e) //Перемещение в начало плейлиста
        {
            playlist.CurrentIndex = 0;
            LoadSong();
            UpdatePlaylist();
        }

        private void SongRemoveByNameButton_Click(object sender, EventArgs e)
        {
            if (SongNameToDelete.Text != string.Empty && listBoxSongs.Items.Contains(SongNameToDelete.Text))
            {
                playlist.RemoveSong(SongNameToDelete.Text);
                UpdatePlaylist();
            }
            else
            {
                MessageBox.Show("Песня не найдена");
            }
        }
    }
}

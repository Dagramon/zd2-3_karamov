
namespace zd2_3_karamov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MoveToStartButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.RemoveCurrentSongButton = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ClearPlaylistButton = new System.Windows.Forms.Button();
            this.RemoveSongButton = new System.Windows.Forms.Button();
            this.SelectSongButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numericIndex = new System.Windows.Forms.NumericUpDown();
            this.AddExistingSongButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxSongs = new System.Windows.Forms.ComboBox();
            this.AddNewSongButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.SongNameToDelete = new System.Windows.Forms.TextBox();
            this.SongRemoveByNameButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem1.Text = "2 задание";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem2.Text = "3 задание";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(397, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 57);
            this.button6.TabIndex = 16;
            this.button6.Text = "Вывести прибыль (перегрузка метода)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Список всех продуктов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(617, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Продать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(229, 181);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(51, 23);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цена";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(161, 152);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Название продукта";
            this.textBox2.Size = new System.Drawing.Size(119, 23);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Прибыль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Продукты";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(323, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 229);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Название магазина";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Магазины";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 440);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SongRemoveByNameButton);
            this.panel2.Controls.Add(this.SongNameToDelete);
            this.panel2.Controls.Add(this.MoveToStartButton);
            this.panel2.Controls.Add(this.FileLabel);
            this.panel2.Controls.Add(this.RemoveCurrentSongButton);
            this.panel2.Controls.Add(this.textBoxAuthor);
            this.panel2.Controls.Add(this.textBoxFilename);
            this.panel2.Controls.Add(this.AuthorLabel);
            this.panel2.Controls.Add(this.ClearPlaylistButton);
            this.panel2.Controls.Add(this.RemoveSongButton);
            this.panel2.Controls.Add(this.SelectSongButton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.numericIndex);
            this.panel2.Controls.Add(this.AddExistingSongButton);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.comboBoxSongs);
            this.panel2.Controls.Add(this.AddNewSongButton);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.PreviousButton);
            this.panel2.Controls.Add(this.Picture);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.listBoxSongs);
            this.panel2.Controls.Add(this.SongNameLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 444);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // MoveToStartButton
            // 
            this.MoveToStartButton.Location = new System.Drawing.Point(243, 386);
            this.MoveToStartButton.Name = "MoveToStartButton";
            this.MoveToStartButton.Size = new System.Drawing.Size(130, 41);
            this.MoveToStartButton.TabIndex = 25;
            this.MoveToStartButton.Text = "Перейти в начало плейлиста";
            this.MoveToStartButton.UseVisualStyleBackColor = true;
            this.MoveToStartButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(511, 76);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(36, 15);
            this.FileLabel.TabIndex = 24;
            this.FileLabel.Text = "Файл";
            // 
            // RemoveCurrentSongButton
            // 
            this.RemoveCurrentSongButton.Location = new System.Drawing.Point(243, 331);
            this.RemoveCurrentSongButton.Name = "RemoveCurrentSongButton";
            this.RemoveCurrentSongButton.Size = new System.Drawing.Size(130, 47);
            this.RemoveCurrentSongButton.TabIndex = 23;
            this.RemoveCurrentSongButton.Text = "Удалить текущую песню";
            this.RemoveCurrentSongButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentSongButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(243, 212);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.PlaceholderText = "Автор";
            this.textBoxAuthor.Size = new System.Drawing.Size(131, 23);
            this.textBoxAuthor.TabIndex = 22;
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(243, 183);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.PlaceholderText = "Имя файла";
            this.textBoxFilename.Size = new System.Drawing.Size(131, 23);
            this.textBoxFilename.TabIndex = 21;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(509, 59);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(40, 15);
            this.AuthorLabel.TabIndex = 20;
            this.AuthorLabel.Text = "Автор";
            // 
            // ClearPlaylistButton
            // 
            this.ClearPlaylistButton.Location = new System.Drawing.Point(243, 302);
            this.ClearPlaylistButton.Name = "ClearPlaylistButton";
            this.ClearPlaylistButton.Size = new System.Drawing.Size(130, 23);
            this.ClearPlaylistButton.TabIndex = 19;
            this.ClearPlaylistButton.Text = "Очистить плейлист";
            this.ClearPlaylistButton.UseVisualStyleBackColor = true;
            this.ClearPlaylistButton.Click += new System.EventHandler(this.button12_Click);
            // 
            // RemoveSongButton
            // 
            this.RemoveSongButton.Location = new System.Drawing.Point(562, 355);
            this.RemoveSongButton.Name = "RemoveSongButton";
            this.RemoveSongButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSongButton.TabIndex = 18;
            this.RemoveSongButton.Text = "Удалить";
            this.RemoveSongButton.UseVisualStyleBackColor = true;
            this.RemoveSongButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // SelectSongButton
            // 
            this.SelectSongButton.Location = new System.Drawing.Point(451, 355);
            this.SelectSongButton.Name = "SelectSongButton";
            this.SelectSongButton.Size = new System.Drawing.Size(75, 23);
            this.SelectSongButton.TabIndex = 17;
            this.SelectSongButton.Text = "Выбрать";
            this.SelectSongButton.UseVisualStyleBackColor = true;
            this.SelectSongButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(509, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Индекс песни";
            // 
            // numericIndex
            // 
            this.numericIndex.Location = new System.Drawing.Point(488, 326);
            this.numericIndex.Name = "numericIndex";
            this.numericIndex.Size = new System.Drawing.Size(120, 23);
            this.numericIndex.TabIndex = 15;
            // 
            // AddExistingSongButton
            // 
            this.AddExistingSongButton.Location = new System.Drawing.Point(265, 92);
            this.AddExistingSongButton.Name = "AddExistingSongButton";
            this.AddExistingSongButton.Size = new System.Drawing.Size(84, 23);
            this.AddExistingSongButton.TabIndex = 14;
            this.AddExistingSongButton.Text = "Добавить";
            this.AddExistingSongButton.UseVisualStyleBackColor = true;
            this.AddExistingSongButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Существующие песни";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(243, 152);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Название";
            this.textBoxName.Size = new System.Drawing.Size(131, 23);
            this.textBoxName.TabIndex = 9;
            // 
            // comboBoxSongs
            // 
            this.comboBoxSongs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSongs.FormattingEnabled = true;
            this.comboBoxSongs.Items.AddRange(new object[] {
            "Песня1|song1.mp3|Антон",
            "Песня2|song2.mp3|Хамид"});
            this.comboBoxSongs.Location = new System.Drawing.Point(213, 63);
            this.comboBoxSongs.Name = "comboBoxSongs";
            this.comboBoxSongs.Size = new System.Drawing.Size(183, 23);
            this.comboBoxSongs.TabIndex = 8;
            // 
            // AddNewSongButton
            // 
            this.AddNewSongButton.Location = new System.Drawing.Point(243, 257);
            this.AddNewSongButton.Name = "AddNewSongButton";
            this.AddNewSongButton.Size = new System.Drawing.Size(131, 39);
            this.AddNewSongButton.TabIndex = 7;
            this.AddNewSongButton.Text = "Добавить новую песню";
            this.AddNewSongButton.UseVisualStyleBackColor = true;
            this.AddNewSongButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(592, 273);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(45, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = ">>";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(451, 273);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(45, 23);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "<<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Picture.Location = new System.Drawing.Point(451, 94);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(186, 173);
            this.Picture.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Плейлист";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 15;
            this.listBoxSongs.Location = new System.Drawing.Point(19, 33);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(188, 394);
            this.listBoxSongs.TabIndex = 1;
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Location = new System.Drawing.Point(509, 44);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(95, 15);
            this.SongNameLabel.TabIndex = 0;
            this.SongNameLabel.Text = "Название песни";
            // 
            // SongNameToDelete
            // 
            this.SongNameToDelete.Location = new System.Drawing.Point(527, 387);
            this.SongNameToDelete.Name = "SongNameToDelete";
            this.SongNameToDelete.PlaceholderText = "Название песни для удаления";
            this.SongNameToDelete.Size = new System.Drawing.Size(173, 23);
            this.SongNameToDelete.TabIndex = 26;
            // 
            // SongRemoveByNameButton
            // 
            this.SongRemoveByNameButton.Location = new System.Drawing.Point(585, 416);
            this.SongRemoveByNameButton.Name = "SongRemoveByNameButton";
            this.SongRemoveByNameButton.Size = new System.Drawing.Size(75, 23);
            this.SongRemoveByNameButton.TabIndex = 27;
            this.SongRemoveByNameButton.Text = "Удалить";
            this.SongRemoveByNameButton.UseVisualStyleBackColor = true;
            this.SongRemoveByNameButton.Click += new System.EventHandler(this.SongRemoveByNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 468);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Задания";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearPlaylistButton;
        private System.Windows.Forms.Button RemoveSongButton;
        private System.Windows.Forms.Button SelectSongButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericIndex;
        private System.Windows.Forms.Button AddExistingSongButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxSongs;
        private System.Windows.Forms.Button AddNewSongButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Panel Picture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Button RemoveCurrentSongButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button MoveToStartButton;
        private System.Windows.Forms.Button SongRemoveByNameButton;
        private System.Windows.Forms.TextBox SongNameToDelete;
    }
}


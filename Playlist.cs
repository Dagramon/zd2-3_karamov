using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_karamov
{
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set { currentIndex = value; }
        }

        public Playlist() //инициализация листа
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public List<Song> GetList()
        {
            return list;
        }
        public void MoveToPrevious()
        {
            if (currentIndex > 0)
            {
                currentIndex -= 1;
            }
        }

        public void MoveToNext()
        {
            if (currentIndex + 1 < list.Count)
            {
                currentIndex += 1;
            }
        }

        public void ClearPlaylist()
        {
            list.Clear();
            currentIndex = 0;
        }

        public void AddSong(Song song)
        {
            list.Add(song);
            currentIndex = list.IndexOf(song);
        }

        public void AddSong(string title, string filename, string author)
        {
            Song song = new Song();
            song.Title = title;
            song.Filename = filename;
            song.Author = author;
            list.Add(song);
            currentIndex = list.IndexOf(song);
        }
        public void RemoveSong(int index)
        {
            if (list.Count > 0)
            {
                list.RemoveAt(index);
                currentIndex = 0;
            }
        }
        public void RemoveSong(Song song)
        {
            if (list.Count > 0)
            {
                list.Remove(song);
                currentIndex = 0;
            }
        }
        public Song CurrentSong() //получение текущей песни
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
    }
}

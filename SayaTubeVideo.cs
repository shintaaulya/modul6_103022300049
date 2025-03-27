using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300049
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        public int PlayCount { get; private set; }

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title)|| title.Length > 200)
                throw new ArgumentException(" Judul tidak boleh kosong dan maksimal 200 karakter. ");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.PlayCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
                throw new ArgumentException(" Play count harus ada di antara 0 - 25.000.000. ");

            checked
            {
                try
                {
                    PlayCount += count;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Play count melebihi batas integer! ");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}, Title: {title}, PlayCount: {PlayCount}");
        }
    }
}

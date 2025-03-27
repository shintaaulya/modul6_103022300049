using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300049
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 100)
                throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter. ");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        
        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentNullException(" Video tidak boleh null. ");
            if (video.PlayCount >= 8)
                throw new InvalidOperationException(" Maksimal menyimpan 8 video. ");

            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (var video in uploadedVideos)
            {
                totalPlayCount += video.PlayCount;
            }
            return totalPlayCount;
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User: {username}");
            for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
            {
                Console.Write($"{i + 1}. ");
                uploadedVideos[i].PrintVideoDetails();
            }
        }
    }
}

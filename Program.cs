
using modul6_103022300049;
using System;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Shinta Alya");

            for (int i = 1; i<= 8; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review film {i}");
                user.AddVideo(video);
                video.IncreasePlayCount(100000);
            }

            user.PrintAllVideoPlayCount();

            SayaTubeVideo video9 = new SayaTubeVideo("Video ke-9");
            user.AddVideo(video9);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                
        }
    }
}
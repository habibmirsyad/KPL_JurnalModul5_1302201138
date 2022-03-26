using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_1302201138_MOD5_JURNAL_GGR
{
    public class SayaTubeUser:SayaTubeVideo
    {
        protected int id;
        public string username;
        protected SayaTubeVideo[] uploadedVideos;
        

        public SayaTubeUser(string name)
        {
            username = name;
            Random r = new Random();
            id = r.Next(1, 6);
            uploadedVideos = new SayaTubeVideo[0];
        }

        public int getTotalVideoPlayCount()
        {
            return uploadedVideos.Length;
            
        }

        public void addVideo(SayaTubeVideo stv)
        {
            List<string> video = new List<string>();
            for (int i = 0;uploadedVideos[i] != null; i++)
            {
               
                video.Add(username);
                video.Add(uploadedVideos[i].title);
            }
            stv = video;
        }

        public void printAllVideoOlaycount()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("User: " + username);
                Console.WriteLine("Video "+ i+1 +" judul: " + uploadedVideos[i].title);
            }
            
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_1302201138_MOD5_JURNAL_GGR
{
    public class SayaTubeVideo : SayaTubeUser
    {
        protected int id, playCount;
        protected string title;

        public SayaTubeVideo(string judul)
        {
            title = judul;
            Random r = new Random();
            id = r.Next(1,6);
            playCount = 0;

        }

        public void increasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("        ID : " + id);
            Console.WriteLine("     Title : " + title);
            Console.WriteLine("Play Count : " + playCount);
        }

        public static implicit operator SayaTubeVideo(List<string> v)
        {
            throw new NotImplementedException();
        }
    }
}

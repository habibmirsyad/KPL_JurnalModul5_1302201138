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

        public SayaTubeVideo(string title)
        {
            playCount = 0;
            try
            {
                if (title.Length > 100) throw new Exception("Panjang title melewati batas!");
                this.title = title;
                Random r = new Random();
                id = r.Next(1, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.title = "-";
            }

        }

        public void increasePlayCount(int playCount)
        {
            try
            {
                if (playCount > 25000000 || playCount < 0) throw new Exception("Play count melewati batas!");
                int cek = checked(playCount + this.playCount);
                this.playCount += playCount;
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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

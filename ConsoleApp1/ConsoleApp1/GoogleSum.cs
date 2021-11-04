using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GoogleSum
    {
        public int value = 0;

        public GoogleSum()
        {
            WebClient client = new WebClient();
            string str = client.DownloadString("http://www.gooogle.com");
            int sum = 0;

            foreach (var character in str)
            {
                if (char.IsNumber(character))
                {
                    sum += int.Parse(character.ToString());
                }
            }

            value = sum;
        }
    }
}

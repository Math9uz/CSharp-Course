using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Robson
{
    class Progam
    {
        static void Main()
        {
            List<string>bomdia=new List<string>();
            List<string>cores=new List<string>();
            List<string>cores2=new List<string>();

            bomdia.Add("Bom dia!");

            cores.Add("Vermelho");
            cores.Add("Verde");
            cores.Add("Azul");

            cores2.Add("Amarelo Laranja Cinza");

            foreach(string b in bomdia)
            {
                Console.WriteLine(b);
            }

            foreach(string c in cores)
            {
                Console.WriteLine(c);
            }
            foreach(string a in cores2)
            {
                Console.WriteLine(a);
            }

        }
    }
}

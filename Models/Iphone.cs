using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoCelulares.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarApp(string nomeApp) {
            Console.WriteLine($"{nomeApp} baixado no seu Iphone!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public  class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Işık açıldı");
        }

        public void TurnOff()
        {
            Console.WriteLine("Işık kapandı");
        }
    }
}

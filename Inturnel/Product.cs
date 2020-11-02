using System;
using System.Collections.Generic;
using System.Text;

namespace Inturnel
{
    public class Product
    {
        public int Id { get; set; }
        protected int Price { get; set; }//така в мейна потребителя няма достъп до Price, но ShavingFoam има. 
        internal string Name { get; set; }
    }
}

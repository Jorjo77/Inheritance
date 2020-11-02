using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    class TennisEvent : Event
    {
        public DateTime Duration { get; set; }
        //такова презаписване обикновено не се прави (не случайно ВиЕс-а ни го подчертава, ако ни се наложи да го правим нещо в архитектурата ни е сбъркано). Трябва да се оверрайдва

        public void Start()
        {
            Console.WriteLine("Zagrqwka!!!");
            base.Start();
        }// така да скрием стария клас, но да ползваме неговата функционалност се използва по-често!

        public void Print()
        {
            this.Duration = DateTime.Now;
            base.Duration = 5;
        }
    }
}

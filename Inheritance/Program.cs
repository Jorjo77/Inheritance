using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance - наследяване:
            //Code reusability
            //Code readability
            //Base Class - Parent class, Superclass - the class giving its members to its child class
            //Subclass - Child class, Derived class
            // - the class taking members from the base classs 
            //Ако мембъра в Base Class е private, той не се наследява.
            //Ако обаче е protected мембъра ще е видим от класовете които наследяват Base Class -а; 
            //internal значи че е е видим само  за този проект (по дефолт е private всяко едно нещо)!? 
            //Конструктурите не се наследяват, но могат са бъдат преизползвани от децата с :base и викаме базовия конструктор
            //При конструктурите винаги тръгва от на Base Class конструктора, следва следващия по йерархия клас - извиква му конструктора и т.н. (ако имаме повече чейнати класове) . Конструкторите не се наследяват, а автоматично се извикват.
            //При наследяването има транзитивна връзка - щом един клас е дете на друг, то той е дете и на бащата на другия (дядото). В C# няма наследяване на повече от един клас, но могат да бъдат  имплементирани множество интерфейси.
            //draw.io - удибен сайт за чертане на диаграмки
            //Всеки един клас който наследява друг има достъп до base. Често се полва без да се пише (като .this), не се пише ако няма нужда. Всеки един мембър който наследяваме можем да достъпим с base.
            //Щом има наследяване конструктора от базовия клас винаги се изпълнява.
            //Ctrl+Shift+B билдва целия проект в салюшъна
            //Internal мембърите съществуват (се достъпват) САМО в проекта в който са!
            //Private members don't inherited!
            //Shadowing variables - децата могат да скриват пропъртита на базови класове!
            //Можем да извикваме базови методи с .base, преди да ги презапишем.

            // FactoryWorker worker = new FactoryWorker();
            // worker.Name = "Pesho";
            // Console.WriteLine(worker.Name);
            //worker.Sleep();
            // worker.Eat();
            // Student student = new Student();
            // student.Eat();


            FactoryWorker person = new FactoryWorker();
            FactoryWorker person2 = new FactoryWorker("БМВ");
        }
    }
}

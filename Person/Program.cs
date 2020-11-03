using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Child person = new Baby();// Тук само защото сме казали че детето е Person person от ляво не можем да му достъпим пропъртито (това не значи че го няма, има го!).Age . Кажем ли Child person .Age  си работи. Това нещо е абстракция, мощно е и в бъдеще ще си говорим за него.
            //реално base е винаги едно ниво нагоре

            //Person person = new Person();
            //Person person = new Robot();
            person.Sleep();
            //person.Age 
        }
    }
}

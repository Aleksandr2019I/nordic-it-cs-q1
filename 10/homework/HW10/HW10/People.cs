using System;

namespace HW10
{
    class People //Люди
    {
        public string name; //ИМЯ
        public byte age; // Возраст
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели некоректное значение");
                }
                name = value;
            }
        }
        public byte Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Вы ввели некоректное значение");
                }
                age = value;
            }
        }
        public People(string name, byte age) //компилятор дописывает автоматом
        {
            Name = name;
            Age = age;
        }
        byte LiterAge
        {
            get { return (byte)(age + 4); }
        }
        public string AllDescription =>
            $"Name: {name}, age in 4 years:{LiterAge}.";
    }
}

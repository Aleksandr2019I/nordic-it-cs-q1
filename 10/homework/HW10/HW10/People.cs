using System;

namespace HW10
{
    class People //Люди
    {
        string _name; //ИМЯ
        byte _age; // Возраст
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели некоректное значение");
                }
                _name = value;
            }
        }
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Вы ввели некоректное значение");
                }
                _age = value;
            }
        }
        public People(string _name, byte _age) //компилятор дописывает автоматом
        {

            Name = _name;
            Age = _age;
         
        }

        byte LiterAge
        {
            get { return (byte)(_age + 4); }
        }
        public string AllDescription =>
            $"Name: {_name}, age in 4 years:{LiterAge}.";
    }
}

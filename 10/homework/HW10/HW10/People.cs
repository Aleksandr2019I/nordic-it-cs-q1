using System;

namespace HW10
{
    class People
    {
        string _name; //ИМЯ
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("В имени не должно быть пробелов или пустых строк");
                }
                _name = value;
            }
        }
        int _age; // Возраст
        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Вы ввели некоректное значение");
                }
                _age = value;
            }
        }
        //int LaterAge { get; set; } // возраст Спустя 4 года

        // string FinalyStr { get; set; } //финальная строка
        public People() //компилятор дописывает автоматом
        { }
        public People(string Name, int Age) //компилятор описывает автоматом
        {
            
        }
        public string Description =>
            $"{Age + 4}";
        public string AllDescription =>
            $"Name: {Name}, age in 4 years:{Description}";
    }
}

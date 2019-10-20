using System;

namespace HW10
{
    class People //Люди
    {
        string _name; //ИМЯ
        int _age; // Возраст
        int LaterAge { get; set; }
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
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    throw new ArgumentException("Вы ввели некоректное значение");
                }
                _age = value;
            }
        }
        public People() //компилятор дописывает автоматом
        {
                Console.WriteLine($"имя ");
                _name = Console.ReadLine();
                Console.WriteLine($"Возраст ");
                _age = int.Parse(Console.ReadLine());
                LaterAge = _age + 4;                    
        }
      
        string Description =>
            $"{LaterAge}";
        public string AllDescription =>
            $"Name: {_name}, age in 4 years:{Description}.";
    }
}

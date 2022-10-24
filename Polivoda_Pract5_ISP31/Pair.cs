using System;
using System.Windows;

namespace Polivoda_Pract5_ISP31
{
    //Создать класс Pair(пара четных чисел). Создать необходимые методы и свойства.
    //Определить метод вычисления произведения чисел.Создать перегруженный метод
    //для вычисления произведения 2 пар чисел – (а, b)* (с, d) = (a* c) , (b* d).
    public class Pair
    {
        private int _first;
        private int _second;
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
        
        public int First
        {
            get => _first; 
            set
            {
                if (value % 2 != 0)
                    throw new ArgumentException("Вы даун");
                
                _first = value;
            }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                if (value % 2 != 0)
                    throw new ArgumentException("Вы даун");

                _second = value;
            }
        }
        public int Myltiply()
        { 
            return First * Second;
        }
        public Pair Myltiply(Pair value)
        {
            return new Pair(First * value.First , Second * value.Second);
        }

        public override string ToString()
        {
            return $"{First}, {Second}";
        }
    }
}

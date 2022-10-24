using System;
using System.Windows;

namespace Polivoda_Pract5_ISP31
{
    //������� ����� Pair(���� ������ �����). ������� ����������� ������ � ��������.
    //���������� ����� ���������� ������������ �����.������� ������������� �����
    //��� ���������� ������������ 2 ��� ����� � (�, b)* (�, d) = (a* c) , (b* d).
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
                    throw new ArgumentException("�� ����");
                
                _first = value;
            }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                if (value % 2 != 0)
                    throw new ArgumentException("�� ����");

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

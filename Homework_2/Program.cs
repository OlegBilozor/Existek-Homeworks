using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.AddMark(4, 0);
            st.AddMark(4, 0);
            st.AddMark(3, 0);
            st.AddMark(3, 1);
            st.AddMark(5, 2);
            st.AddMark(2, 1);
            st.AddMark(3, 2);
            st.AddMark(4, 1);
            st.AddMark(1, 2);
            st.AddMark(3, 2);
            st.GetMarks(1);
            Console.WriteLine(st.GetAvarage(2)); 
            Console.WriteLine(st);
            Console.ReadLine();
        }
    }
    class Student
    {
        #region Properties and Fields
        public string Name { get; }
        public string Surname { get; }
        public string Secondname { get; }
        public string Group { get; }
        public int Age { get; }
        private int[] _prog;
        private int[] _admin;
        private int[] _design;
        #endregion
        #region Constructors
        public Student() : this("Petro", "Petrenko", "Petrovich", "2PE", 18)
        {

        }
        public Student(string name, string surname, string secondname, string group, int age)
        {
            Name = name;
            Surname = surname;
            Secondname = secondname;
            Group = group;
            Age = age;            
        }
        #endregion
        #region Methods
        public void AddMark(int mark, int index)
        {
            int[] newArr;
            switch(index)
            {
                case 0:
                    if (_prog == null)
                    {
                        _prog = new int[1];
                        _prog[0] = mark;
                    }
                    else
                    {
                        newArr = new int[_prog.Length + 1];
                        for (int i = 0; i < _prog.Length; i++)
                            newArr[i] = _prog[i];
                        newArr[newArr.Length - 1] = mark;
                        _prog = newArr;
                    }
                    break;
                case 1:
                    if (_admin == null)
                    {
                        _admin = new int[1];
                        _admin[0] = mark;
                    }
                    else
                    {
                        newArr = new int[_admin.Length + 1];
                        for (int i = 0; i < _admin.Length; i++)
                            newArr[i] = _admin[i];
                        newArr[newArr.Length - 1] = mark;
                        _admin = newArr;
                    }
                    break;
                case 2:
                    if (_design == null)
                    {
                        _design = new int[1];
                        _design[0] = mark;
                    }
                    else
                    {
                        newArr = new int[_design.Length + 1];
                        for (int i = 0; i < _design.Length; i++)
                            newArr[i] = _design[i];
                        newArr[newArr.Length - 1] = mark;
                        _design = newArr;
                    }
                    break;
                default:
                    Console.WriteLine("Indavid index!");
                    break;
            }
        }
        public void GetMarks(int index)
        {
            switch(index)
            {
                case 0:
                    Console.WriteLine("Programming marks:");
                    foreach(int mark in _prog)
                    {
                        Console.Write($"{mark} ");
                    }
                    break;
                case 1:
                    Console.WriteLine("Administration marks:");
                    foreach (int mark in _admin)
                    {
                        Console.Write($"{mark} ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Design marks:");
                    foreach (int mark in _design)
                    {
                        Console.Write($"{mark} ");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid index!");
                    break;
            }
            Console.WriteLine();
        }
        public double GetAvarage(int index)
        {
            double res = 0;
            switch(index)
            {
                case 0:
                    if (_prog != null)
                        res =(double) _prog.Sum() / _prog.Length;
                    else
                        return 0;
                    break;
                case 1:
                    if (_admin != null)
                        res = (double)_admin.Sum() / _admin.Length;
                    else
                        return 0;
                    break;
                case 2:
                    if (_design != null)
                        res = (double)_design.Sum() / _design.Length;
                    else
                        return 0;
                    break;
                default:
                    Console.WriteLine("Invalid index!");
                    break;                    
            }
            return res;
        }
        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {Name}, Secondname: {Secondname}, Age: {Age}, Group: {Group},\nProgramming: {GetAvarage(0):N0}, Administration: {GetAvarage(1):N0}, Design: {GetAvarage(2):N0}";
        }
        #endregion
    }
}

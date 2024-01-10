﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotskin_Triangle
{
    internal class Triangle_
    {
        public double h;
        public double a;//стороны и высота
        public double b;
        public double c;
        

        public Triangle_(double A, double B, double C)//конструктор
        {
            a = A;
            b = B;
            c = C;

        }
        public Triangle_()
        {
            a = 50;//конструктор по дефолту без аршументов
            b = 50;
            c = 50;

        }
        public bool IsScalene() //проверка разносторонни ли
        { return a != b && a != c && b != c; } //если не одна сторона не равна не одной
        public bool IsEquilateral() //проврека равнобедренный ли
        { return a == b && a == c;} //строная провера совпадают ли обе стороны

        public bool IsIsosceles() //проверка равносторонний ли
        {return a == b || a == c || b == c;} //если хоть одна сторону совпадает
                       



        public string outputA() //выводим сторону в виде строки
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public double Perimeter()//сумма всех сторон
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double OutputH() //высота
        {

            double s = Surface();
            double h = 2 * s / a; //мат формула
            return h;
        }


        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double GetSetA
        {
            get { return a; }
            set { a = value; }

        }

        public double GetSetB //установить или изсменить 
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }

        public bool ExistTriangle //существует ли треугольнмк
        {
            get
            {

                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                else return false;
            }
        }

    }
}

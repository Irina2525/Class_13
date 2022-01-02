using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13
{
    class Building
    {
        string address;
        int lenght;
        int width;
        int height;

        int Height // свойство
        {
            get // получить
            {
                return height; // возвращаем height - высота
            }
            set
            {
                if (value > 30) 
                    height = 30;
                else if (value < 0)
                    height = 1;
                else
                    height = value;
            }
        }

        public Building(string address, int lenght, int width, int height)
        {
            this.address = address;
            this.lenght = lenght;
            this.width = width;
            this.Height = height; // присваиваем не в поле, а в свойство 
        }
        public string Print() // метод, который выводит информацию о здании
        {
            return $"\nАдрес здания: {address} \nДлина заданя: {lenght} \nШирина заданя: {width} \nВысота заданя: {height}";
        }

    }
}

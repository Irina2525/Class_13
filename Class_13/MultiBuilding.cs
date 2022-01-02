using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13
{
    class MultiBuilding : Building
    {
        int level;

        public MultiBuilding(string address, int lenght, int width, int height, int level) // конструктор
          : base(address, lenght, width, height) // вызываем родительский конструктор
        {
            this.level = level; // тело конструктора, инициализируем 5й параметр  level
        }
        public string Print()
        {
            string result = base.Print(); // в эту переменную поместится строка из родиетльского класса (из public string Print) 
            result += $"\nЭтажность здания: {level}"; // к этой строке добавляем вывод этажа здания - level
            return result; // возвращаем result
        }

    }
}

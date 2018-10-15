using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Level = new Random();// Random

            MyClassLib tank1 = new MyClassLib("Т-34");//№1 танк
            tank1.TanksQuantity = 5;
            tank1._LevelOfAmmunitionTank = Level.Next(1, 100);//Случайно получаеть процент Боекомплекта,Уровень брони и Уровень маневренности
            tank1._LevelArmorTank = Level.Next(1, 100);
            tank1._LevelOfManeuverabilityTank = Level.Next(1, 100);
            int tank11;
            tank11 = tank1._LevelOfAmmunitionTank + tank1._LevelArmorTank + tank1._LevelOfManeuverabilityTank;
            MyClassLib tank2 = new MyClassLib("Pantera");//№2 танк
            tank2.TanksQuantity = 5;
            tank2._LevelOfAmmunitionTank = Level.Next(1, 100);//Случайно получаеть процент Боекомплекта,Уровень брони и Уровень маневренности
            tank2._LevelArmorTank = Level.Next(1, 100);
            tank2._LevelOfManeuverabilityTank = Level.Next(1, 100);
            int tank22;
            tank22 = tank2._LevelOfAmmunitionTank + tank2._LevelArmorTank + tank2._LevelOfManeuverabilityTank;
            Console.WriteLine("Название танка:"+tank1._NameTank+"\nКоличество танков: "+tank1.TanksQuantity +"\nБоекомплект: " + tank1._LevelArmorTank+"%"+ "\nУровень брони: " + tank1._LevelOfAmmunitionTank+"%" + "\nУровень маневренности: " + tank1._LevelOfManeuverabilityTank+"%\n\n");
            Console.WriteLine("Название танка:" + tank2._NameTank + "\nКоличество танков: " + tank2.TanksQuantity +"\nБоекомплект: " + tank2._LevelArmorTank + "%" + "\nУровень брони: " + tank2._LevelOfAmmunitionTank + "%" + "\nУровень маневренности: " + tank2._LevelOfManeuverabilityTank + "%");
            if(tank11 > tank22)
            {
                Console.WriteLine("\n\nТанк Т-34 выиграл");
            }
            else
            {
                Console.WriteLine("\n\nТанк Pantera выиграл");
            }
           
            Console.ReadKey();
        }
    }
}

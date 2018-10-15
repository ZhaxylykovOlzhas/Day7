using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        public string _NameTank { get; set; }
        public int _LevelOfAmmunitionTank { get; set; }
        public int _LevelArmorTank { get; set; }
        public int _LevelOfManeuverabilityTank { get; set; }
        Random Level = new Random();

        public Tank(string NameTank/*,int LevelOfAmmunitionTank,int LevelArmorTank ,int LevelOfManeuverabilityTank*/)
        {
            _NameTank = NameTank;
            _LevelOfAmmunitionTank = Level.Next(1, 100);
            _LevelArmorTank = Level.Next(1, 100);
            _LevelOfManeuverabilityTank = Level.Next(1, 100);
            //_LevelOfAmmunitionTank = LevelOfAmmunitionTank;
            //_LevelArmorTank = LevelArmorTank;

            //_LevelOfManeuverabilityTank = LevelOfManeuverabilityTank;

        }

    }
}

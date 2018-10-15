using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class MyClassLib
    {
        public string _NameTank { get; set; }
        public int _LevelOfAmmunitionTank { get; set; }
        public int _LevelArmorTank { get; set; }
        public int _LevelOfManeuverabilityTank { get; set; }
        public int TanksQuantity {get;set;}
        public MyClassLib(string NameTank)
           {
                _NameTank = NameTank;
            }     

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    public class Aircraft
    {
        public int MaxAmmo { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentAmmo { get; set; }
        public string Type;

        public Aircraft(int maxAmmo, int baseDamage, string type)
        {
            MaxAmmo = maxAmmo;
            BaseDamage = baseDamage;
            Type = type;
            CurrentAmmo = 0;
        }

        public int Fight()
        {
            int Damage = CurrentAmmo * BaseDamage; //a jelenlegi fegyverek szorozva a sebzés/db mértékével = az össz.sebzéssel.
            CurrentAmmo = 0; //és így lenullázom a teljes fegyver készletemet.
            return Damage;
        }
        public int Refill(int storage)
        {
            if (storage < MaxAmmo)
            { //Ha a raktárban kevesebb van, mint amennyit betölthetek:
                CurrentAmmo = storage; //akkor a raktár teljes mennyiségét áttöltöm a jelenlegi készletbe
                return 0; //és 0-át returnolok, mert a raktár üres lesz.
            }
            else
            { //különben a maximumra töltöm a jelegi készletet
                CurrentAmmo = MaxAmmo;
                return storage - MaxAmmo; //a raktárból pedig levonom a feltöltött mennyiséget és ezt returnolom.
            }
        }

        public string GetType()
        {
            return Type;
        }

        public string GetStatus()
        {
            return @"Type {type}, Ammo: {currentAmmo}, Base Damage: {baseDamage}, All Damage: {Damage}";

        }
    }
}

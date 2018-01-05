using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    public class Carrier
    {
        public List<Aircraft> aircrafts; //a feladat szerint: should be able to store... tehát lista kell neki a tároláshoz, mégpedig aircraft típusú lista, mert azokat akarom tárolni és nem intet meg hasonlót.
        public int StoreOfAmmo;
        public int HealthPoint;

        public Carrier(int storeOfAmmo, int healthPoint)
        {
            aircrafts = new List<Aircraft>();
            StoreOfAmmo = storeOfAmmo;
            HealthPoint = healthPoint;
        }
        public void AddAircraft(string type)
        {
            if (type == "F16")
            {
                F16 f16 = new F16();
                aircrafts.Add(f16);
            }
            else if (type == "F35")
            {
                F35 f35 = new F35();
                aircrafts.Add(f35);
            }
        }
        public void AmmoChecker()
        {
            if (StoreOfAmmo == 0)
            {
                throw new Exception("Out of ammo!");
            }
        }
        public void Fill()
        {
            int allAmmoNeed = 0;

            foreach (var aircraft in aircrafts)
            {
                allAmmoNeed += aircraft.MaxAmmo;
            }

            try
            {
                AmmoChecker();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var plane in aircrafts)
            {
                if (StoreOfAmmo < plane.MaxAmmo * aircrafts.Count)
                {
                    if (plane.Type == "F35")
                    {
                        StoreOfAmmo = plane.Refill(StoreOfAmmo);
                    }
                }
                else
                {
                    StoreOfAmmo = plane.Refill(StoreOfAmmo);
                }
            }
        }
        public void Fight(Carrier javaDevelopers)
        {
            int totalDamage = 0;
            foreach (var plane in aircrafts)
            {
                totalDamage += plane.Fight();
            }

            javaDevelopers.HealthPoint -= totalDamage;
        }

        public string GetStatus()
        {
            if (HealthPoint <= 0)
            {
                return "It's dead Jim! :( ";
            }

            return String.Format(@"HP: {HealthPoint}, Aircraft Count: {aircrafts.Count}, Ammo Storage: {StoreOfAmmo}, Total Damage: {totalDamage} \nAircrafts:\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    public abstract class Animal
    {
        private string RFID;
        private string description;
        private string dateIn;
        private string locationFound;
        private decimal fee;
        private int daysInShelter;
        //this should be of type Owner
        private string owner;
        public bool isAdopted;
        public Animal(string rfid, string desc, string date, string location)
        {
            RFID = rfid; description = desc; dateIn = date; locationFound = location; daysInShelter = 0;
        }
        //this should be of type Owner
        public void UpdateOwner(string NewOwner) { owner = NewOwner; }
        public bool UpForAdoption()
        {
            if (daysInShelter >= 20 && owner != null) return true;
            else if (owner == null) return true;
            else return false;
        }
        public virtual string AsString()
        {
            string info = "Animal RFID: " + RFID + "; Description: " + description + "; Date checked in: " +
                dateIn + "; Location found: " + locationFound + "; Fee for adoption: " + fee + "; Days in shelter: " + daysInShelter + "Adopted?: " + isAdopted;
            if (owner != null)
                info += "; Owner: " + owner;
            return info;
        }
        public void UpdateCheckIn(string date)
        {
            dateIn = date;
        }
    }
    public class Dog : Animal
    {
        private string lastWalkDay;
        public Dog(string rfid, string desc, string date, string location) : base(rfid, desc, date, location)
        {
            lastWalkDay = "";
        }
        public void UpdateWalkDay(string date)
        {
            lastWalkDay = date;
        }
        public string GetLastWalkDay()
        {
            return lastWalkDay;
        }
        public override string AsString()
        {
            return base.AsString() + "; Last walk day: " + lastWalkDay;
        }
    }
    public class Cat : Animal
    {
        private string extraInfo;
        public Cat(string rfid, string desc, string date, string location, string xtraInf) : base(rfid, desc, date, location)
        {
            extraInfo = xtraInf;
        }
        public void UpdateInfo(string info)
        {
            extraInfo = info;
        }
        public override string AsString()
        {
            return base.AsString() + "; Extra information: " + extraInfo;
        }
    }
}

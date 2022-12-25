using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Passenger : IComparable<Passenger>
    {
        public string PassportSeries { get; private set; }
        public string PassportNumber { get; private set; }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public string Gender { get; private set; }
        public string Birth { get; private set; }
        public string Flight { get; private set; }


        public Passenger(string passportSeries, string passportNumber, string surname, string name, string patronymic, string gender, string birth, string flight )
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Gender = gender;
            Birth = birth;
            Flight = flight;
        }

        public int CompareTo(Passenger p)
        {
            return Surname.CompareTo(p.Surname);
        }
    }
}

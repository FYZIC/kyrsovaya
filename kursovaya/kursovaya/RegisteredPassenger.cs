using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class RegisteredPassenger : Passenger
    {
        public string BoadPassNumber { get;  set; }
        public string Seat { get;  set; }
        public string HandLug { get;  set; }
        public string Lug { get;  set; }
        public string ExtraLug { get;  set; }
        public string RegistrationTime { get; set; }

        public RegisteredPassenger(string passportSeries, string passportNumber, string surname, string name, string patronymic, string gender, string birth, string flight, string boadPasNumber, string seat, string handLug, string lug, string extraLug, string registrationTime) : base (passportSeries, passportNumber, surname, name, patronymic, gender, birth, flight)
        {
            BoadPassNumber = boadPasNumber;
            Seat = seat;
            HandLug = handLug;
            Lug = lug;
            ExtraLug = extraLug;
            RegistrationTime = registrationTime;
        }
        public override string ToString()
        {
            return ($"ФИО: {Surname} {Name} {Patronymic}, серия паспорта: {PassportSeries}, номер паспорта: {PassportNumber}, пол: {Gender}, дата рожд: {Birth}, рейс: {Flight}, номер: {BoadPassNumber}, место: {Seat}, ручная кладь: {HandLug}, багаж: {Lug}, доп багаж: {ExtraLug}, время регистрации: {RegistrationTime}");
        }
    }
}

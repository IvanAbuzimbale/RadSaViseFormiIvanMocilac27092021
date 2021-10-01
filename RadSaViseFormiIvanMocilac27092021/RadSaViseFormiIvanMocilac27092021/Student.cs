using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaViseFormiIvanMocilac27092021
{
    public class Student
    {
        public string Ime;
        public string prezime;
        public string brojIndeksa;
        public string smjer;
        public DateTime datumRodjenja;

        public Student()
        {

        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public string BrojIndeksa
        {
            get
            {
                return brojIndeksa;
            }
            set
            {
                brojIndeksa = value;
            }
        }
        public string Smjer
        {
            get
            {
                return smjer;
            }
            set
            {
                smjer = value;
            }
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;
            }
        }
        public override string ToString()
        {
            return Ime + " " + prezime + " " +
            brojIndeksa + " " +
            datumRodjenja.ToShortDateString() + " " + smjer;
        }
    }
}

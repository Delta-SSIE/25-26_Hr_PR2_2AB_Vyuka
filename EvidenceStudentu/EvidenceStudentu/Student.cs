using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceStudentu
{
    internal class Student
    {
       static int pocet = 1;
        int id;
        string jmeno;
        string prijmeni;
        int vek;

        public int Vek { get => vek; set => vek = value; }
        public string Prijmeni { get => prijmeni; set => prijmeni = value; }
        public string Jmeno { get => jmeno; set => jmeno = value; }
        public int Id { get => id; set => id = value; }

        public Student (string jm, string pr, int v)
        {
            if ((jm == "") || (pr == "") || (v == null))
            {
                id = pocet;
                pocet++;
                jmeno = "prazdne jmeno";
                prijmeni = "prazdne prijmeni";
                vek = 0;
            }
            else
            {
                id = pocet;
                pocet++;
                jmeno = jm;
                prijmeni = pr;
                vek = v;
            }
        }

        public override string ToString()
        {
            return "Student id:" + this.id + "jmeno: " + this.jmeno + " prijmeni: " + this.prijmeni + " vek: " + this.vek;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_10Lekce_GetSet
{
    internal class Osoba
    {
        // properties
        private string _jmeno { get; set; } = string.Empty;
        public string Jmeno
        {
            get { return _jmeno; }
            set { _jmeno = value; }
        }

        private string _prijmeni { get; set; } = string.Empty;
        public string Prijmeni
        {
            get { return _prijmeni; }
            set { _prijmeni = value; }
        }
        
        public string ChybovaHlaska { get; set; } = string.Empty;
        private int _vek;
        public int Vek
        {
            get { return _vek; }
            set 
            { 
                _vek = value; 
                if (_vek < 0)
                {
                    ChybovaHlaska = "Zadal jsi záporné číslo věku";
                }
                else if(_vek > 110)
                {
                    ChybovaHlaska = "Zadal jsi příliš veliké číslo věku";
                }
            }
        }

        public bool JePlnoleta
        {
            get
            {
                if (Vek >= 18 && Vek <= 110)
                {
                    return true;
                }
                return false;
            }
        }

        // consturctor
        public Osoba(string jmeno, string prijmeni, int vek) 
        { 
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }

        //methods
        public override string ToString()
        {
            if(string.IsNullOrEmpty(ChybovaHlaska)) 
            { 
                return $"Jméno: {Jmeno}, Příjmení: {Prijmeni}, Věk: {Vek}, Plnoletost: {JePlnoleta}";
            }
            else
            {
                return ChybovaHlaska;
            }
        }

    }
}

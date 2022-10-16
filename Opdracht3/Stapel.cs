using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    internal class Stapel<T>
    {
        List<T> stapel = new List<T>();
        public object Copy()
        {
            return this.MemberwiseClone();
            //Ik denk dat dit een Shallow Copy is.
        }
        public void Toevoegen(T input) { //Voegt de input toe aan de juiste stapel (als ik in String iets invoer zal het iets doorsturen naar die list
            stapel.Add(input);
            //MessageBox.Show("Data toegevoegd");
        }

        public T Verwijderen() {
            if (stapel.Count <= 0)
            {
                MessageBox.Show("Deze stapel is al leeg!");
                throw new Exception();
            }
            else {
                T waarde = stapel[stapel.Count - 1]; // de waarde is het item in de lijst op de laatste positie, omdat een list begint bij 0 ga je de grote min 1 doen
                stapel.RemoveAt(stapel.Count - 1); // Je verwijderd het item op deze positie, de laatste in de lijst in dit geval.
                MessageBox.Show("Data verwijderd");
                return waarde;
            }
        }
        public void MaakLeeg() {
            stapel.Clear();
            MessageBox.Show("Stapel geleegd!");
        }
        public bool isAanwezig(T item) { // De code is er maar geen idee waar ik ze zou moeten gebruiken.
            if (stapel.Contains(item)) {
                return true;
            } else { 
                return false;
            }
        }

        public int stapelGrote() //In het geval dat ik via een methode de grote van een stapel wel bekijken.
        {
            return stapel.Count;
        }

        


        public override string ToString() // Voegt alle items van Stapel toe aan dezelde string;
        {
            string stapelData = "";
            foreach (T t in stapel)
                stapelData += "[" + t.ToString() + "], "; //stapelDate = stapelData + t.toString();
            return stapelData;
        }



    }


}

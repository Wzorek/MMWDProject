using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserPreferences _user = new UserPreferences();
            List<Place> _placesList = new List<Place>();
            Result _result = new Result();
            _user.Set();    //Znamy preferencje użytkownika
            fillPlacesList(_placesList); //Mamy nadane przez użytwkownika miejsca
            sortPlacesList(_placesList); //Mamy x0
            _result = TabuSearchAlgorytm(_user, _placesList); //Implementujemy Algorytm
            if (_result.IsError() == true)
            {
                //Wypisz, że nie da się i trzeba zmienić priorytety
            }
        }

        public static void fillPlacesList(List<Place> List)
        {
            //Uzupełniam Listę Obiektami Place zdefiniowanymi przez użytkownika
        }

        public static void sortPlacesList(List<Place> List)
        {
            //Sportuje miejsca po bezwzględnej odległości
        }

        public static Result TabuSearchAlgorytm(UserPreferences user, List<Place> placesList)
        {
            
        }

    }
}

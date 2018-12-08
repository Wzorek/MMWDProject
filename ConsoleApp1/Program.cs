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
            int iterationsNotChanging = 0;
            List<List<Place>> Tabu = new List<List<Place>>();
            List<Result> Best = new List<Result>();
            Result Best4Car = new Result(0);    Best.Add(Best4Car);
            Result Best4Bike = new Result(1);   Best.Add(Best4Bike);
            Result Best4Bus = new Result(2);    Best.Add(Best4Bus);
            Result newBest = new Result();
            Result _finalresult = new Result();
            SortedList<int, Place> Neighbours = new SortedList<int, Place>();

            for (int WayOfTransport = 0; WayOfTransport < 3; WayOfTransport++)
            {
                for (int j=0; j<100; j++)
                {
                    createNeighbourhood(placesList, Neighbours, Tabu); //Tworzy mecierz sądziadów
                    newBest = findBestSolution(placesList, Neighbours, Tabu,); //
                    if (newBest == Best[WayOfTransport])
                    {
                        iterationsNotChanging++;
                    }
                    else
                    {
                        Best[WayOfTransport] = newBest;
                        iterationsNotChanging = 0;
                    }

                    placesList = Best[WayOfTransport].GetSequence();
                    if (iterationsNotChanging > 5) break; //Wyjdź jak już pięć razy nie poprawi się
                }
            }

            _finalresult = compareResults(Best);
            return _finalresult;
        }

    }
}

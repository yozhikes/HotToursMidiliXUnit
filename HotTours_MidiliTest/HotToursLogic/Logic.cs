using HotToursLogic.Models;

namespace HotToursLogic
{
    public class Logic
    {
        private readonly List<Tour> tours= new();
        public List<Tour> Tours
        {
            get { return tours; }
        }
        public void Add(Tour tour)
        {
            tours.Add(tour);
        }
        public void Edit(Tour tour, int i)
        {
            tours[i] = tour;
        }
        public void Delete(Tour tour)
        {
            tours.Remove(tour);
        }
        public void Strips(string qtytours, string sumtours, string qtydops, string sumdop)
        {
            qtytours = tours.Count.ToString();
            sumtours = tours.Sum(x => x.Sum).ToString();
            qtydops = tours.Count(x => x.Dop != 0).ToString();
            sumdop = tours.Sum(x => x.Dop).ToString();
        }

    }
}
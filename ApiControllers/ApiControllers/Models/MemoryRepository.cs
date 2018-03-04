using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiControllers.Models
{
    public class MemoryRepository : IRepository
    {
        private Dictionary<int, Reservation> items;

        public MemoryRepository()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>()
            {
                new Reservation { ClientName = "Alice", Location = "Board Room" },
                new Reservation { ClientName = "Bob", Location = "Lecture Hall" },
                new Reservation { ClientName = "Joe", Location = "Meeting Room 1" }
            }.ForEach(r => Add(r));
        }

        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation Add(Reservation reservation)
        {
            if(reservation.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; }
                reservation.Id = key;
            }
            items[reservation.Id] = reservation;
            return reservation;
        }

        public void Delete(int id) => items.Remove(id);

        public Reservation Update(Reservation reservation) => Add(reservation);
    }
}

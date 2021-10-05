using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restservice.Models;

namespace Restservice.Managers
{
    public class ItemsManager
    {

        private static int _nextId = 1;
        private static readonly List<Item> Data = new List<Item>
        {
            new Item {Id = _nextId, Name = "Flemming", Quantity = 2},
            new Item {Id = _nextId, Name = "Bente", Quantity = 3},
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<Item> GetAll()
        {
            return new List<Item>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public Item GetById(int id)
        {
            return Data.Find(book => book.Id == id);
        }

        public Item Add(Item newBook)
        {
            newBook.Id = _nextId++;
            Data.Add(newBook);
            return newBook;
        }

        public Item Delete(int id)
        {
            Item item = Data.Find(book1 => book1.Id == id);
            if (item == null) return null;
            Data.Remove(item);
            return item;
        }

        public Item Update(int id, Item updates)
        {
            Item item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Name = updates.Name;
            item.Itemquality = updates.Itemquality;
            return item;
        }
    }
}

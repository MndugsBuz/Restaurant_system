using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system.Entities
{
    public class General<T>
    {
        private List<T> Items { get; set; }

        public General(List<T> items)
        {
            Items = items;
        }

        public void PrintList()
        {
            foreach ( var item in Items )
            Console.WriteLine($"Item list {item.ToString()}");
        }

        public T FindItem (T items)
        {
            return Items.Single(x => x.Equals(items));
        }

        public void AddItem (T item)
        {
            Items.Add(item);
        }

        public void AddList(T items)
        {
            Items.Add(items);
        }

        public void RemoveElementFromList (T items)

        {

            Validation<T>.CheckIfValueNotNull(items);
            var itemToRemove = Items.Single(x => x.Equals(items));
            Items.Remove(itemToRemove);

        }

        public void RemoveElementFromListByIndex(T items)
        {
            Validation<T>.CheckIfValueNotNull(items);
            int index = Items.IndexOf(items);
            Items.RemoveAt(index);
        }

        public bool FindItemExist (T items)
        {
            var result = Items.Where(x => x.Equals(items));
            return result.Any();
        }
    }
}

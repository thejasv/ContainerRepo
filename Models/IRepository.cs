using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dockertraining.Models
{
    public interface IRepository<t>
    {
        public void AddItem(t t);
        public IEnumerable<t> GetItems();
        public t GetItemById(int id);
    }
}

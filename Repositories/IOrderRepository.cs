using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Repositories
{
    internal interface IOrderRepository
    {
        bool Create(Order entity);
        List<Order> ReadAll();
        Order Read(int Id);
        bool Update(Order entity);
        bool Delete(Order entity);
        IEnumerable<Order> GetAll();
    }
}

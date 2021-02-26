using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Domain.Models;
using System.Collections.Generic;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        //TODO: Change all the User domain models with appropriate ViewModel!!!
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        int CreateOrder(Order orderm, int userId);
        int AddProduct(int productId, int orderId, int userId);
        Order GetCurrentOrder(int userId);
        int ChangeStatus(int orderId, int userId, StatusType status);
    }
}

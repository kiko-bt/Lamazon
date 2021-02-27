using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.WebModels.ViewModels;
using System.Collections.Generic;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        //TODO: Change all the User domain models with appropriate ViewModel!!!
        IEnumerable<Order> GetAllOrders();
        OrderViewModel GetOrderById(int id);
        int CreateOrder(OrderViewModel orderm, int userId);
        int AddProduct(int productId, int orderId, int userId);
        OrderViewModel GetCurrentOrder(int userId);
        int ChangeStatus(int orderId, int userId, StatusType status);
    }
}

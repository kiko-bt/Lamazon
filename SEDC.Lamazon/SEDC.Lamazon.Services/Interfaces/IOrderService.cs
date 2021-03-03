using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System.Collections.Generic;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderViewModel> GetAllOrders();
        OrderViewModel GetOrderById(int id, string userId);
        OrderViewModel GetOrderById(int id);
        int CreateOrder(OrderViewModel order, string userId);
        int AddProduct(int orderId, int productId, string userId);
        OrderViewModel GetCurrentOrder(string userId);
        int ChangeStatus(int orderId, string userId, StatusTypeViewModel status);
    }
}
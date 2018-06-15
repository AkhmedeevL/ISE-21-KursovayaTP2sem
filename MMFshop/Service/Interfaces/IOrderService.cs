using Service.BindingModel;
using Service.ViewModel;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IOrderService
    {
        List<OrderViewModel> GetList();

        OrderViewModel GetElement(int id);

        void AddElement(OrderBindingModel model);

        void UpdElement(OrderBindingModel model);

        void DelElement(int id);
    }
}

using Service.BindingModel;
using Service.ViewModel;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IMainService
    {
        List<EntryViewModel> GetList();

        void CreateEntry(EntryBindingModel model);

        void PayEntry(EntryBindingModel model);

        void DelElement(int id);
    }
}

using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.EFCore
{
    public class InventoryRespository : IInventoryRepository
    {
        public Task<IEnumeable<Inventory>> GetInventoriesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
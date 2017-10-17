using PocMultipleEntities.Data;

namespace PocMultipleEntities.Business.Interface
{
    public interface IInventoryDetailsOperations
    {
        dynamic GetDetailsViewModels();
        void SetDb(Databases db);
    }
}
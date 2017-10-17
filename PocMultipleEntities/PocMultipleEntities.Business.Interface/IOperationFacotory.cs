using PocMultipleEntities.Data;

namespace PocMultipleEntities.Business.Interface
{
    public interface IOperationFacotory
    {
        IInventoryDetailsOperations GetInventoryDetailsOperations(Databases db);
        IEnviromentSettingOperations GetEnviromentSettingOperations(Databases db);
    }
}
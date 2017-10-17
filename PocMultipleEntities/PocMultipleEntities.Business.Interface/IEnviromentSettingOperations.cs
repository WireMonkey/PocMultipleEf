using PocMultipleEntities.Data;

namespace PocMultipleEntities.Business.Interface
{
    public interface IEnviromentSettingOperations
    {
        string GetEnviromentSetting(string code);
        void SetDb(Databases db);
    }
}
using System.Collections.Generic;
using System.Linq;
using PocMultipleEntities.Business.Interface;
using PocMultipleEntities.Data;

namespace PocMultipleEntities.Business
{
    public class EnviromentSettingOperations : IEnviromentSettingOperations
    {
        private static Databases database;
        private static IEntities _entities;

        public EnviromentSettingOperations(IEntities entities)
        {
            _entities = entities;
        }

        public void SetDb(Databases db)
        {
            database = db;
        }

        public string GetEnviromentSetting(string code)
        {
            using (var context = _entities.GetDbContext(database))
            {
                return ((IEnumerable<dynamic>) context.EnvironmentSettings).Where(x => x.Code == code)
                    .Select(x => x.Value).FirstOrDefault();
            }
        }
    }
}

using System;
using PocMultipleEntities.Business;
using PocMultipleEntities.Business.Interface;
using PocMultipleEntities.Data;

namespace PocMultipleEntities.Factory
{
    public class OperationFacotory : IOperationFacotory
    {
        private IEntities _entities;

        public OperationFacotory(IEntities entities)
        {
            _entities = entities;
        }

        public IInventoryDetailsOperations GetInventoryDetailsOperations(Databases db)
        {
            IInventoryDetailsOperations ido;
            switch (db)
            {
                case Databases.ABC:
                    ido = new InventoryDetailsOperations(_entities);
                    ido.SetDb(db);
                    break;
                case Databases.Standard:
                    ido = new StandardInventoryDetailsOperations(_entities);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return ido;
        }

        public IEnviromentSettingOperations GetEnviromentSettingOperations(Databases db)
        {
            IEnviromentSettingOperations eso;
            switch (db)
            {
                case Databases.ABC:
                    eso = new EnviromentSettingOperations(_entities);
                    eso.SetDb(db);
                    break;
                case Databases.Standard:
                    eso = new EnviromentSettingOperations(_entities);
                    eso.SetDb(db);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return eso;
        }
    }
}
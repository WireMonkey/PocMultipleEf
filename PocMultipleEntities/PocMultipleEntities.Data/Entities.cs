using System;
using PocMultipleEntities.Data.Abc;
using PocMultipleEntities.Data.Standard;

namespace PocMultipleEntities.Data
{
    public class Entities : IEntities
    {
        public dynamic GetDbContext(Databases db)
        {
            switch (db)
            {
                case Databases.ABC:
                    return new ABCEntities();
                case Databases.Standard:
                    return new TheStandardEntities();
                default:
                    throw new NotImplementedException($"Database: {db.ToString()} not implamented");
            }
        }
    }
}

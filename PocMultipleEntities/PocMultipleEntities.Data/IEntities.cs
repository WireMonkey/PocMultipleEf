namespace PocMultipleEntities.Data
{
    public interface IEntities
    {
        dynamic GetDbContext(Databases db);
    }
}
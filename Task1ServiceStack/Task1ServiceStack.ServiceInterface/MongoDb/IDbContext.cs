namespace Task1ServiceStack.ServiceInterface.MongoDb
{
    using MongoDB.Driver;
    using Task1ServiceStack.ServiceModel.Types;

    public interface IDbContext
    {
        IMongoCollection<Book> GetBooksCollection();
    }
}

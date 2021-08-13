namespace Task1ServiceStack.ServiceInterface.MongoDb
{
    using MongoDB.Driver;
    using Task1ServiceStack.ServiceModel.Types;

    public class DbContext : IDbContext
    {
        private IMongoCollection<Book> _bookCollection;

        public DbContext(IMongoClient client)
        {
            var database = client.GetDatabase("Task1");
            _bookCollection = database.GetCollection<Book>("Books");
        }

        public IMongoCollection<Book> GetBooksCollection() => _bookCollection;
    }
}

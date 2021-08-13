namespace Task1ServiceStack.ServiceInterface
{
    using MongoDB.Driver;
    using ServiceStack;
    using Task1ServiceStack.ServiceInterface.MongoDb;
    using Task1ServiceStack.ServiceModel.Contracts.Books;
    using Task1ServiceStack.ServiceModel.Contracts.BooksCollection;
    using Task1ServiceStack.ServiceModel.Types;

    public class BooksService : Service
    {
        private readonly IDbContext DbContext;
        public BooksService(IDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public object Get(GetBooks request)
        {
            return this.DbContext.GetBooksCollection().Find(b => true).ToList();
        }

        public object Get(GetBook request)
        {
            return this.DbContext.GetBooksCollection().Find(b => b.Id.Equals(request.Id)).First();
        }

        public object Post(CreateBook request)
        {
            var book = new Book()
            {
                Name = request.Name,
                AuthorFullName = request.AuthorFullName,
                IsPublished = request.IsPublished,
                PublicationDate = request.PublicationDate
            };

            this.DbContext.GetBooksCollection().InsertOne(book);

            return book.Id;
        }

        public object Put(UpdateBook request)
        {
            this.DbContext.GetBooksCollection().Find(b => b.Id.Equals(request.Id)).First();

            var book = new Book
            {
                Id = request.Id,
                Name = request.Name,
                AuthorFullName = request.AuthorFullName,
                IsPublished = request.IsPublished,
                PublicationDate = request.PublicationDate
            };

            this.DbContext.GetBooksCollection().ReplaceOne(b => b.Id.Equals(request.Id), book);

            return book.Id;
        }

        public void Delete(DeleteBook request)
        {
            this.DbContext.GetBooksCollection().DeleteOne(book => book.Id.Equals(request.Id));
        }

        public object Get(GetAuthorBooks request)
        {
            return this.DbContext.GetBooksCollection().Find(b => b.AuthorFullName.Equals(request.AuthorName)).ToList();
        }

        public void Post(CreateAuthorIndex request)
        {
            var indexKeys = Builders<Book>.IndexKeys;
            var authorIndex = new CreateIndexModel<Book>(indexKeys.Ascending(b => b.AuthorFullName), new CreateIndexOptions { Name = "AuthorAscengingIndex" });
            this.DbContext.GetBooksCollection().Indexes.CreateOne(authorIndex);
        }

        public void Post(DeleteAuthorIndex request)
        {
            this.DbContext.GetBooksCollection().Indexes.DropOne("AuthorAscengingIndex");
        }
    }
}

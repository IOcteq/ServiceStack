namespace Task1ServiceStack.ServiceModel.Contracts.Books
{
    using System.Collections.Generic;
    using ServiceStack;
    using Task1ServiceStack.ServiceModel.Types;

    [Route("/books/author-books/{authorName}", "GET")]
    public class GetAuthorBooks : IReturn<List<Book>>
    {
        public string AuthorName
        {
            get; set;
        }
    }
}

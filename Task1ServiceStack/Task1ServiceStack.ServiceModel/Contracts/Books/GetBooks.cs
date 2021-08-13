namespace Task1ServiceStack.ServiceModel.Contracts.Books
{
    using System.Collections.Generic;
    using ServiceStack;
    using Task1ServiceStack.ServiceModel.Types;

    [Route("/books", "GET")]
    public class GetBooks : IReturn<List<Book>>
    {
    }
}

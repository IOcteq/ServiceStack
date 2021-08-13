namespace Task1ServiceStack.ServiceModel.Contracts.Books
{
    using ServiceStack;
    using Task1ServiceStack.ServiceModel.Types;

    [Route("/books/{id}", "GET")]
    public class GetBook : IReturn<Book>
    {
        public string Id
        {
            get; set;
        }
    }
}

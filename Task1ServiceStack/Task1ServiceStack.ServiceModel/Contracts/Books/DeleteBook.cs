namespace Task1ServiceStack.ServiceModel.Contracts.Books
{
    using ServiceStack;

    [Route("/books/{id}", "DELETE")]
    public class DeleteBook : IReturnVoid
    {
        public string Id
        {
            get; set;
        }
    }
}

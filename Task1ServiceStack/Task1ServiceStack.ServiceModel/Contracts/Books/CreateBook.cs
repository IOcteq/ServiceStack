namespace Task1ServiceStack.ServiceModel.Contracts.Books
{
    using System;
    using ServiceStack;

    [Route("/books", "POST")]
    public class CreateBook : IReturn<string>
    {
        public string Name
        {
            get; set;
        }

        public string AuthorFullName
        {
            get; set;
        }

        public bool IsPublished
        {
            get; set;
        }

        public DateTime? PublicationDate
        {
            get; set;
        }
    }
}

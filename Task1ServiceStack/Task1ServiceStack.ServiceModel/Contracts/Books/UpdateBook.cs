namespace Task1ServiceStack.ServiceModel.Contracts.Books
{
    using System;
    using ServiceStack;

    [Route("/books/{id}", "PUT")]
    public class UpdateBook : IReturn<string>
    {
        public string Id
        {
            get; set;
        }

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

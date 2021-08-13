namespace Task1ServiceStack.ServiceModel.Types
{
    using System;
    using MongoDB.Bson.Serialization.Attributes;

    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
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

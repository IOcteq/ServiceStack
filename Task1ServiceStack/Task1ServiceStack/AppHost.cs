namespace Task1ServiceStack
{
    using Funq;
    using MongoDB.Driver;
    using ServiceStack;
    using Task1ServiceStack.ServiceInterface;
    using Task1ServiceStack.ServiceInterface.MongoDb;

    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("Task1ServiceStack", typeof(BooksService).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());
            container.AddSingleton<IMongoClient, MongoClient>(s => {
                var uri = "mongodb+srv://Task1User:Task1Password@cluster0.ez4vv.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
                return new MongoClient(uri);
            });

            container.AddScoped<IDbContext, DbContext>();
        }
    }
}

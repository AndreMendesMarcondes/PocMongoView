using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace MongoDBQuery
{
    class Program
    {
        private const string CONNECTION_STRING = "";
        private const string DATABASE_NAME = "";
        private const string COLLECTION_NAME = "";
        private const string FIELD_TO_REMOVE = "";
        private const string VIEW_NAME = "";

        static async Task _Main()
        {
            IMongoClient client = new MongoClient(CONNECTION_STRING);
            IMongoDatabase database = client.GetDatabase(DATABASE_NAME);
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(COLLECTION_NAME);


            PipelineDefinition<BsonDocument, BsonDocument> pipeline = new BsonDocument[]
            {
                //Operadores que podem ser usados na pipeline
                //https://docs.mongodb.com/manual/reference/operator/aggregation/index.html
                new BsonDocument("$project", new BsonDocument()
                        .Add(FIELD_TO_REMOVE, 0.0))
            };


            database.CreateView<BsonDocument, BsonDocument>
                (VIEW_NAME, COLLECTION_NAME, pipeline, null);
         
        }

        static void Main(string[] args)
        {
            _Main().Wait();
        }
    }
}
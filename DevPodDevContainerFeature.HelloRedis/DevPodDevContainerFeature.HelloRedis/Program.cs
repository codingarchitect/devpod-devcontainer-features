using StackExchange.Redis;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
var db = redis.GetDatabase();
db.StringSet("greeting", "Hello from redis!");
Console.WriteLine(db.StringGet("greeting"));

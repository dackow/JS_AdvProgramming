namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            var client = new swaggerClient("https://localhost:44378", new HttpClient());
            var weather = client.SingleforecastAsync(5).Result;
            Console.Out.WriteLine(weather.TemperatureC.ToString());


            client.AddAsync(new User() { Id = 1, Name = "Bob" }).Wait();
            var usersCount = client.UsersAllAsync().Result;
            Console.WriteLine(usersCount.Count);
            
            client.AddAsync(new User() { Id = 2, Name = "John" }).Wait();
            
            usersCount = client.UsersAllAsync().Result;
            Console.WriteLine(usersCount.Count);

        }
    }
}
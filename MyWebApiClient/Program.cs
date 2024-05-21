namespace MyWebApiClient
{
    internal class Program
    {
        private readonly static swaggerClient client = new swaggerClient("https://localhost:7262", new HttpClient());
        static void Main(string[] args)
        {


            
            try
            {
                client.CarsPOSTAsync(new Car() { Model = "Mondeo", Distance = 10_000, ManufaturedYear = 2024 }).Wait();

                var car = client.CarsGETAsync("Focus").Result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
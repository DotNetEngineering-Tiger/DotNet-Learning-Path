namespace WebApplication1.DTO
{
    public class WeatherDataResponse
    {
        public string Day {  get; set; }

        public DateTime? Date { get; set; } = default(DateTime?);

        public string Temp {  get; set; }
    }
}

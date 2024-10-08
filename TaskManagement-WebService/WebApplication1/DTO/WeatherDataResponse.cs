namespace WebApplication1.DTO
{
    public class WeatherDataResponse
    {
        public string day {  get; set; }

        public DateTime? date { get; set; } = default(DateTime?);

        public string Temp {  get; set; }
    }
}

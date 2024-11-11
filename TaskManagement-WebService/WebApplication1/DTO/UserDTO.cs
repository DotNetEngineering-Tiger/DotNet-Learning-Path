namespace WebApplication1.DTO
{
    public class UserDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}

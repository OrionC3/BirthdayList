namespace BirthdayList.API.Entities
{
    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Link { get; set; }
        public Photo? Photo { get; set; }
        public bool InStock { get; set; }

    }
}

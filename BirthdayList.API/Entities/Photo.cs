namespace BirthdayList.API.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int GiftId { get; set; }
        public Gift Gift { get; set; } = null!;
    }
}

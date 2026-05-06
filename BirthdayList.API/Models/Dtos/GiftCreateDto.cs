using BirthdayList.API.Entities;

namespace BirthdayList.API.Models.Dtos
{
    public class GiftCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Link { get; set; }
        public Photo? Photo { get; set; }
    }
}

using BirthdayList.API.Entities;
using BirthdayList.API.Models.Dtos;

namespace BirthdayList.API.Mappers
{
    public static class Giftmapper
    {
        public static Gift ToEntity(this GiftCreateDto dto)
        {
            return new Gift
            {
                Name = dto.Name,
                Description = dto.Description,
                Link = dto.Link,
                Photo = dto.Photo,
                InStock = true,
            };
        }
    }
}

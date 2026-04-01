using API.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Entities;
public class AppUser : IdentityUser
{
    public required string DisplayName { get; set; }
    public string? ImageUrl { get; set; }

    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }

    internal ActionResult<UserDto> ToDto()
    {
        throw new NotImplementedException();
    }

    //Navigation property
    public Member Member { get; set; } = null!;
}



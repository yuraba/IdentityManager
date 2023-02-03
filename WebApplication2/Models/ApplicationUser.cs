using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string Name { get; set; }
}
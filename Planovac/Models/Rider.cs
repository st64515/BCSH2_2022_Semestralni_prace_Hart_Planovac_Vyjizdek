using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Planovac.Models
{
    public class Rider
    {
        public string? FirstName { get; set; } = "Jméno";
        public string? LastName { get; set; } = "Příjmení";
        public string? HasLicense { get; set; } = "ne";
        public string? IsAdult { get; set; } = "ne";
        public string? Description { get; set; } = "";
        
    }
}
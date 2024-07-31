using System.Text.RegularExpressions;

namespace Store;

public class Kaki
{
    public int Id { get; } 

    public string Kakinum { get; }

    public string Authorkak { get; } 

    public string Title { get; }

    public string Description { get; } 

    public decimal Price { get; }

    public Kaki(int id, string kakinum, string authorkak, string title, string description, decimal price)
    { 
        Id = id;
        Kakinum = kakinum;
        Authorkak = authorkak;
        Title = title; 
        Description = description;
        Price = price;
    }

    internal static bool IsKakinum(string s)
    {
        if (s == null)  
            return false;

        s = s.Replace("-", "")
             .Replace(" ", "")
             .ToUpper();

        return Regex.IsMatch(s, @"^KAKINUMBER\d{5}$");
    }
}

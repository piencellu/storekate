using System.Text.RegularExpressions;

namespace Store;

public class Kaki
{
    public int Id { get; } 

    public string Kakinum { get; }

    public string Authorkak { get; } 

    public string Title { get; }

    public Kaki(int id, string kakinum, string authorkak, string title)
    { 
        Id = id;
        Kakinum = kakinum;
        Authorkak = authorkak;
        Title = title; 
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

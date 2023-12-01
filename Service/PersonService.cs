using mpt_lab_11.Entity;

namespace mpt_lab_11.Service;

public static class PersonService
{
    public static IEnumerable<Person> FilterByKeyword(string keyword, IEnumerable<Person> persons)
    {
        return persons.Where(p =>
                p.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.Gender.Contains(keyword, StringComparison.OrdinalIgnoreCase)
        );
    }

    public static IEnumerable<Person> FilterByEmailDomainAndGender(string emailDomain, string gender,
        IEnumerable<Person> persons)
    {
        return persons.Where(p => p.Email.EndsWith("@" + emailDomain) && p.Gender == gender);
    }

    public static int MinEmailLength(IEnumerable<Person> persons)
    {
        return persons.Min(p => p.Email.Length);
    }
    
    public static int MaxEmailLength(IEnumerable<Person> persons)
    {
        return persons.Max(p => p.Email.Length);
    }

    public static double AverageEmailLength(IEnumerable<Person> persons)
    {
        return persons.Average(p => p.Email.Length);
    }
}
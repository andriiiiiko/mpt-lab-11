using mpt_lab_11.Entity;

namespace mpt_lab_11.Service;

/// <summary>
/// Provides utility methods for filtering and analyzing collections of Person objects.
/// </summary>
public static class PersonService
{
    /// <summary>
    /// Filters a collection of persons based on a keyword.
    /// </summary>
    /// <param name="keyword">The keyword to filter by.</param>
    /// <param name="persons">The collection of persons to filter.</param>
    /// <returns>The filtered collection of persons.</returns>
    public static IEnumerable<Person> FilterByKeyword(string keyword, IEnumerable<Person> persons)
    {
        return persons.Where(p =>
                p.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.Gender.Contains(keyword, StringComparison.OrdinalIgnoreCase)
        );
    }

    /// <summary>
    /// Filters a collection of persons based on email domain and gender.
    /// </summary>
    /// <param name="emailDomain">The email domain to filter by.</param>
    /// <param name="gender">The gender to filter by.</param>
    /// <param name="persons">The collection of persons to filter.</param>
    /// <returns>The filtered collection of persons.</returns>
    public static IEnumerable<Person> FilterByEmailDomainAndGender(string emailDomain, string gender,
        IEnumerable<Person> persons)
    {
        return persons.Where(p => p.Email.EndsWith("@" + emailDomain) && p.Gender == gender);
    }

    /// <summary>
    /// Gets the minimum length of email addresses in the collection.
    /// </summary>
    /// <param name="persons">The collection of persons.</param>
    /// <returns>The minimum email length.</returns>
    public static int MinEmailLength(IEnumerable<Person> persons)
    {
        return persons.Min(p => p.Email.Length);
    }
    
    /// <summary>
    /// Gets the maximum length of email addresses in the collection.
    /// </summary>
    /// <param name="persons">The collection of persons.</param>
    /// <returns>The maximum email length.</returns>
    public static int MaxEmailLength(IEnumerable<Person> persons)
    {
        return persons.Max(p => p.Email.Length);
    }

    /// <summary>
    /// Gets the average length of email addresses in the collection.
    /// </summary>
    /// <param name="persons">The collection of persons.</param>
    /// <returns>The average email length.</returns>
    public static double AverageEmailLength(IEnumerable<Person> persons)
    {
        return persons.Average(p => p.Email.Length);
    }
}
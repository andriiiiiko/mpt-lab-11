using System.Text.Json;
using mpt_lab_11.Entity;
using mpt_lab_11.Service;

namespace mpt_lab_11;

public class Program
{
    static void Main()
    { 
        const string filePath = "data/persons.json";
        var jsonContent = File.ReadAllText(filePath);

        var persons = JsonSerializer.Deserialize<IEnumerable<Person>>(jsonContent);

        // 1. Simple Data Filtering
        
        const string keyword = "Rafael";
        var personsFilterByKeyword = PersonService.FilterByKeyword(keyword, persons);
        
        // 2. Composite Filtering with Grouping
        
        const string emailDomain = "java.com";
        const string gender = "Female";
        var personsFilterByEmailDomainAndGender = 
            PersonService.FilterByEmailDomainAndGender(emailDomain, gender, persons);
        
        // 3. Statistical Data Processing
        
        var minEmailLenght = PersonService.MinEmailLength(persons);
        var maxEmailLenght = PersonService.MaxEmailLength(persons);
        var averageEmailLenght = PersonService.AverageEmailLength(persons);
    }
}
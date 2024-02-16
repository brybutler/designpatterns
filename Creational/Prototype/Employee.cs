using Newtonsoft.Json;

namespace GangOf4Patterns.Creational.Prototype;
public class Employee : Person
{
    public Manager Manager { get; set; }
    public override string Name { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public override Person Clone(bool deepCopy = false)
    {
        if (deepCopy)
        {
            //serialize to a string
            var objectAsJson = JsonConvert.SerializeObject(this);
            //deserialize object
            return JsonConvert.DeserializeObject<Employee>(objectAsJson);
        }

        return (Person)MemberwiseClone(); // shallow copy - changes of original will follow through
    }
}


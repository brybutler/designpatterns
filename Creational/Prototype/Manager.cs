using Newtonsoft.Json;

namespace GangOf4Patterns.Creational.Prototype;
public class Manager : Person
{
    public override string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }

    public override Person Clone(bool deepCopy = false)
    {
        if (deepCopy)
        {
            //ICloneable interface is not recommended
            //serialize to a string
            var objectAsJson = JsonConvert.SerializeObject(this);
            //deserialize object
            return JsonConvert.DeserializeObject<Manager>(objectAsJson);
        }
        return (Person)MemberwiseClone(); // shallow copy - changes of original will follow through
    }
}
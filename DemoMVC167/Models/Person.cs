using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMVC167.Model;

[Table("Person")]
public class Person
{
    [key]
    public string PersonID { get; set; }
    public string Fullname { get; set; }
    public string Address { get; set; }


}

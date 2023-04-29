using System.Dynamic;

namespace BlazorApp.Data
{
    public class TitanicClass
    {
        public int Id { get; set; }
        public bool Survived { get; set; }
        public Pclass Pclass { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public int? Age { get; set; }
        public int? SibSp { get; set; }
        public int? Parch { get; set; }
        public string? Ticket { get; set; }
        public int? Fare { get; set; }
        public string? Cabin { get; set; }
        public string? Embarked { get; set; }
    }

    public enum Pclass
    {
        Джек,
        Первый,
        Второй,
        Третий
    }
}

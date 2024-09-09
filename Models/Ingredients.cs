namespace APIOgVueAvslutning.Models
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Coockies> Coockies { get; set; } = new List<Coockies>();
    }
}

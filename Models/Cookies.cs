namespace APIOgVueAvslutning.Models
{
    public class Coockies
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Ingredients> Ingredients { get; set; } = new List<Ingredients>();
    }
}

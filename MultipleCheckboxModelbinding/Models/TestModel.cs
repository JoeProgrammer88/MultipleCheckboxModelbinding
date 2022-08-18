namespace MultipleCheckboxModelbinding.Models
{
    public class TestModel
    {
        public string Title { get; set; } = null!;

        public double Price { get; set; }

        public List<Category> Categories { get; set; } = new();
    }

    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;
    }
}

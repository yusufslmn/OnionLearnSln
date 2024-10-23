using OnionLearn.Domain.Common;


namespace OnionLearn.Domain.Entities;

public class Category : EntityBase
{
    public int ParentId { get; set; }
    public string Name { get; set; }
    public int Priorty { get; set; }
    public ICollection<Detail> Details { get; set; }
    public ICollection<Product> Products { get; set; }
    
}
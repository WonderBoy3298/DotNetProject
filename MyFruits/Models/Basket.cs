namespace MyFruits.Models
{
    public class Basket
    {
        
        public int Id { get; set; }
        public virtual Fruit? Fruit { get; set; }
    }
}

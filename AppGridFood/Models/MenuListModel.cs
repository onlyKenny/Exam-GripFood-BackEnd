namespace AppGridFood.Models
{
    public class MenuListModel
    {
        public string FoodItemId { set; get; } = "";

        public string Name { set; get; } = "";

        public decimal Price { get; set; }

        public int Qty { set; get; }
    }
}

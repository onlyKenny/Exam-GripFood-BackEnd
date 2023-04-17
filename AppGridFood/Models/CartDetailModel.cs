namespace AppGridFood.Models
{
    public class CartDetailModel
    {
        public string CartId { set; get; } = "";

        public string FoodItemId { set; get; } = "";

        public int Qty { set; get; }
    }
}

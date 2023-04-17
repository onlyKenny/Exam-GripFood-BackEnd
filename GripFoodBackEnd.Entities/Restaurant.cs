using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GripFoodBackEnd.Entities
{
    public class Restaurant
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public List<FoodItem> FoodItems { set; get; } = new List<FoodItem>();

        public List<Cart> Carts { set; get; } = new List<Cart>();
    }
}

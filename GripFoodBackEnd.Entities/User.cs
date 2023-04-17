using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GripFoodBackEnd.Entities
{
    public class User
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string Email { set; get; } = "";

        public string Password { set; get; } = "";

        public List<Cart> Carts { set; get; } = new List<Cart>();
    }
}

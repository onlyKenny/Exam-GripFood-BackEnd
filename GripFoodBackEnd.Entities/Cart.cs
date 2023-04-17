﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GripFoodBackEnd.Entities
{
    public class Cart
    {
        public string Id { set; get; } = "";

        public string UserId { set; get; } = "";

        public User User { set; get; } = null!;

        public string RestaurantId { set; get; } = "";

        public Restaurant Restaurant { set; get; } = null!;

        public List<CartDetail> CartDetails { set; get; } = new List<CartDetail>();
    }
}

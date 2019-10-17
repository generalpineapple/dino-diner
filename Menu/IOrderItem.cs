using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    interface IOrderItem
    {
        double Price { get; }

        string Description { get; }

        string[] Special { get; }
    }
}

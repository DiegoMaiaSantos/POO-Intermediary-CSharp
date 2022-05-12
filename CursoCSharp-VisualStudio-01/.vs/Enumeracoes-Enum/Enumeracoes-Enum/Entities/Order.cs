﻿using System;
using Enumeracoes_Enum.Entities.Enums;

namespace Enumeracoes_Enum.Entitiesw
{
    internal class Order
    {
        public int Id { get; set; } 
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}

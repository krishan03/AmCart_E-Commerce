﻿using AmCart.Core.AppServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.OrderModule.AppServices.DTOs
{
    public class TagGroupDTO : DtoBase
    {
        public string Name { get; set; }

        public List<string> Tags { get; set; }
    }
}

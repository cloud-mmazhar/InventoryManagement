﻿using inventory.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory.ViewModel
{
   public class ModifyProductViewModel:ProductsViewModelBase
    {
        public override string Name
        {
            get { return InventoryHelper.ModifyProduct; }
        }

        public override string Icon
        {
            get { return InventoryHelper.ModifyProductIcon; }
        }
    }
}

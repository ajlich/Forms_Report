﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB200199
{
    public class KonekcijaNaBazu
    {
        public static DLWMSDbContext Baza { get; } = new DLWMSDbContext();
    }
}

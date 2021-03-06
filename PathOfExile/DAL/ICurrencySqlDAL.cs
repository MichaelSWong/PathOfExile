﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PathOfExile.Models;

namespace PathOfExile.DAL
{
    public interface ICurrencySqlDAL
    {
        List<CurrencyModel> GetAllCurrency();

        CurrencyModel GetCurrency(string name);
    }
}

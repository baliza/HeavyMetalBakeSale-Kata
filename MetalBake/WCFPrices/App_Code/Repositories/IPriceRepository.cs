using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IPriceRepository
{
    decimal GetItemPrice(string itemId);
}
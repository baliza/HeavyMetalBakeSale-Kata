using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IStockRepository
/// </summary>
public interface IStockRepository
{
    int GetItemStock(string itemId);

    void SetItemStock(string itemId, int value);
}
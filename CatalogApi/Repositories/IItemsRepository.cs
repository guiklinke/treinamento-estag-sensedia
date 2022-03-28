using CatalogApi.Entities;
using System;
using System.Collections.Generic;

namespace CatalogApi.Controllers
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}
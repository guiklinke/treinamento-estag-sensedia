using System;

namespace CatalogApi.Entities { 
    public record Item
{
    public Guid Id { get; set; }

    public string Name { get; init; }

    public string Description { get; init; }

    public decimal Price { get; init; }

    public DateTimeOffset CreatedDate { get; init; }

}


}


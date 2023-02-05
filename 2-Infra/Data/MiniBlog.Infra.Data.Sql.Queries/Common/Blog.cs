﻿namespace MiniPerson.Infra.Data.Sql.Queries.Common;

public partial class Blog
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }

    public ICollection<BlogCategory> BlogCategories { get; set; }
    public ICollection<BlogPhoto> BlogPhotos { get; set; }
}

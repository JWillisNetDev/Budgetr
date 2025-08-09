using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Budgetr.App.Server.Database.Models;

public class Item
{
    [Key]
    public int Id { get; set; }

    [Required, NotNull]
    public string Title { get; set; } = string.Empty;




}

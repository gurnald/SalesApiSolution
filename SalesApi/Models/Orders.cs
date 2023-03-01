using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesApi.Models;

public class Orders {

    public int Id { get; set; }
    public DateTime Date { get; set; }
    [StringLength(40)]
    public string Description { get; set; } = string.Empty;
    [Column(TypeName = "decimal (7,2)")]
    public decimal TotalPrice { get; set; }
    public int? CustomerId { get; set; }  
}

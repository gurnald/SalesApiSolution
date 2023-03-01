﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SalesApi.Models;

[Index("Email", IsUnique = true)]
public class Employee {

    public int Id { get; set; }
    [StringLength(30)]
    public string Email { get; set; } = string.Empty; // must be unique
    [StringLength(30)]
    public string Password { get; set; } = string.Empty;
    [StringLength (50)]
    public string name { get; set; } = string.Empty;
    
}

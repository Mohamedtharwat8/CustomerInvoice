﻿using System.ComponentModel.DataAnnotations;

namespace CustomersManagementSystem.ViewModels;

public class CustomerCreationViewModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    public string Phone { get; set; }
}

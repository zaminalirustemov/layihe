﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace CarRent_CarRentalWebApp.Models;
public class Car
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }


    
    [StringLength(maximumLength: 200)]
    public string Model { get; set; }
    public double PricePerDay { get; set; }
    public double PricePerWeek { get; set; }
    public double PricePerMonth { get; set; }
    public double ConsumptionPer100KM { get; set; }
    public int Millage { get; set; }
    [StringLength(maximumLength: 100)]
    public string Transmission { get; set; }
    public int Seats { get; set; }
    public int Luggage { get; set; }
    [StringLength(maximumLength: 100)]
    public string Fuel { get; set; }
    [StringLength(maximumLength: 555)]
    public string Description { get; set; }
    public bool isFeatured { get; set; }
    public bool isNew { get; set; }
    public bool isDeleted { get; set; }
    public bool isRent { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }


    public Brand? Brand { get; set; }
    public Category? Category { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
    public List<CarPeculiarity>? CarPeculiarities { get; set; }
    public List<CarComment>? CarComments { get; set; }
    public List<CarImage>? CarImages { get; set; }
    [NotMapped]
    public IFormFile? PosterImageFile { get; set; }
    [NotMapped]
    public List<IFormFile>? ImageFiles { get; set; }
    [NotMapped]
    public List<int>? CarImagesIds { get; set; }
    [NotMapped]
    public List<int>? PecularitiesIds { get; set; }

}
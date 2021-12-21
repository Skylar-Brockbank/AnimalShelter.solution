using System;
namespace AnimalShelter.Models
{
    public class Animal
    {
      public int id {get; set;}
      public int AnimalType {get; set;}
      public DateTime EntryDate {get; set;}
      public string Name {get; set;}
      public string Gender{get; set;}
    } 
}
//1. Annotations
using System.ComponentModel.DataAnnotations.Schema; //Column, Attributes
using WorkingWithEFCore; 
//2. 


public class Category{
    public int CategoryId {get; set;}
    public string? CategoryName {get; set;}
    public string? Description {get; set;}

    public virtual ICollection<Product>? Products {get; set;}

    public Category(){
        Products = new HashSet<Product>();
    }
}
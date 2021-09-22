using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovorfayProductCatalogue.Models.ConData
{
  [Table("ProductCategories", Schema = "dbo")]
  public partial class ProductCategory
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryID
    {
      get;
      set;
    }

    public ICollection<Product> Products { get; set; }
    [ConcurrencyCheck]
    public string CategoryName
    {
      get;
      set;
    }
  }
}

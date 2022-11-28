using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain

{

    
    public class Producto
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        public decimal SalePrice { get; set; }
        
        public decimal IGV { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime ExpiryDate { get; set; }
        
       
        
        

    }
    //public Producto prod = new Producto()
    //{

    //    IGV = SalePrice * 0.18
        


    //};
    //public abstract class Calculos
    //{

    //    public Producto prod = new Producto()
    //    {

    //        IGV = 0

    //    };
    //}
    //public abstract decimal Calculo(decimal amount)
    //{
    //    amount = SalePrice * 0.18;
    //    return amount;

    //}





}

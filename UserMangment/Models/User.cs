using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace UserManagement.Models

{
    public class User

    {
        public int Id { get; set; }

        
        [Required]
 public string FirstName { get; set; }


        [Required]
   public string LastName { get; set; }

        [Required]
 public string EmailAddress { get; set; }

        [Required]
        
        [DataType(DataType.Date)]
        public DateTime BrithDate { get; set; }

        
    }
}

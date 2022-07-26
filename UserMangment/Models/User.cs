using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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
        [Display(Name = "BrithDate")]
        [DataType(DataType.Date)]
        public DateTime BrithDate { get; set; }


        public class MovieGenreViewModel
        {
            public List<User> Users { get; set; }
            public SelectList Genres { get; set; }
            public string MovieGenre { get; set; }
            public string SearchString { get; set; }
        }
    }
}

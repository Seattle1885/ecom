using System;
using System.ComponentModel.DataAnnotations;

namespace client.Models
{
    public class LUser 
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage= "Invalid E-mail")]
        public string LEmail {get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage="Invalid Password")]
        public string LPassword {get; set;}
    }
}
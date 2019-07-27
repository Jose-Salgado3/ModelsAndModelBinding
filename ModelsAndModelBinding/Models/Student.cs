using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace ModelsAndModelBinding.Models
{

    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }

        /// <summary>
        /// The legal First and Last name
        /// ex. J.Doe
        /// </summary>
        [Required(ErrorMessage = "Gimme that name!")]
        [Display(Name = "First and Last name")]
        public string FullName { get; set; }

        /// <summary>
        /// The program the student intends to complete
        /// </summary>

        [Required]
        [Display(Name = "Choose Program")]
        public string ProgramOfChoice { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The mailing address of the student that is registering
        /// </summary>
        
        // Max 30 characters for demo
        [StringLength(30, MinimumLength = 5)]
        public string HomeAddress { get; set; }
    }
}

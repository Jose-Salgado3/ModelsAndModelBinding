using System;
using System.Collections.Generic;
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
        public string FullName { get; set; }

        /// <summary>
        /// The program the student intends to complete
        /// </summary>
        public string ProgramOfChoice { get; set; }


        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The mailing address of the student that is registering
        /// </summary>
        public string HomeAddress { get; set; }
    }
}

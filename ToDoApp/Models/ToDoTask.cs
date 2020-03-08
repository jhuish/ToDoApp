using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDoTask
    {
    

        public int Id { get; set; }
        [Required(ErrorMessage =" Field Required"), MaxLength(500)]
        public string ToDoName { get; set; }
        [Required(ErrorMessage = " Field Required"), MaxLength(50)]
        public string ToDoCategory { get; set; }
        [Required(ErrorMessage = " Field Required"), Range(1,3)]
        public int ToDoPriorityLevel { get; set; }


        public string bgColor { get; set; }
    }
}

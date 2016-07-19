using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessGame.Models
{
    public class GuessGameModel
    {
        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name is too short.")]
        [MaxLength(20, ErrorMessage = "Name is too long")]
        public string PlayerName { get; set; }

        [Display(Name = "What is your guess?")]
        [Required(ErrorMessage = "Guess is required")]
        [Range(1, 10, ErrorMessage = "Guess must be between 1 and 100")]
        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }

}
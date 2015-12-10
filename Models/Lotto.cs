//X00098814 Adam McGivern http://ca3cloudservice.cloudapp.net/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebRole1.Models
{
    public class Lotto
    {
        [Required]
        [Range(1, 7, ErrorMessage = "the number of lotto numbers generated must be greater than 1 and less than 7")]
        [Display(Name ="Number of Lotto Numbers")]
        public int numberOfNumbers { get; set; }

        [Required]
        [Range(7, 42, ErrorMessage = "the range of numbers must be greater than the 7, and less than 42")]
        [Display(Name ="Random Generator Range")]
        public int numberRange { get; set; }

        [Display(Name ="Lotto Numbers: ")]
        public List<int> lottoNumbers
        {
            get
            {
                List<int> ListOfNumbers = new List<int>();
                Random myRandom = new Random();
                for (int i = 0; i < numberOfNumbers; i++)
                {
                    int myNumbers = myRandom.Next(0, numberRange);
                    if (ListOfNumbers.Contains(myNumbers) == false) { }
                    else
                    {
                        myNumbers++;
                    }

                    ListOfNumbers.Add(myNumbers);
                }
                ListOfNumbers.Sort();
                return ListOfNumbers;
            }
        }
    }
}
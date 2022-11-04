using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace MVC_From_Scratch.Models
{
    public class Doctor
    {
     
        public static string Diagnose(double temp)
        {
            if (temp == 37)
            {
                return "You are perfectly fine!";
            } 
            else if (temp <= 36 && temp >= 37)
            {
                return " You should get some rest!";
            }
            else if (temp < 30)
            {
                return "You are dead! :D";
            }

            return "No Valid Temperature";
        }
       
    }

}

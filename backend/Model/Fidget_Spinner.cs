using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace fidget_spinner_lab
{
    public class Fidget_Spinner
    {
        [Key]

        public int fidget_id {get;set;}
        public string fidget_name {get;set;}

        public int spokes {get;set;}

        public int bearings {get;set;}

        public string weights {get;set;}

        public string special_feature{get;set;}

        public double price {get;set;}
    }
}
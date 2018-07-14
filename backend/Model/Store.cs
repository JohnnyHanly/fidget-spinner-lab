using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace fidget_spinner_lab
{
    public class Store
    {
        [Key]

        public int store_id {get;set;}
        public string name {get;set;}

        public string phone {get;set;}

     
    }
}
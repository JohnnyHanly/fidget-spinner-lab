using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace fidget_spinner_lab
{
    public class Store_Inventory
    {
        [Key]

        public int inventory_id {get; set;}
        public int store_id { get; set; }

        public int fidget_id { get; set; }

        public int quantity { get; set; }



    }
}
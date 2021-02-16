using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class myTicket
    {        
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Theater { get; set; }
        public string Actors { get; set; }
        public string Seats { get; set; }
        public string Site { get; set; }
        public int Price { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class mtCustomer
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string PWD { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}
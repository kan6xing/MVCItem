﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JinxiaocunApp.Models
{
    public class Tender_PingShen_Item
    {
        public Nullable<int> TaskID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Descs { get; set; }
        public string Atts { get; set; }

        [ForeignKey("TaskID")]
        public Tender_PingShen tenderPingshen { get; set; }
    }
}
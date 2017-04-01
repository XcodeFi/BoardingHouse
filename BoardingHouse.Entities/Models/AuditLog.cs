﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Entities.Models
{
    [Table("AuditLog")]
    public class AuditLog
    {
        public int AuditLogID { get; set; }
        public DateTime? CreatedDate { get; set; }
        [StringLength(256)]
        public string CreatedBy { get; set; }
        public int LogType { get; set; }
        public string Description { get; set; }
        [StringLength(256)]
        public string IPAddress { get; set; }
        [StringLength(256)]
        public string Device { get; set; }
        public string UserID { get; set; }
    }
}
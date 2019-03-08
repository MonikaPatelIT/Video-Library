using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte Discount { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcornsAPI.Models
{
    public partial class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CardID")]
        public int Id { get; set; }
    }
}

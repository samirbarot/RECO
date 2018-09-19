using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RECO.Models
{
    public class DocumentViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Received Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReceivedDate { get; set; }

        public int Pages { get; set; }
    }
}

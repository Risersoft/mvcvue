using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithVue
{
    public class AlbumModel
    {
        public int AlbumId { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Entered { get; set; }
        public string albClass { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string YearReleased { get; set; }
        public string Genre { get; set; }
    }
}

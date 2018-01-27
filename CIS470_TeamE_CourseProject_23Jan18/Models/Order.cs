using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CIS470_TeamE_CourseProject_23Jan18.Models
{
    public class Order
    {
        [Display(Name = "Order ID")]
        public int orderID { get; set; }
        [Display(Name = "Job Type")]
        public string jobType { get; set; }
        [Display(Name = "Media Type")]
        public string mediaType { get; set; }
        [Display(Name = "Media Catalog Number")]
        public int mediaCatalogNumber { get; set; }
        [Display(Name = "Design Request")]
       public string designRequest { get; set; }
        [Display(Name ="Order Status")]
        public string orderStatus { get; set; }
 

 
        [Display(Name = "Inserted Date Time")]

        public DateTime insertedDateTime { get; set; }
        [Display(Name = "Last Updated")]

        public DateTime lastUpdated { get; set; }
        [Display(Name = "Last Updated By")]


        public string lastUpdatedBy { get; set; }



        
    }
}

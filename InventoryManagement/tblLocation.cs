namespace InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLocation")]
    public partial class tblLocation
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string a_location { get; set; }
    }
}

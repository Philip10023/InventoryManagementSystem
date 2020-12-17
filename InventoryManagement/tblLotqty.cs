namespace InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLotqty")]
    public partial class tblLotqty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        public int QTY_Added_Removed { get; set; }

        [Required]
        [StringLength(75)]
        public string Reason_for_change { get; set; }

        [Required]
        [StringLength(3)]
        public string Initials { get; set; }

        [Required]
        [StringLength(128)]
        public string a_location { get; set; }

        [Required]
        [StringLength(128)]
        public string StatusOfitem { get; set; }

        [Required]
        [StringLength(128)]
        public string Purchase_Order { get; set; }

        public int lotID { get; set; }

        public virtual tblLotNum tblLotNum { get; set; }
    }
}

namespace InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLotNum")]
    public partial class tblLotNum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLotNum()
        {
            tblLotqties = new HashSet<tblLotqty>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string lotnum { get; set; }

        [Column(TypeName = "date")]
        public DateTime lotexpdate { get; set; }

        [Required]
        [StringLength(128)]
        public string lotnote { get; set; }

        [Required]
        [StringLength(25)]
        public string lotuam { get; set; }

        public int partID { get; set; }

        [Required]
        [StringLength(75)]
        public string partDesc { get; set; }

        [Column(TypeName = "money")]
        public decimal? partCost { get; set; }

        public bool inventory { get; set; }

        [StringLength(255)]
        public string lotComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLotqty> tblLotqties { get; set; }

        public virtual tblPartNum tblPartNum { get; set; }
    }
}

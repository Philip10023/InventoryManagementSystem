namespace InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPartNum")]
    public partial class tblPartNum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPartNum()
        {
            tblLotNums = new HashSet<tblLotNum>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(35)]
        public string partnum { get; set; }

        [Required]
        [StringLength(55)]
        public string partdesc { get; set; }

        [Required]
        [StringLength(55)]
        public string partnote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLotNum> tblLotNums { get; set; }
    }
}

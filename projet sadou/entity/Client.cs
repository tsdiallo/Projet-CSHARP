namespace projet_sadou.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Commande = new HashSet<Commande>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Nom1 { get; set; }

        [StringLength(50)]
        public string Prenom1 { get; set; }

        [StringLength(50)]
        public string Telephone1 { get; set; }

        [StringLength(50)]
        public string Adresse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commande { get; set; }
    }
}

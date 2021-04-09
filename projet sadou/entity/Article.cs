namespace projet_sadou.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            Commande = new HashSet<Commande>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Reference1 { get; set; }

        [StringLength(50)]
        public string libelle1 { get; set; }

        public float? Stock { get; set; }

        public float? Prix1 { get; set; }

        [StringLength(50)]
        public string Categorie1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commande { get; set; }
    }
}

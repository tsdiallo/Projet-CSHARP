namespace projet_sadou.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande")]
    public partial class Commande
    {
        public int Id { get; set; }

        public float? NumCommande { get; set; }

        public float? QteCommande { get; set; }

        public DateTime? DateCommande { get; set; }

        public int? article_id { get; set; }

        public int? client_id { get; set; }

        public virtual Article Article { get; set; }

        public virtual Client Client { get; set; }
    }
}

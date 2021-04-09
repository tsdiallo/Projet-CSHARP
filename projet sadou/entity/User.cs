namespace projet_sadou.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Login1 { get; set; }

        [StringLength(50)]
        public string Password1 { get; set; }

        [StringLength(50)]
        public string Nom1 { get; set; }

        [StringLength(50)]
        public string Prenom1 { get; set; }

        [StringLength(50)]
        public string Profil1 { get; set; }
    }
}

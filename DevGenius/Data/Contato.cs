namespace DevGenius.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("devgeniusadm.Contato")]
    public partial class Contato
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [Column(TypeName = "text")]
        public string Mensagem { get; set; }

        public DateTime? DtCreated { get; set; }
    }
}

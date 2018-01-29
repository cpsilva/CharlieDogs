using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharlieDogs.DataAccess.Database.Entites
{
    [Table("charlie_dogs.cdogs_cachorros")]
    public partial class CachorrosEntity : BaseEntity
    {
        public CachorrosEntity()
        {
            VendaCachorro = new HashSet<VendaCachorroEntity>();
        }

        [Key]
        [Column("CHR_ID")]
        public int IdCachorro { get; set; }

        [StringLength(255)]
        [Column("CHR_DESCRICAO")]
        public string Descricao { get; set; }

        [Column("CHR_DATA_NASCIMENTO", TypeName = "date")]
        public DateTime? DataNascimento { get; set; }

        [Column("CHR_PESO")]
        public decimal? Peso { get; set; }

        [Column("CHR_PORTE")]
        public int? Porte { get; set; }

        [Column("CHR_COR_PREDOMINANTE")]
        public int? CorPredominante { get; set; }

        [Column("CHR_PRECO")]
        public decimal? Preco { get; set; }

        [Column("CHR_STATUS", TypeName = "bit")]
        public bool? Status { get; set; }

        [Column("CHR_QUANTIDADE")]
        public int? Quantidade { get; set; }

        [Column("RCA_ID")]
        [ForeignKey(nameof(Raca))]
        public int? IdRaca { get; set; }

        [Column("IMG_ID")]
        [ForeignKey(nameof(Imagens))]
        public int? IdImagem { get; set; }

        public virtual ICollection<VendaCachorroEntity> VendaCachorro { get; set; }

        public virtual ImagensEntity Imagens { get; set; }

        public virtual RacaEntity Raca { get; set; }
    }
}
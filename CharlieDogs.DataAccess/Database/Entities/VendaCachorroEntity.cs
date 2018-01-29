using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharlieDogs.DataAccess.Database.Entites
{
    [Table("charlie_dogs.cdogs_venda_cachorro")]
    public partial class VendaCachorroEntity : BaseEntity
    {
        public VendaCachorroEntity()
        {
            Vendas = new HashSet<VendasEntity>();
        }

        [Key]
        [Column("VCH_ID")]
        public int IdVendaCachorro { get; set; }

        [Column("VND_ID")]
        [ForeignKey(nameof(Vendas))]
        public int? IdVenda { get; set; }

        [Column("CHR_ID")]
        [ForeignKey(nameof(Cachorros))]
        public int? IdCachorro { get; set; }

        public virtual CachorrosEntity Cachorros { get; set; }

        public virtual ICollection<VendasEntity> Vendas { get; set; }

        public virtual VendasEntity Venda { get; set; }
    }
}
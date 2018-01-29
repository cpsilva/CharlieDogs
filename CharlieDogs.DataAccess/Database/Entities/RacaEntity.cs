using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharlieDogs.DataAccess.Database.Entites
{
    [Table("charlie_dogs.cdogs_raca")]
    public partial class RacaEntity : BaseEntity
    {
        public RacaEntity()
        {
            Cachorros = new HashSet<CachorrosEntity>();
        }

        [Key]
        [Column("RCA_ID")]
        public int IdRaca { get; set; }

        [StringLength(255)]
        [Column("RCA_DESCRICAO")]
        public string Descricao { get; set; }

        public virtual ICollection<CachorrosEntity> Cachorros { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharlieDogs.DataAccess.Database.Entites
{
    [Table("charlie_dogs.cdogs_imagens")]
    public partial class ImagensEntity : BaseEntity
    {
        public ImagensEntity()
        {
            Cachorros = new HashSet<CachorrosEntity>();
        }

        [Key]
        [Column("IMG_ID")]
        public int IdImagem { get; set; }

        [Column("IMG_IMAGEM")]
        public string Imagem { get; set; }

        public virtual ICollection<CachorrosEntity> Cachorros { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharlieDogs.DataAccess.Database.Entites
{
    [Table("charlie_dogs.cdogs_clientes")]
    public partial class ClientesEntity : BaseEntity
    {
        public ClientesEntity()
        {
            Vendas = new HashSet<VendasEntity>();
        }

        [Key]
        [Column("CLI_ID")]
        public int IdCliente { get; set; }

        [StringLength(100)]
        [Column("CLI_NOME")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Column("CLI_EMAIL")]
        public string Email { get; set; }

        [StringLength(11)]
        [Column("CLI_CPF")]
        public string Cpf { get; set; }

        public virtual ICollection<VendasEntity> Vendas { get; set; }
    }
}
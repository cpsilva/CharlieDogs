using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharlieDogs.DataAccess.Database.Entites
{
    [Table("charlie_dogs.cdogs_vendas")]
    public partial class VendasEntity : BaseEntity
    {
        public VendasEntity()
        {
            VendaCachorros = new HashSet<VendaCachorroEntity>();
        }

        [Key]
        [Column("VND_ID")]
        public int IdVenda { get; set; }

        [Column("VND_STATUS", TypeName = "bit")]
        public bool? Status { get; set; }

        [StringLength(100)]
        [Column("VND_ENDERECO")]
        public string Endereco { get; set; }

        [StringLength(10)]
        [Column("VND_NUMERO")]
        public string Numero { get; set; }

        [StringLength(255)]
        [Column("VND_COMPLEMENTO")]
        public string Complemento { get; set; }

        [StringLength(150)]
        [Column("VND_BAIRRO")]
        public string Bairro { get; set; }

        [StringLength(8)]
        [Column("VND_CEP")]
        public string Cep { get; set; }

        [StringLength(16)]
        [Column("VND_NUMERO_CARTAO")]
        public string NumeroCartao { get; set; }

        [StringLength(3)]
        [Column("VND_CVV")]
        public string Cvv { get; set; }

        [StringLength(2)]
        [Column("VND_MES_EXPIRACAO")]
        public string MesExpiracao { get; set; }

        [StringLength(4)]
        [Column("VND_ANO_EXPIRACAO")]
        public string AnoExpiracao { get; set; }

        [StringLength(100)]
        [Column("VND_NOME_CARTAO")]
        public string NomeCartao { get; set; }

        [Column("VND_TOTAL")]
        public decimal? Total { get; set; }

        [Column("VCH_ID")]
        [ForeignKey(nameof(VendaCachorro))]
        public int? IdVendaCachorro { get; set; }

        [Column("CLI_ID")]
        [ForeignKey(nameof(Clientes))]
        public int? IdCliente { get; set; }

        public virtual ClientesEntity Clientes { get; set; }

        public virtual VendaCachorroEntity VendaCachorro { get; set; }

        public virtual ICollection<VendaCachorroEntity> VendaCachorros { get; set; }
    }
}
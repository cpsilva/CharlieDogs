﻿using System;

namespace CharlieDogs.Domain.ViewModel
{
    public class CaesVM
    {
       
        public int IdCachorro { get; set; }

        public string Descricao { get; set; }

        public DateTime? DataNascimento { get; set; }

        public decimal? Peso { get; set; }

        public int? Porte { get; set; }

        public int? CorPredominante { get; set; }

        public decimal? Preco { get; set; }

        public bool? Status { get; set; }

        public int? Quantidade { get; set; }

        public string RacaDescricao { get; set; }

        public string Imagem { get; set; }
    }
}
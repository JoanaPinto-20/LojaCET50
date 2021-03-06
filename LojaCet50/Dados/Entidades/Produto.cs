﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace LojaCet50.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

       [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = false)]

        public decimal Preco { get; set; }

        [Display (Name ="Image")]
        public string UrlDaImagem { get; set; }

        [Display (Name = "Última compra")]
        public DateTime UltimaCompra { get; set; }

        [Display (Name = "Última Venda")]
        public DateTime UltimaVenda { get; set; }


        public bool Disponível { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }



    }
}

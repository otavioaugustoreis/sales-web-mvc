﻿using SalesWebMVC.Patterns;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SalesWebMVC._3___Data.Entity
{

    [DebuggerDisplay("{DsNome}")]
    [Table("TB_PRODUCT")]
    public class ProductEntity : EntityPattern
    {
        [DisplayName("Nome")]
        [Column("DS_NOME")]
        public string DsNome { get; set; }

        [DisplayName("Quantidade")]
        [Column("NR_QUANTIDADE")]
        public int Quantity { get; set; }

        public List<SalesProductEntity> SalesProductsList { get; set; } = new();

        public ProductEntity(int id, string dsNome, int quantity)
            : base(id)
        {
            DsNome = dsNome;
            Quantity = quantity;
        }

        public ProductEntity() : base() { }

        public void AdicionarSalesProduts(SalesProductEntity salesProductEntity)
        {
            SalesProductsList.Add(salesProductEntity);
        }
    }   
}
    
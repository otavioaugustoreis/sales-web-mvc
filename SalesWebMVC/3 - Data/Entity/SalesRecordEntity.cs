﻿using SalesWebMVC._3___Data.Entity;
using SalesWebMVC.Data.Enums;
using SalesWebMVC.Patterns;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SalesWebMVC.Data.Entity
{
    //Vendas feitas pelo vendedor
    [Table("TB_SALESRECORD")]
    public class SalesRecordEntity : EntityPattern
    {
        [JsonIgnore]
        public SaleStatus SaleStatus { get; set; }

        [DisplayName("Valor")]
        [Column("ds_valor")]
        public double Valor { get; set; }

        [Column("fk_seller")]
        public int FkSeller { get; set; }
        public SellerEntity Seller { get; set; }


        public List<SalesProductEntity> SalesProductsList { get; set; } = new();

        public SalesRecordEntity() 
            : base()
        { 
        }

        public SalesRecordEntity(int id, SaleStatus saleStatus, double valor , SellerEntity seller) : base(id)
        {
            SaleStatus = saleStatus;
            Valor = valor;
            Seller = seller;
        }

        public void AdicionarSalesProduts(SalesProductEntity salesProductEntity)
        {
            SalesProductsList.Add(salesProductEntity);
        }
    }
}

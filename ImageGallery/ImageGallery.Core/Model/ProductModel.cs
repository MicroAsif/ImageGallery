﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ImageGallery.Core.Model
{
    [Table("Products")]
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialPriceStartDate { get; set; }
        public DateTime? SpecialPriceEndDate { get; set; }

        public int StockQuantity { get; set; }
        public int MinimumStockQuantity { get; set; }
        public int NotifyForQuantityBelow { get; set; }
        public bool DisplayAvailability { get; set; }
        public int MinimumCartQuantity { get; set; }
        public int MaximumCartQuantity { get; set; }

        public string SeoUrl { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public bool Published { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<ProductImageMappingModel> Images { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class ProductResponseDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public double Price { get; init; }
        public string GroupName { get; init; }
        //public string Image { get; init; }
        //public bool IsActive { get; init; }
        //public int? GroupId { get; init; }
        //public ProductGroupResponseDTO? Group { get; init; }
        //public List<BasketPositionResponseDTO>? BasketPositions { get; init; }
    }
}

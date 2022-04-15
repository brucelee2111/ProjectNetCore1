﻿using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Catalog.Products.Dtos.Magane
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
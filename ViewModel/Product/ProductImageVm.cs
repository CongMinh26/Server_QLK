using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Product
{
    public class ProductImageVm
    {
        public int id { get; set; }
        public string caption { get; set; }
        public string fileSize { get; set; }
        public string pathImage { get; set; }
        public int sortOrder { get; set; }
    }
}

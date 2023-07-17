using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.ViewModels.Fiscal
{
    public class ICMS00 : ICMSBase
    {
        public string modBC { get; set; } = default!;
        public decimal vBC { get; set; } = default!;
        public string pICMS { get; set; } = default!;
        public decimal vICMS { get; set; } = default!;
        public decimal vFCP { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.ViewModels.Fiscal
{
    public class emit
    {
        public string CNPJ { get; set; } = default!;
        public string xNome { get; set; } = default!;
        public enderEmit enderEmit { get; set; } = default!;
        public string IE { get; set; } = default!;
        public string IEST { get; set; } = default!;   
        public int CRT { get; set; } 

    }
}

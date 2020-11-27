using System.Collections.Generic;
using System.Linq;
using BlueModasWeb.UI.Web.Models;

namespace BlueModasWeb.UI.Web.ViewModel
{
    public class CarrinhoViewModel
    {
        public decimal ValorTotal => CarrinhoItens.Sum(x => x.ValorUnitario);

        public IEnumerable<Produto> CarrinhoItens { get; set; }
    }
}

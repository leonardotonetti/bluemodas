using System.Collections.Generic;
using System.Linq;

namespace BlueModasWeb.UI.Web.ViewModel.Carrinho
{
    public class CarrinhoViewModel
    {
        public decimal ValorTotal => CarrinhoItens.Sum(x => x.QuantidadeItem * x.Produto.ValorUnitario);

        public IEnumerable<CarrinhoItemViewModel> CarrinhoItens { get; set; }
    }
}

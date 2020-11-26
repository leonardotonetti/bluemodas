using System.Collections.Generic;

namespace BlueModasWeb.UI.Web.Models
{
    public class TipoPublicoAlvo
    {
        public int TipoPublicoAlvoId { get; set; }
        public string Nome { get; set; }

        public IEnumerable<TipoPublicoAlvoCategoria> TipoPublicoAlvoCategoria { get; set; }
    }
}

using System.Collections.Generic;

namespace BlueModasApi.Business.Dto
{
    public class TipoPublicoAlvoDto
    {
        public int TipoPublicoAlvoId { get; set; }
        public string Nome { get; set; }

        public IEnumerable<TipoPublicoAlvoCategoriaDto> TipoPublicoAlvoCategoria { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Dto
{
    public class ClienteDto
    {
        [Required(ErrorMessage = "O preenchimento do nome do cliente é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do cliente pode ter um tamanho de no máximo cem caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O preenchimento do sobrenome do cliente é obrigatório")]
        [MaxLength(100, ErrorMessage = "O sobrenome do cliente pode ter um tamanho de no máximo cem caracteres")]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "O preenchimento do email do cliente é obrigatório")]
        [MaxLength(100, ErrorMessage = "O email do cliente pode ter um tamanho de no máximo cem caracteres")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "O email do cliente está inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O preenchimento do telefone do cliente é obrigatório")]
        [MaxLength(100, ErrorMessage = "O telefone do cliente pode ter um tamanho de no máximo cem caracteres")]
        [RegularExpression(@"\(\d{2}\)\s\d{4,5}\-\d{4}", ErrorMessage = "O telefone do cliente está inválido")]
        public string Telefone { get; set; }
    }
}

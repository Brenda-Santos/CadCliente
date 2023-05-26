using System.ComponentModel.DataAnnotations;

namespace EmpresaWeb.Models
    
{
    public class ClienteViewModel
    {
        [Display(Name = "Codigo")]
        public int ClienteId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preenchimento Obrigatório.")]
        [DataType(DataType.Text, ErrorMessage = "O campo NOME está vazio.")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Preenchimento Obrigatório.")]
        [DataType(DataType.Text, ErrorMessage = "O campo CPF está vazio.")]
        public string CPF { get; set; }

        [Display(Name = "Idade")]
        [Required(ErrorMessage = "Preenchimento Obrigatório.")]
        public int Idade { get; set; }

        public ClienteViewModel() 
        {
            ClienteId = 0;
        }
    }
}

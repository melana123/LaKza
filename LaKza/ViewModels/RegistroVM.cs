using System.ComponentModel.DataAnnotations;
using Mysqlx;

namespace LaKza.ViewModels;

    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt ="Informe seu Nome Completo")]
        [Required(ErrorMessage ="Informe seu nome")]
        [StringLength(60, ErrorMessage =" O nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set;} = null;
    }

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaKza.Models;

    [Table("categoria")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Por favor, informe o Nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public int Nome { get; set; }

        [StringLength(300)]
        public int Foto { get; set; }
    }

using System.ComponentModel.DataAnnotations;

namespace TelaInicialCrud.Models
{
    public class Projeto
    {
        [Key]
        public int IdProjeto { get; set; }

        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        [MaxLength(200)]
        public string DataInicio { get; set; }

      
        [MaxLength(200)]
        public string DataFinal { get; set; }

        public int QuantPessoas { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrilhaNetAzureDesafio.Models
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }

        [StringLength(20)]
        public string Ramal { get; set; }

        [EmailAddress]
        public string EmailProfissional { get; set; }

        [StringLength(100)]
        public string Departamento { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }

        public DateTimeOffset? DataAdmissao { get; set; }

        public Funcionario() { }

        public Funcionario(int id, string nome, string endereco, string ramal, string emailProfissional, string departamento, decimal salario, DateTime dataAdmissao)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Ramal = ramal;
            EmailProfissional = emailProfissional;
            Departamento = departamento;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }
    }
}
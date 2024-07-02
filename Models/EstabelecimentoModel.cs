using System.ComponentModel.DataAnnotations;

namespace EstabelecimentoMaggi.Models
{
    public class EstabelecimentoModel
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Categoria { get; set; }
        public string Status { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
    }
}

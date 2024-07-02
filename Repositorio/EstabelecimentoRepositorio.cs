using EstabelecimentoMaggi.Data;
using EstabelecimentoMaggi.Models;

namespace EstabelecimentoMaggi.Repositorio
{
    public class EstabelecimentoRepositorio : iEstabelecimentoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public EstabelecimentoRepositorio(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }

        public List<EstabelecimentoModel> BuscarTodos()
        {
            return _bancoContext.Estabelecimentos.ToList();
        }

        public EstabelecimentoModel BuscarPorId(int id)
        {
            return _bancoContext.Estabelecimentos.FirstOrDefault(x => x.Id == id);
        }

        public EstabelecimentoModel Adicionar(EstabelecimentoModel estabelecimento)
        {
            //Gravar no Banco de Dados
            _bancoContext.Estabelecimentos.Add(estabelecimento);
            _bancoContext.SaveChanges();

            return estabelecimento;
        }

        public EstabelecimentoModel Atualizar(EstabelecimentoModel estabelecimento)
        {
            EstabelecimentoModel estabelecimentoDB = BuscarPorId(estabelecimento.Id);

            if (estabelecimentoDB == null) throw new System.Exception("Houve um erro na atualização do estabelecimento!");
            estabelecimentoDB.RazaoSocial = estabelecimento.RazaoSocial;
            estabelecimentoDB.Nome = estabelecimento.Nome;
            estabelecimentoDB.Cnpj = estabelecimento.Cnpj;
            estabelecimentoDB.Email = estabelecimento.Email;
            estabelecimentoDB.Endereco = estabelecimento.Endereco;
            estabelecimentoDB.Cidade = estabelecimento.Cidade;
            estabelecimentoDB.Estado = estabelecimento.Estado;
            estabelecimentoDB.Telefone = estabelecimento.Telefone;
            estabelecimentoDB.Data_Cadastro = estabelecimento.Data_Cadastro;
            estabelecimentoDB.Categoria = estabelecimento.Categoria;
            estabelecimentoDB.Status = estabelecimento.Status;
            estabelecimentoDB.Agencia = estabelecimento.Agencia;
            estabelecimentoDB.Conta = estabelecimento.Conta;

            _bancoContext.Estabelecimentos.Update(estabelecimentoDB);
            _bancoContext.SaveChanges();

            return estabelecimentoDB;
        }

        public bool Apagar(int id)
        {
            EstabelecimentoModel estabelecimentoDB = BuscarPorId(id);

            if (estabelecimentoDB == null) throw new System.Exception("Houve um erro na deleção do estabelecimento!");

            _bancoContext.Estabelecimentos.Remove(estabelecimentoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}

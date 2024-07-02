using EstabelecimentoMaggi.Models;
namespace EstabelecimentoMaggi.Repositorio
{
    public interface iEstabelecimentoRepositorio
    {
        EstabelecimentoModel BuscarPorId(int id);
        List<EstabelecimentoModel> BuscarTodos();
        EstabelecimentoModel Adicionar(EstabelecimentoModel estabelecimento);
        EstabelecimentoModel Atualizar(EstabelecimentoModel estabelecimento);
        bool Apagar(int id);
    }
}

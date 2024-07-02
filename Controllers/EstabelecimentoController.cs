using EstabelecimentoMaggi.Models;
using EstabelecimentoMaggi.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace EstabelecimentoMaggi.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private readonly iEstabelecimentoRepositorio _estabelecimentoRepositorio;
        public EstabelecimentoController(iEstabelecimentoRepositorio estabelecimentoRepositorio) 
        { 
            _estabelecimentoRepositorio = estabelecimentoRepositorio;
        }


        public IActionResult Index()
        {
            List<EstabelecimentoModel> estabelecimentos = _estabelecimentoRepositorio.BuscarTodos();
            return View(estabelecimentos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            EstabelecimentoModel estabelecimento = _estabelecimentoRepositorio.BuscarPorId(id);
            return View(estabelecimento);
        }
        public IActionResult ApagarConfirmar(int id)
        {
            EstabelecimentoModel estabelecimento = _estabelecimentoRepositorio.BuscarPorId(id);
            return View(estabelecimento);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool apagado = _estabelecimentoRepositorio.Apagar(id);

                    if (apagado)
                    {
                        TempData["MensagemSucesso"] = "Estabelecimento deletado com sucesso!";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops, não conseguimos deletar seu estabelecimento!";
                    }
                    return RedirectToAction("Index");

                }
                return View();
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos deletar seu estabelecimento, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Criar(EstabelecimentoModel estabelecimento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _estabelecimentoRepositorio.Adicionar(estabelecimento);
                    TempData["MensagemSucesso"] = "Estabelecimento cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(estabelecimento);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu estabelecimento, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Alterar(EstabelecimentoModel estabelecimento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _estabelecimentoRepositorio.Atualizar(estabelecimento);
                    TempData["MensagemSucesso"] = "Estabelecimento editado com sucesso!";
                    return RedirectToAction("Index");
                    
                }
                return View("Editar", estabelecimento);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos editar seu estabelecimento, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}

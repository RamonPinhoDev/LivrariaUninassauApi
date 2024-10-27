using LivrariaUninassau.Models;
using LivrariaUninassau.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaUninassau.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Livraria : ControllerBase
    {
        private readonly IEmprestimoRepositorio _emprestimoRepositorio;
        public Livraria(IEmprestimoRepositorio emprestimoRepositorio)
        {
            _emprestimoRepositorio = emprestimoRepositorio;

        }

        [HttpGet("BuscarTodosCampos")]
        public async Task<ActionResult<List<Livraria>>> BuscarTodosCampos()
        {
            List<EmprestimoModel> emprestimos = await _emprestimoRepositorio.BuscarTodosEmprestimos();
            return Ok(emprestimos);
        }

        [HttpGet("BuscarPorId")]
        public async Task<ActionResult<Livraria>> BuscarPorId(int id)
        {
            Console.Write(id);
            EmprestimoModel emprestimo = await _emprestimoRepositorio.BuscarPorId(id);
            return Ok(emprestimo);
        }

        [HttpGet("buscarPorTitulo")]
        public async Task<ActionResult<List<EmprestimoModel>>> BuscarPorTitulo(string titulo)
        {
            List<EmprestimoModel> emprestimos = await _emprestimoRepositorio.BuscarPorTitulo(titulo);
            return Ok(emprestimos);
        }

        [HttpGet("buscarPorAutor")]
        public async Task<ActionResult<List<EmprestimoModel>>> BuscarPorAutor(string autor)
        {
            List<EmprestimoModel> emprestimos = await _emprestimoRepositorio.BuscarPorAutor(autor);
            return Ok(emprestimos);
        }


        [HttpPost("Post")]
        public async Task<ActionResult<EmprestimoModel>> Cadastrar([FromBody] EmprestimoModel emprestimoModel)
        {


            EmprestimoModel emprestimo = await _emprestimoRepositorio.Adicionar(emprestimoModel);

            return Ok(emprestimo);
        }

        [HttpPut("Atualizar")]
        public async Task<ActionResult<EmprestimoModel>> Atualizar([FromBody] EmprestimoModel emprestimoModel, int id)
        {
            emprestimoModel.Id = id;
            EmprestimoModel emprestimo = await _emprestimoRepositorio.Atualizar(emprestimoModel, id);

            return Ok(emprestimo);
        }

        [HttpDelete("Apagar")]
        public async Task<ActionResult<EmprestimoModel>> Apagar(int id)
        {

            bool apagado = await _emprestimoRepositorio.Apagar(id);

            return Ok(apagado);
        }
    }
}

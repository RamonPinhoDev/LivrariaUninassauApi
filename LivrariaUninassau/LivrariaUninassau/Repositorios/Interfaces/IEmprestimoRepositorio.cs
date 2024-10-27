using LivrariaUninassau.Models;

namespace LivrariaUninassau.Repositorios.Interfaces
{
    public interface IEmprestimoRepositorio
    {
        Task<List<EmprestimoModel>> BuscarTodosEmprestimos();
        Task<EmprestimoModel> BuscarPorId(int id);
        Task<List<EmprestimoModel>> BuscarPorTitulo(string titulo);
        Task<List<EmprestimoModel>> BuscarPorAutor(string autor);
        Task<EmprestimoModel> Adicionar(EmprestimoModel emprestimo);
        Task<EmprestimoModel> Atualizar(EmprestimoModel emprestimo, int id);
        Task<bool> Apagar(int id);
        
}
}


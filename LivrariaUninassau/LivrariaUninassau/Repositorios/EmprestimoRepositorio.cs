using LivrariaUninassau.Data;
using LivrariaUninassau.Models;
using LivrariaUninassau.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LivrariaUninassau.Repositorios
{
    public class EmprestimoRepositorio : IEmprestimoRepositorio
    {
        private readonly LivrariaDBContext _dbContext;
        public EmprestimoRepositorio(LivrariaDBContext LivrariaDBContext)
        {
            _dbContext = LivrariaDBContext;
        }
        public async Task<EmprestimoModel> BuscarPorId(int id)
        {
            return await _dbContext.Emprestimo.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<EmprestimoModel>> BuscarPorTitulo(string titulo)
        {
            return await _dbContext.Emprestimo.Where(x => x.Titulo.Contains(titulo)).ToListAsync();
        }

        public async Task<List<EmprestimoModel>> BuscarPorAutor(string autor)
        {
            return await _dbContext.Emprestimo.Where(x => x.Autor.Contains(autor)).ToListAsync();
        }

        public async Task<List<EmprestimoModel>> BuscarTodosEmprestimos()
        {
            return await _dbContext.Emprestimo.ToListAsync();
        }

        public async Task<EmprestimoModel> Adicionar(EmprestimoModel emprestimo)
        {
            await _dbContext.Emprestimo.AddAsync(emprestimo);
            await _dbContext.SaveChangesAsync();
            return emprestimo;
        }

        public async Task<EmprestimoModel> Atualizar(EmprestimoModel emprestimo, int id)
        {
            EmprestimoModel EmprestimoPorId = await BuscarPorId(id);

            if (EmprestimoPorId == null)
            {
                throw new Exception($"Emprestimo para o ID: {id} não encontrado");
            }
            EmprestimoPorId.Titulo = emprestimo.Titulo;
            EmprestimoPorId.Autor = emprestimo.Autor;
            EmprestimoPorId.Editora = emprestimo.Editora;
            EmprestimoPorId.Idioma = emprestimo.Idioma;
            EmprestimoPorId.Genero = emprestimo.Genero;
            EmprestimoPorId.NumeroDePaginas = emprestimo.NumeroDePaginas;
            EmprestimoPorId.ISBN = emprestimo.ISBN;
            EmprestimoPorId.Quantidade = emprestimo.Quantidade;
            EmprestimoPorId.dataPublicação = emprestimo.dataPublicação;
            EmprestimoPorId.dataUltimaAtualizacao = emprestimo.dataUltimaAtualizacao;

            _dbContext.Emprestimo.Update(EmprestimoPorId);
            await _dbContext.SaveChangesAsync();
            return EmprestimoPorId;
        }
        public async Task<bool> Apagar(int id)
        {
            EmprestimoModel EmprestimoPorId = await BuscarPorId(id);

            if (EmprestimoPorId == null)
            {
                throw new Exception($"Emprestimo para o ID: {id} não encontrado");
            }
            _dbContext.Emprestimo.Remove(EmprestimoPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }




    }
}

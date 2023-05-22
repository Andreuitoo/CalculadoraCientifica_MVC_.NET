using CalculadoraCientifica.Models;

namespace CalculadoraCientifica.Repositories
{
    public interface InterfazCalculadoraRepositorio
    {
        IEnumerable<Calculadora> GetAll();

        void CrearCalculadora(Calculadora calculadora);
    }
}

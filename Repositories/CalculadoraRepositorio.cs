using CalculadoraCientifica.Data;
using CalculadoraCientifica.Models;

namespace CalculadoraCientifica.Repositories
{
    public class CalculadoraRepositorio : InterfazCalculadoraRepositorio
    {
        private CalculadoraContext context;

        public CalculadoraRepositorio(CalculadoraContext context)
        {
            this.context = context;
        }

        public IEnumerable<Calculadora> GetAll()
        {
            return context.Calculos.ToList();
        }

        public void CrearCalculadora(Calculadora calculadora)
        {
            context.Add(calculadora);
            context.SaveChanges();
        }
    }
}

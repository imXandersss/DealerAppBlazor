using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
    public interface ICarroService
    {
        Task<IEnumerable<Carro>> getAllCarros();
        Task<Carro> getDetails(int id);

        Task<bool> deleteCarro(int id);

        Task<bool> saveCarro(Carro carro);
    }
}

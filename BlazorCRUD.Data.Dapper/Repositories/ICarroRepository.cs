using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public interface ICarroRepository
    {
        Task<IEnumerable<Carro>> getAllCarros();

        Task<Carro> getCarroDetails(int id);

        Task<bool> insertCarro(Carro carro);

        Task<bool> updateCarro(Carro carro);

        Task<bool> deleteCarro(int id);

    }
}

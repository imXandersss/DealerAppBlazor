using BlazorCRUD.Data.Dapper.Repositories;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Services
{
    public class CarroServices : ICarroService
    {
        private readonly SqlConfiguration _configuration;
        private ICarroRepository _carroRepository;


        public CarroServices(SqlConfiguration configuration) 
        {
            _configuration = configuration;
            _carroRepository = new CarroRepository(configuration.ConnectionString);
        }

        public Task<bool> deleteCarro(int id)
        {
            return _carroRepository.deleteCarro(id);
        }

        public Task<IEnumerable<Carro>> getAllCarros()
        {
            return _carroRepository.getAllCarros();
        }

        public Task<Carro> getDetails(int id)
        {
            return _carroRepository.getCarroDetails(id);
        }

        public  Task<bool> saveCarro(Carro carro)
        {
            if (carro.Id==0)
                return  _carroRepository.insertCarro(carro);
            else
                return _carroRepository.updateCarro(carro);
            
               
        }
    }
}

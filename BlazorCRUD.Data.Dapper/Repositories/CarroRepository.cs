using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private string ConnectionString;

        public CarroRepository(string connectionString) {
            ConnectionString = connectionString;
        }


        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }



        public async Task<bool> deleteCarro(int id)
        {
            var db = dbConnection();
            var sql = @"DELETE FROM RazorCRUD WHERE id=@id";
            var result =await db.ExecuteAsync(sql.ToString(), new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<Carro>> getAllCarros()
        {
            var db = dbConnection();
            var sql = @"SELECT id, marca, modelo, color, ano, comentario, foto, chasis FROM RazorCRUD";
            return await db.QueryAsync<Carro>(sql.ToString(),new { });
        }

        public async Task<Carro> getCarroDetails(int Id)
        {
            var db = dbConnection();
            var sql = @"SELECT id, marca, modelo, color, ano, comentario, foto, chasis FROM [dbo].[RazorCRUD] WHERE id = @Id";
            return await db.QueryFirstOrDefaultAsync<Carro>(sql.ToString(), new {Id=Id});
        }

        public async Task<bool> insertCarro(Carro carro)
        {
            
            var db = dbConnection();

            var sql = @" INSERT INTO RazorCRUD ( marca, modelo, color, ano, comentario, foto, chasis) VALUES (@marca, @modelo, @color, @ano, @comentario, @foto, @chasis)";

            
            var result = await db.ExecuteAsync(sql.ToString(), new { carro.Marca, carro.Modelo, carro.Chasis, carro.ano, carro.color, carro.comentario, carro.foto });

            return result > 0;
        }

        public async Task<bool> updateCarro(Carro carro)
        {
            var db = dbConnection();
            var sql = @" UPDATE RazorCRUD 
                         SET marca = @marca,
                             chasis = @Chasis,
                             modelo=@modelo, 
                             color=@color, 
                             ano=@ano, 
                             comentario=@comentario, 
                             foto=@foto
                         WHERE id = @Id ";

            var result = await db.ExecuteAsync(sql.ToString(), new { carro.Id, carro.Marca, carro.Modelo,carro.Chasis, carro.ano, carro.color, carro.comentario, carro.foto});
         
            return result > 0;
        } 
    }
}

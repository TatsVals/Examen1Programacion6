using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Entity;

namespace WBL
{
    public interface IVehiculoService
    {
        Task<DBEntity> Create(VehiculoEntity entity);
        Task<VehiculoEntity> Delete(VehiculoEntity entity);
        Task<IEnumerable<VehiculoEntity>> Get();
        Task<VehiculoEntity> GetbyId(VehiculoEntity entity);
        Task<DBEntity> Update(VehiculoEntity entity);
    }

    public class VehiculoService : IVehiculoService
    {
        private readonly IDataAccess sql;

        public VehiculoService(IDataAccess _sql)
        {
            sql = _sql;
        }
        #region MetodosCRUD

        // Metodo Get

        public async Task<IEnumerable<VehiculoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<VehiculoEntity>("dbo.VehiculoObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo GetById
        public async Task<VehiculoEntity> GetbyId(VehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<VehiculoEntity>("dbo.VehiculoObtener", new { entity.IdVehiculo });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        //Metodo Create
        public async Task<DBEntity> Create(VehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.VehiculoInsertar",
                    new
                    {
                        entity.Codigo,
                        entity.Descripcion,
                        entity.Valor,
                        entity.Estado
                    });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        // Update
        public async Task<DBEntity> Update(VehiculoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.VehiculoActualizar",
                    new
                    {
                        entity.IdVehiculo,
                        entity.Codigo,
                        entity.Descripcion,
                        entity.Valor,
                        entity.Estado
                    });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        // Delete
        public async Task<VehiculoEntity> Delete(VehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<VehiculoEntity>("dbo.VehiculoEliminar", new { entity.IdVehiculo });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion
    }
}

using ControlUsuariosEquipos.Wasm.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioEquipo(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<bool> ActualizarEquipo(Equipo equipo)
        {
            var sql = @"UPDATE Equipos SET id_sucursal=@id_sucursal, id_agencia=@id_agencia, id_usuario=@id_usuario, tipo=@tipo,
                        marca=@marca, nombre=@nombre, modelo=@modelo, serie=@serie, folio=@folio, observaciones=@observaciones,
                        fecha_modificacion=@fecha_modificacion WHERE id=@id_equipo";

            // Ejecutar la consulta que devolverá el número de filas afectadas (al menos 1)
            var result = await _dbConnection.ExecuteAsync(sql, new { id_sucursal = equipo.IdSucursal, id_agencia = equipo.IdAgencia,
                id_usuario = equipo.IdUsuario == null ? null : equipo.IdUsuario, tipo = equipo.Tipo.ToUpper(),
                marca = equipo.Marca == null ? null : equipo.Marca.ToUpper(),
                nombre = equipo.Nombre == null ? null : equipo.Nombre.ToUpper(),
                modelo = equipo.Modelo == null ? null : equipo.Modelo.ToUpper(),
                serie = equipo.Serie == null ? null : equipo.Serie.ToUpper(),
                folio = equipo.Folio == null ? null : equipo.Folio.ToUpper(),
                observaciones = equipo.Observaciones == null ? null : equipo.Observaciones.ToUpper(),
                fecha_modificacion = equipo.FechaModificacion, id_equipo = equipo.Id });

            return result > 0;
        }

        public async Task<int> CantidadEquipos()
        {
            var sql = "SELECT count(id) as Id FROM Equipos";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(sql, new { });
        }

        public async Task<int> CantidadEquiposPorUsuario(int idUsuario)
        {
            var sql = "SELECT count(id) as Id FROM Equipos WHERE id_usuario = @id_usuario";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(sql, new { id_usuario = idUsuario });
        }

        public async Task<Equipo> DetallesEquipo(int id)
        {
            var sql = @"SELECT e.id As Id, e.id_agencia as IdAgencia, e.id_sucursal as IdSucursal, e.id_usuario As IdUsuario, u.nombre As Usuario, e.tipo, 
                        e.marca, e.nombre, e.modelo, e.serie, e.folio, e.observaciones, e.fecha_modificacion As FechaModificacion FROM Equipos e
                        Left JOIN Usuarios u ON e.id_usuario=u.id WHERE e.id=@id_equipo";

            return await _dbConnection.QueryFirstOrDefaultAsync<Equipo>(sql, new { id_equipo = id });
        }

        public async Task EliminarEquipo(int id)
        {
            var sql = "DELETE FROM Equipos WHERE id=@id_equipo";

            await _dbConnection.ExecuteAsync(sql, new { id_equipo = id });
        }

        public async Task<bool> InsertarEquipo(Equipo equipo)
        {
            var sql = @"INSERT INTO Equipos (id_sucursal, id_agencia, id_usuario, tipo, marca, nombre, modelo,
                        serie, folio, observaciones, fecha_modificacion) VALUES (@id_sucursal, @id_agencia, 
                        @id_usuario, @tipo, @marca, @nombre, @modelo, @serie, @folio, @observaciones, @fecha_modificacion)"
            ;

            var result = await _dbConnection.ExecuteAsync(sql, new { 
                id_sucursal = equipo.IdSucursal, id_agencia = equipo.IdAgencia, id_usuario = equipo.IdUsuario == null ? null : equipo.IdUsuario,
                tipo = equipo.Tipo.ToUpper(), marca = equipo.Marca == null ? null : equipo.Marca.ToUpper(),
                nombre = equipo.Nombre == null ? null : equipo.Nombre.ToUpper(),
                modelo = equipo.Modelo == null ? null : equipo.Modelo.ToUpper(),
                serie = equipo.Serie == null ? null : equipo.Serie.ToUpper(),
                folio = equipo.Folio == null ? null : equipo.Folio.ToUpper(),
                observaciones = equipo.Observaciones == null ? null : equipo.Observaciones.ToUpper(),
                fecha_modificacion = equipo.FechaModificacion
            });

            return result > 0;
        }

        public async Task<IEnumerable<Equipo>> ObtenerEquipos()
        {
            var sql = @"SELECT e.id As Id, u.nombre As Usuario, s.nombre As Sucursal, e.tipo, e.marca, e.nombre, e.modelo, e.serie,
                        e.folio, e.observaciones, e.fecha_modificacion as FechaModificacion, (select Count(id_equipo) from 
                        Equipo_Hardware_Computadora hc where hc.id_equipo = e.id) as HardwarePC, (select Count(id_equipo) from 
                        Equipo_Software_Computadora sc where sc.id_equipo = e.id) as SoftwarePC FROM 
                        Equipos e LEFT JOIN Usuarios u ON e.id_usuario=u.id INNER JOIN Sucursal s ON e.id_sucursal=s.id";

            return await _dbConnection.QueryAsync<Equipo>(sql, new { });
        }

        public async Task<IEnumerable<Equipo>> ObtenerEquiposPorUsuario(int idUsuario)
        {
            var sql = @"SELECT id As Id, tipo, id_sucursal As IdSucursal, id_agencia As IdAgencia, marca, nombre, modelo, serie,
                        folio, observaciones, fecha_modificacion as FechaModificacion FROM Equipos WHERE id_usuario = @id_usuario";

            return await _dbConnection.QueryAsync<Equipo>(sql, new { id_usuario = idUsuario });
        }

        public async Task<IEnumerable<string>> ObtenerFolios()
        {
            var sql = @"SELECT folio FROM Equipos";

            return await _dbConnection.QueryAsync<string>(sql, new { });
        }

        public async Task<IEnumerable<Equipo>> ObtenerEquiposSinUsuario()
        {
            var sql = @"SELECT e.id As Id, u.nombre As Usuario, s.nombre As Sucursal, e.tipo, e.marca, e.nombre, e.modelo, e.serie,
                        e.folio, e.observaciones, e.fecha_modificacion as FechaModificacion, (select Count(id_equipo) from 
                        Equipo_Hardware_Computadora hc where hc.id_equipo = e.id) as HardwarePC, (select Count(id_equipo) from 
                        Equipo_Software_Computadora sc where sc.id_equipo = e.id) as SoftwarePC FROM 
                        Equipos e LEFT JOIN Usuarios u ON e.id_usuario=u.id INNER JOIN Sucursal s ON e.id_sucursal=s.id WHERE id_usuario is null";

            return await _dbConnection.QueryAsync<Equipo>(sql, new { });
        }

        public async Task<int> CantidadEquiposLibres()
        {
            var sql = "SELECT Count(id) FROM Equipos WHERE id_usuario is null";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(sql, new { });
        }

        public async Task<int> SiguienteId()
        {
            var sql = "SELECT IDENT_CURRENT('Equipos') + 1";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(sql, new { });
        }
    }
}

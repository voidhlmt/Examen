using ExamenAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ExamenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtVentController : ControllerBase
    {
        [HttpGet]
        public List<ArtVent> StoredProcedure(string operacion, int codigo)
        {
            var lista = new List<ArtVent>();
            using (var cnn = new SqlConnection(Ui.CadenaSQL))
            {
                using (var adapter = new SqlDataAdapter("exec consulta" + " '" + operacion + "', " + codigo, cnn))
                {
                    if(operacion=="articulo")
                    {
                        cnn.Open();
                        var reader = adapter.SelectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            var objE = new ArtVent();
                            objE.codigo = reader.GetInt32(0);
                            objE.nombre = reader.GetString(1);
                            objE.precio = reader.GetInt32(2);
                            objE.existencia = reader.GetInt32(3);
                            lista.Add(objE);
                        }
                    }
                    if (operacion == "venta")
                    {
                        cnn.Open();
                        var reader = adapter.SelectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            var objE = new ArtVent();
                            objE.factura = reader.GetInt32(0);
                            objE.fecha = reader.GetDateTime(1);
                            objE.total = reader.GetInt32(2);
                            lista.Add(objE);
                        }
                    }
                }
            }
            return lista;
        }

    }
    public static class Ui
    {
        public static string CadenaSQL
        {
            get; set;
        } = string.Empty;
    }
}

using Capa_Modelo_Planilla;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador_Planilla
{
    //public class ComisionesControlador
    //{
    //    private readonly HttpClient client;
    //    private readonly ComisionDAO dao;

    //    public ComisionesControlador()
    //    {
    //        client = new HttpClient();
    //        dao = new ComisionDAO();
    //    }

    //    public async Task ProcesarComisionesDesdeAPI()
    //    {
    //        HttpResponseMessage response = await client.GetAsync("http://localhost:3000/comisiones");
    //        response.EnsureSuccessStatusCode();
    //        string json = await response.Content.ReadAsStringAsync();

    //        var lista = JsonConvert.DeserializeObject<List<Comision>>(json);

    //        int? idPercepcion = dao.ObtenerIdPercepcionComision();
    //        if (idPercepcion == null) return;

    //        foreach (var comision in lista)
    //        {
    //            int? claveEmpleado = dao.ObtenerClaveEmpleadoDesdeVendedor(comision.Fk_id_vendedor);
    //            if (claveEmpleado == null) continue;

    //            string mes = comision.Comisiones_fecha_.ToString("MMMM").ToUpper();
    //            dao.InsertarOActualizarDeduccionEmpleado(claveEmpleado.Value, idPercepcion.Value, comision.Comisiones_total_comision, mes);
    //        }
    //    }
    //}
    public class ComisionesControlador
    {
        private readonly HttpClient client;
        private readonly ComisionDAO dao;

        public ComisionesControlador()
        {
            client = new HttpClient();
            dao = new ComisionDAO();
        }

        public async Task ProcesarComisionesDesdeAPI()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:3000/comisiones");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();

            var lista = JsonConvert.DeserializeObject<List<Comision>>(json);
            if (lista == null || lista.Count == 0) return;

            int? idPercepcion = dao.ObtenerIdPercepcionComision();
            if (idPercepcion == null) return;

            var agrupadas = lista
                .GroupBy(c =>
                {
                    var clave = dao.ObtenerClaveEmpleadoDesdeVendedor(c.Fk_id_vendedor);
                    string mes = c.Comisiones_fecha_.ToString("MMMM").ToUpper();
                    return (clave, mes);
                })
                .Where(g => g.Key.clave != null)
                .Select(g => new
                {
                    ClaveEmpleado = g.Key.clave.Value,
                    Mes = g.Key.mes,
                    TotalComision = g.Sum(c => c.Comisiones_total_comision)
                });

            foreach (var item in agrupadas)
            {
                dao.InsertarOActualizarDeduccionEmpleado(item.ClaveEmpleado, idPercepcion.Value, (float)item.TotalComision, item.Mes);
            }
        }
    }
}

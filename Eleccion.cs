using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalOficial
{
    public class Eleccion
    {
        public String nombreEleccion { get; set; }
        public String fecha { get; set; }
        public int numeroEscaños { get; set; }
        public int mayoriaAbsoluta { get; set; }
        public List<PartidoEscaño> partido { get; set; } = new List<PartidoEscaño>();

        public Eleccion(String nombreEleccion, String Fecha, String numeroEscaños, String mayoriaAbsoluta,
            List<PartidoEscaño> partidos) 
        {
            
        }
    
    }
}

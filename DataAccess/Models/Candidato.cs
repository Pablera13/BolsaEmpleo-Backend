﻿using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccess.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

        public string Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Descripcion { get; set; }

        //Relaciones
        public List<Formacion> formaciones { get; set; }
        public List<CandidatoHabilidad> CandidatoHabilidades { get; set; }
        public List<CandidatoOferta> CandidatoOfertas { get; set; }
    }
}

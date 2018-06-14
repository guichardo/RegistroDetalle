using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class GruposDetalle
    {
        [Key]
        public int Id { get; set; }
        public int GrupoId { get; set; }
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        //Permite indicar por cual campo se usara
        //la NAVIGATION PROPERTY
        public virtual Personas Persona { get; set; }
        public string Cargo { get; set; }

        public GruposDetalle()
        {
            this.Id = 0;
            this.GrupoId = 0;
        }

        /// <summary>
        /// Este constructor es opcional solo lo agrego por comodidad
        /// </summary> 
        public GruposDetalle(int id, int grupoId, int personaId, string cargo)
        {
            this.Id = id;
            this.GrupoId = grupoId;
            this.PersonaId = personaId;
            this.Cargo = cargo;
        }
    }
}

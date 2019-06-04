﻿using RcepcionApi.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RcepcionApi.Models
{
    public class TipoLLamadasViewModel
    {
        public TipoLLamadasViewModel()
        {

        }
        public TipoLLamadasViewModel (TipoLlamadaEntity x)
        {
            this.Id = x.Id;
            this.Tipo = x.Tipo;
            this.FechaRegistro = x.FechaRegistro;
        }


        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }
        public DateTimeOffset FechaRegistro { get; set; }
    }
}

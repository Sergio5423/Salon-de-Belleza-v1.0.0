﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Categoria
    {
        public Categoria() 
        {
            
        }

        public Categoria(int id,
                         string nombre,
                         long telefono,
                         string correo,
                         DateTime ultimaVisita,
                         DateTime cumpleaños,
                         int tiempoRegreso) 
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            UltimaVisita = ultimaVisita;
            Cumpleaños = cumpleaños;
            TiempoRegreso = tiempoRegreso;
        }

        public int Id { get; set; }
        public string Nombre { get; set;}
        public long Telefono { get; set;}
        public string Correo { get; set;}
        public DateTime UltimaVisita { get; set;}
        public DateTime Cumpleaños { get; set;}
        public int TiempoRegreso { get; set; }

        public abstract DateTime Regreso(DateTime ultimaVisita);
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimiento : Categoria
    {
        public Mantenimiento()
        {
        }
        public Mantenimiento(int id,
                             string nombre,
                             long telefono,
                             string correo,
                             DateTime ultimaVisita,
                             DateTime cumpleaños,
                             int tiempoRegreso = 15) : base(id,
                                                            nombre,
                                                            telefono,
                                                            correo,
                                                            ultimaVisita,
                                                            cumpleaños,
                                                            tiempoRegreso)
        {
            
        }        

        public override DateTime Regreso(DateTime ultimaVisita)
        {
            DateTime regreso = ultimaVisita.AddDays(TiempoRegreso);
            return regreso;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{Correo};{UltimaVisita};{Cumpleaños}";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public interface IOperacionesBD<T>
    {
        void Agregar(T t);
        List<T> Consultar();
        List<T> Filtrar(string dato);
        void Borrar(int id);
        T Mapeador(SqlDataReader dataReader);
    }
}

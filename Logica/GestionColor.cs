﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestionColor : ICliente<Color>
    {
        List<Color> listaColor = null;

        public GestionColor() 
        {
            listaColor = new List<Color>();
        }

        public void Agregar(Color cliente)
        {
            listaColor.Add(cliente);
        }
        public List<Color> Consultar()
        {
            return listaColor;
        }

        public Color Buscar(string dato)
        {
            foreach (var item in Consultar())
            {
                if (item.Id.ToString() == dato)
                {
                    return item;
                }
                else
                {
                    if (item.Nombre == dato)
                    {
                        return item;
                    }
                    else
                    {
                        if (item.Telefono.ToString() == dato)
                        {
                            return item;
                        }
                        else
                        {
                            if (item.Correo == dato)
                            {
                                return item;
                            }
                        }
                    }
                }
            }
            return null;
        }

        public void Borrar(string dato)
        {
            var Cliente = Buscar(dato);
            listaColor.Remove(Cliente);
        }              
    }
}

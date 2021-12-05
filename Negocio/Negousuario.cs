﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Negousuario
    {

        Auth auth = new Auth();


        public Inicio_Result validar(string correo, string clave)
        {
            return auth.IniciarSesion(correo, clave);
        }

        public string Crear_cliente(string nombre, string correo, string clave, string clave2) 
        {

            if(clave == clave2)
            {
                Cliente cliente = new Cliente();

                cliente.Nombre = nombre;
                cliente.Correo = correo;
                cliente.Passw = clave;

                var y = auth.Crear_cliente(cliente);

                return y != null ? "Agregado" : "Ya existe";
            }
            else
            {
                return "La segunda clave no coincide con la primera"; 
            }

        } 
    }
}

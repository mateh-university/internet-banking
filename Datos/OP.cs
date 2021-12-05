﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;


namespace Datos
{
    public class OP
    {
        DBProEntities6 db = new DBProEntities6();

        public void Solicitar_Cahorros (Cuenta_Ahorros cuenta)
        {
            db.Cuenta_Ahorros.Add(cuenta);
            db.SaveChanges();
        }

        public Cliente validar(string correo, string clave)
        {
            var usuario = db.Cliente.FirstOrDefault(a => a.Correo == correo && a.Passw == clave);

            return usuario;

        }

        public List<Cliente> MostrarUsuario()
        {
            return db.Cliente.ToList();
        }

        public Cliente ObtenerUsuario(int id)
        {

            string sql = @"select ID, Nombre, Correo, Passw
                 from Usuario       
                where ID = @ID";
            using (var dbq = new DBProEntities6())
            {
           
                return dbq.Database.SqlQuery<Cliente>(sql,
                    new SqlParameter("@ID", id)).FirstOrDefault();
            }
        }

    }
}

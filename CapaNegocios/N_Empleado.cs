﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Empleado
    {
        D_Empleado d_Empleado = new D_Empleado();
        public DataTable Listado()
        {
            DataTable Tabla = new DataTable();
            Tabla = d_Empleado.MostrarEmpleado();
            return Tabla;
        }
    }
}
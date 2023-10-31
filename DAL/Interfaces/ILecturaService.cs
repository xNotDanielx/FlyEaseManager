﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILecturaService<T> where T : class
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(string id);
    }
}

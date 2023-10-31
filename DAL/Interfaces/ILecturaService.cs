﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILecturaService<T> where T : class
    {
        Task<List<T>> ObtenerTodos();
    }
}

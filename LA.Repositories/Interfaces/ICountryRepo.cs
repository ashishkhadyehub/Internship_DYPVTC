﻿using LA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Interfaces
{
    public interface ICountryRepo
    {
        //method signature
        IEnumerable<Country> GetAll();

        Country GetById(int id);

        void Save(Country country);

        void Edit(Country country);

        void RemoveData(Country country);


    }
}

﻿using LA.Models;
using LA.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Implementations
{
    public class StateRepo : IStateRepo
    {
        private readonly ApplicationDbContext _context;

        public StateRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Edit(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
        }

        public IEnumerable<State> GetAll()
        {
            var states = _context.States.Include(a=>a.Country).ToList();
            return states;
        }

        public State GetById(int id)
        {
            var state = _context.States.Find(id);
            return state;
        }

        public void RemoveData(State state)
        {
            _context.States.Remove(state);
            _context.SaveChanges();
        }

        public void Save(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
        }
    }
}

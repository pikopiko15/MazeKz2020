﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebMaze.DbStuff.Model;

namespace WebMaze.DbStuff.Repository
{
    public class AdressRepository : BaseRepository<Adress>
    {
        public AdressRepository(WebMazeContext context) : base(context)
        {
        }

        public IEnumerable<Adress> GetAdressByCity(string city)
        {
            return dbSet.Where(x => x.City == city);
        }
    }
}

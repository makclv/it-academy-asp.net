﻿using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Data.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public Book AllOrders()
        {
            throw new NotImplementedException();
        }
    }
}

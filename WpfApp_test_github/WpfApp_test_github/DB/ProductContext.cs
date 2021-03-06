﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_test_github.ViewModel;

namespace WpfApp_test_github.DB
{
    class ProductContext : DbContext
    {

        /// <summary>
        /// Указание имени БД.
        /// </summary>
        public ProductContext() : base("TestDBsds")
        {
        }

        /// <summary>
        /// Создание таблицы в бд.
        /// </summary>
        public DbSet<Product> Products { get; set; }
    }
}

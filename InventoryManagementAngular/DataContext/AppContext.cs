﻿using Microsoft.EntityFrameworkCore;

namespace InventoryManagementAngular.DataContext
{
    public class AppContext : DbContext
    {
        public AppContext()        {        }
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_APATE.Models;
using Microsoft.AspNetCore.SignalR;
using MvcDevices.Models;
using IPGeolocation;

namespace MvcDevices.Data
{
    public class MvcDevicesContext : DbContext
    {
        public MvcDevicesContext(DbContextOptions<MvcDevicesContext> options)
            : base(options)
        {
        }

        public DbSet<Devices> Devices { get; set; }
    }
}
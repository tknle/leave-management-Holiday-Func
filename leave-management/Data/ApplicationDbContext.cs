﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using leave_management.Models;

namespace leave_management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees {get; set;}
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<leave_management.Models.LeaveRequestVM> LeaveRequestVM { get; set; }
        public DbSet<leave_management.Models.HolidayVM> HolidayVM { get; set; }
       
        
    }
}

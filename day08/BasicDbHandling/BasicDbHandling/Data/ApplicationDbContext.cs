﻿using BasicDbHandling.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicDbHandling.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            // 내용무
        }

        // CodeFirst로 만들어준 엔티티클래스를 작성, 테이블 생성할 엔티티가 늘떄마다 여기에 추가해야 함
        public DbSet<Category> Categories { get; set; }
    }
}

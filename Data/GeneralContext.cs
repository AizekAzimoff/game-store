﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data {
    public class GeneralContext : IdentityDbContext {
        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options) {
        }

        public DbSet<Developer> Developer { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameGenreRel> GameGenreRel { get; set; }
        public DbSet<GamePlatformRel> GamePlatformRel { get; set; }
        public DbSet<GameShoppingCartRel> GameShoppingCartRel { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(a => a.shoppingCart)
                .WithOne(a => a.user)
                .HasForeignKey<ShoppingCart>(c => c.userId);
            
            modelBuilder.Entity<GameGenreRel>()
                .HasKey(a => new { a.gameId, a.genreId });
            modelBuilder.Entity<GamePlatformRel>()
                .HasKey(a => new { a.gameId, a.platformId });
            modelBuilder.Entity<GameShoppingCartRel>()
                .HasKey(a => new { a.gameId, a.shoppingCartId });

            modelBuilder.Entity<Game>()
                .HasOne<Developer>(s => s.developer)
                .WithMany(g => g.games)
                .HasForeignKey(s => s.developerId);
            modelBuilder.Entity<Game>()
                .HasOne<Publisher>(s => s.publisher)
                .WithMany(g => g.games)
                .HasForeignKey(s => s.publisherId);
            modelBuilder.Entity<Review>()
                .HasOne<Game>(s => s.game)
                .WithMany(g => g.reviews)
                .HasForeignKey(s => s.gameId);
        }
    }
}
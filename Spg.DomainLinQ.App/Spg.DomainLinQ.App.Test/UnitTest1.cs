namespace Spg.DomainLinQ.App.Test;
using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using System;
using System.Linq;
public class UnitTest1
{
        //private School2000Context GenerateDb()
        //{
        //    DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
        //    optionsBuilder.UseSqlite("Data Source=./../../../School2000.db");

        //    School2000Context db = new School2000Context(optionsBuilder.Options);
        //    db.Database.EnsureDeleted();
        //    db.Database.EnsureCreated();
        //    return db;
        //}

        //[Fact]
        //public void SeedDb()
        //{
        //    School2000Context db = GenerateDb();
        //    db.Seed();
        //    Assert.True(true);
        //}

        //[Fact]
        //public void Exam_Add_OneEntity_SuccessTest()
        //{
        //    // AAA
        //    // 1. Arrange
        //    School2000Context db = GenerateDb();
        //    Subject dbi = new Subject("DBI", new SchoolClass("5AKIF", new Teacher("Lisa", "Wanik", "wanik@spengergasse.at", Gender.FEMALE, new Guid("4eed0903-12d5-4891-9194-d46c4873a2f9"), new Address("Grinzinger Allee", "1190", "Wien"), new Guid("4eed0903-12d5-4891-9194-d46c4873a2f8"))));
        //    Exam newExam = new Exam(new Guid("4eed0903-12d5-4891-9194-d46c4873a2f7"), DateTime.UtcNow.AddDays(14), 5, 3, dbi, DateTime.UtcNow.AddDays(14));

        //    // 2. Act
        //    db.Exams.Add(newExam);
        //    db.SaveChanges();

        //    // 3. Assert
        //    Assert.Equal(1, db.Exams.Count());
        //}
}
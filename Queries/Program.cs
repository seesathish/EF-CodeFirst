using System;
using System.Linq;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            #region LinQ and Extentions Queries
            //// Linq Syntex Using Query
            //var query =
            //    from c in context.Courses
            //    where c.Name.Contains("C#")
            //    orderby c.Name
            //    select c;

            //foreach (var course in query)
            //    Console.WriteLine(course.Name);

            //// Extention methods
            //var courses = context.Courses.Where(c => c.Name.Contains("C#")).OrderBy(c => c.Name);

            //foreach (var course in courses)
            //    Console.WriteLine(course.Name);

            //Projection
            //var query =
            //    from c in context.Courses
            //    where c.AuthorId == 1
            //    orderby c.Level descending, c.Name
            //    select new { CourseName = c.Name, Author = c.Author.Name };

            //foreach (var course in query)
            //   Console.WriteLine(course.CourseName + " - " + course.Author.Name);

            ////Group By 1
            //var query =
            //    from c in context.Courses
            //    group c by c.Level
            //    into g
            //    select g;
            //foreach (var group in query)
            //{
            //    Console.WriteLine(group.Key);

            //    foreach (var course in group)
            //    {
            //        Console.WriteLine("\t{0}", course.Name);
            //    }
            //}

            ////Group By 2 aggregate func
            //var query =
            //    from c in context.Courses
            //    group c by c.Level
            //    into g
            //    select g;
            //foreach (var group in query)
            //{
            //    Console.WriteLine("{0} ({1})", group.Key, group.Count());               
            //}

            ////Join with navigation property (Author)
            //var query =
            //    from c in context.Courses
            //    select new { CourseName = c.Name, AuthorName = c.Author.Name };

            //foreach (var course in query)
            //   Console.WriteLine(course.CourseName + " - " + course.Author.Name);

            ////Join Explicit
            //var query =
            //    from c in context.Courses
            //    join a in context.Authors on c.AuthorId equals a.Id
            //    select new { CourseName = c.Name, AuthorName = a.Name };

            //foreach (var course in query)
            //    Console.WriteLine(course.CourseName + " - " + course.AuthorName);

            ////Group Join
            //var query =
            //    from a in context.Authors
            //    join c in context.Courses on a.Id equals c.AuthorId into g
            //    select new { AuthorName = a.Name, Courses = g.Count() };

            //foreach (var x in query)
            //    Console.WriteLine("{0} ({1})", x.AuthorName , x.Courses);

            ////Cross Join
            //var query =
            //  from a in context.Authors
            //  from c in context.Courses
            //  select new { AuthorName = a.Name, CourseName = c.Name };

            //foreach (var x in query)
            //    Console.WriteLine("{0} ({1})", x.AuthorName + " - ", x.CourseName);

            //// Linq Syntex Using Extention methods

            ////Restrictions

            //var Courses = context.Courses.Where(c => c.Level == 1);

            ////Orderby
            ////Single Column
            //var Courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Name);
            ////Multiple column and Decending
            //var Courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level);
            ////Projections - Select
            //var Courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .Select(c => new { CourseName = c.Name, Author = c.Author.Name });
            //Projections - Select Many 1
            //var Courses = context.Courses
            //   .Where(c => c.Level == 1)
            //   .OrderByDescending(c => c.Name)
            //   .ThenByDescending(c => c.Level)
            //   .Select(c => c.Tags);

            //foreach (var c in Courses)
            //{
            //    foreach (var tag in c)
            //    {
            //        Console.WriteLine(tag.Name);
            //    }
            //}

            ////Projections - Select Many with distinct
            //var tags = context.Courses
            //   .Where(c => c.Level == 1)
            //   .OrderByDescending(c => c.Name)
            //   .ThenByDescending(c => c.Level)
            //   .SelectMany(c => c.Tags)
            //   .Distinct();

            //foreach (var tag in tags)
            //{
            //   Console.WriteLine(tag.Name);                
            //}

            ////Grouping
            //var groups = context.Courses.GroupBy(c => c.Level);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine("Key: " + group.Key);
            //    foreach (var course in group)
            //    {
            //        Console.WriteLine("\t" + course.Name);
            //    }              

            //}

            ////Joins
            //var Courses = context.Courses.Join
            //    (context.Authors, c => c.AuthorId, a => a.Id, (Course, Author) =>
            //    new
            //    {
            //        CourseName = Course.Name,
            //        AuthorName = Author.Name
            //    });

            ////Group Join - (Left Join)
            //var Courses = context.Authors.GroupJoin
            //    (context.Courses, a => a.Id, c => c.AuthorId , (author, courses) =>
            //    new
            //    {
            //        Author = author,
            //        Courses = courses.Count()

            //    });

            ////Cross Join
            //var Courses = context.Authors.SelectMany(a => context.Courses, (author, course) => new
            //{
            //    AuthorName = author.Name,
            //    CourseName = course.Name
            //});

            ////Partitioning
            //var Courses = context.Courses.Skip(10).Take(10);

            ////Element Operators
            //var Courses = context.Courses.OrderBy(c => c.Level).FirstOrDefault();
            //var Courses2 = context.Courses.OrderBy(c => c.Level).FirstOrDefault(c => c.FullPrice > 100);
            //var Course3 = context.Courses.SingleOrDefault(c => c.Id == 1);

            //Additional Useful extention methods

            //var courses = context.Courses.All(c => c.FullPrice > 10);
            //var courses = context.Courses.Any(c => c.Level == 1);
            //var courses = context.Courses.Count();
            //var courses = context.Courses.Max(c => c.FullPrice);
            //var courses = context.Courses.Min(c => c.FullPrice);
            //var courses = context.Courses.Average(c => c.FullPrice);



            ////IQueryable //query will execure at one go
            //IQueryable<Course> courses = context.Courses;
            //var Filtered = courses.Where(c => c.Level == 1);
            //foreach (var course in Filtered)
            //{
            //    Console.WriteLine(course.Name);
            //} 
            #endregion

            ////Update data with change tracker

            ////Add an object
            //context.Authors.Add(new Author { Name = "New Author" });


            ////Update an object 
            //var author = context.Authors.Find(3);
            //author.Name = "Updated";

            ////Remove an object
            //var another = context.Authors.Find(4);
            //context.Authors.Remove(another);

            //var entries = context.ChangeTracker.Entries();

            //foreach (var entry in entries)
            //{
            //    Console.WriteLine(entry.State);
            //}
           
        }
    }
}
                                                                                         
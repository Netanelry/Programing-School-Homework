
using D151121ER_exam_prep;
using D151121ER_exam_prep.models;

using (var context = new SchoolContext())
{
    var students = new List<string> { "David", "Eli", "Shlomi" }.Select(x => new Student() { Name = x}).ToList();
    context.Students.AddRange(students);
    context.SaveChanges();

    var studentsFromDb = context.Students.ToList();
    studentsFromDb.ForEach(x => Console.WriteLine(x.Name));
}
using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentService : IStudentService
{
    DataContext _context = new();
    public int AddStudent(Student student)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into student(studentCode,studentFullname,gender,dob,Email,Phone,schoolId,stage,section,IsActive)values(@StudentCode,@StudentFullname,@Gender,@Dob,@Email,@Phone,@SchoolId,@Stage,@Section,@IsActive)";
        return connection.Execute(cmd, student);
    }

    public int DeleteStudent(int studentId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from student
        where studentId = @studentId";
        return connection.Execute(cmd, new { studentId });

    }

    public List<Student> GetStudents()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = "select * from student";
        return connection.Query<Student>(cmd).ToList();
    }

    public int UpdateStudent(Student student)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update student
                set studentId = @StudentId,studentCode = @StudentCode,studentFullname = @StudentFullname,gender = @Gender,dob = @Dob,Email = @Email,Phone = @Phone,schoolId = @SchoolId,stage = @Stage,section = @Section,IsActive = @IsActive
                where studentId = @StudentId";
        return connection.Execute(cmd, new { student });

    }
}

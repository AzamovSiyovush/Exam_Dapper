using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassStudentService : IClassStudentService
{
    DataContext _context = new();
    public int AddClassStudent(ClassStudent classStudent)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into classStudent(classId,StudentId)values(@ClassId,@StudentId)";
        return connection.Execute(cmd, classStudent);
    }

    public int DeleteClassStudent(int classStudentId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from classStudent
                    where classStudentId = @ClassStudentId";
        return connection.Execute(cmd, new { classStudentId });
    }

    public List<ClassStudent> GetClassStudents()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = "select * from classStudent";
        return connection.Query<ClassStudent>(cmd).ToList();
    }

    public int UpdateClassStudent(ClassStudent classStudent)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update classStudent
                set classId = @ClassId,StudentId = @StudentId
                where classStudentId = @ClassStudentId";
        return connection.Execute(cmd, classStudent);
    }
}
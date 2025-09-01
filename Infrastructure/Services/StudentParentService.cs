using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentParentService : IStudentParentService
{
    DataContext _context = new();

    public int AddStudentParent(StudentParent studentParent)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into studentParent(StudentId,ParentId,relationship)values(@StudentId,@ParentId,@Relationship)";
        return connection.Execute(cmd, studentParent);
    }

    public int DeleteStudentParent(int studentParentId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from studentParentId
                    where StudentParentId = @studentParentId";
        return connection.Execute(cmd, new { studentParentId });
    }

    public List<StudentParent> GetStudentParents()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = "select * from studentParent";
        return connection.Query<StudentParent>(cmd).ToList();
    }

    public int UpdateStudentParent(StudentParent studentParent)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update studentParent
                    set StudentId = @StudentId,ParentId = @ParentId,relationship = @Relationship
                    where StudentParentId = @StudentParentId";
        return connection.Execute(cmd, studentParent);
    }
}

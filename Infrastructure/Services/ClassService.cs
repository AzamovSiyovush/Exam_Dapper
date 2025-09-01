using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassService : IClassService
{
    DataContext _context = new();
    public int CreateClass(Class @class)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into class(className,subjectId,teacherId,classroomId,section)values(@ClassName,@SubjectId,@TeacherId,@ClassroomId,@Section)";
        return connection.Execute(cmd, @class);
    }

    public int DeleteClass(int classId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from class
        where classid = @classId";
        return connection.Execute(cmd, new { classId });
    }

    public List<Class> GetClasses()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = "select * from class";
        return connection.Query<Class>(cmd).ToList();

    }

    public int UpdateClass(Class @class)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update class
                    set className = @ClassName,subjectId = @SubjectId,teacherId = @TeacherId,classroomId = @ClassroomId,section = @Section
                    where classid = @ClassId";
        return connection.Execute(cmd, @class);

    }
}

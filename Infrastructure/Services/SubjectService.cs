using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class SubjectService : ISubjectService
{
    DataContext _context = new();
    public int CreatedSubject(Subject subject)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into subject(title,schoolid,stage,term,carryMark)values(@Title,@SchoolId,@Stage,@Term,@CarryMark)";
        return connection.Execute(cmd, subject);
    }

    

    public int DeleteSubject(int subjectId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from subject
                where subjectId = @subjectId";
        return connection.Execute(cmd, new { subjectId });
    }

    public List<Subject> GetSubjects()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"select * from subject";
        return connection.Query<Subject>(cmd).ToList();

    }

    public int UpdateSubject(Subject subject)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update subject
                set title = @Title,schoolId = @SchoolId,stage = @Stage,term = @Term,carryMark = @CarryMark
                where subjectId = @SubjectId";
        return connection.Execute(cmd, subject);
    }

   

   
}

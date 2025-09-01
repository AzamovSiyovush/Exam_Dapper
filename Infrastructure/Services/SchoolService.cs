using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class SchoolService : ISchoolService
{
    DataContext _context = new();
    public int CreateSchool(School school)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into school(schooltitle,levelCount,isactive) values(@SchoolTitle,@LevelCount,@IsActive)";
        return connection.Execute(cmd, school);
    }

    public int DeleteSchool(int schoolId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from school
                    where schoolid = @schoolId";
        return connection.Execute(cmd, new { schoolId });
    }

    public List<School> GetSchools()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $"select * from school";
        return connection.Query<School>(cmd).ToList();
    }

    public int UpdateSchool(School school)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update school
            set schoolid = @SchoolId,schooltitle = @SchoolTitle,levelCount = @LevelCount,isactive = @IsActive
            where schoolId = @SchoolId";
        return connection.Execute(cmd, school);
    }
}

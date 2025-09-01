using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class TeacherService : ITeacherService
{
    DataContext _context = new();
    public int AddTeacher(Teacher teacher)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into teacher(teacherCode,teacherFullname,gender,dob,email,phone,isactive,workingDays)values(@TeacherCode,@TeacherFullname,@Gender,@Dob,@Email,@Phone,@IsActive,@WorkingDays)";
        return connection.Execute(cmd, teacher);
    }

    public int DeleteTeacher(int teacherId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from teacher
                where teacherId = @teacherId";
        return connection.Execute(cmd, new { teacherId });
    }

    public List<Teacher> GetTeachers()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = "select * from teacher";
        return connection.Query<Teacher>(cmd).ToList();
    }

    public int UpdateTeacher(Teacher teacher)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update teacher
        set teacherCode = @TeacherCode,teacherFullname = @TeacherFullname,gender = @Gender,dob = @Dob,email = @Email,phone = @Phone,isactive = @IsActive,workingDays = @WorkingDays
        where teacherId = @TeacherId";
        return connection.Execute(cmd, teacher);
    }
}

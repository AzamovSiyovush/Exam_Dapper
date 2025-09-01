using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassroomService : IClassroomService
{
    DataContext _context = new();
    public int CreateClassroom(Classroom classroom)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into classroom(capacity,roomType,description)
        values(@Capacity,@RoomType,@Description)";
        return connection.Execute(cmd, classroom);
    }

    public int DeleteClassroom(int classroomId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from classroomId
                where classroomId = @ClassroomId";
        return connection.Execute(cmd, new { classroomId });

    }

    public List<Classroom> GetClassrooms()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"select * from classroom";
        return connection.Query<Classroom>(cmd).ToList();
    }

    public int UpdateClassroom(Classroom classroom)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update classroom
        set capacity = @Capacity,roomType = @RoomType,description = @Description";
        return connection.Execute(cmd, classroom);
    }
}

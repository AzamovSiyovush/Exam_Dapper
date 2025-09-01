using System;
using Dapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ParentService : IParentService
{
    DataContext _context = new();
    public int AddParent(Parent parent)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"insert into parent(parentCode,parentFullname,email,phone)values(@ParentCode,@ParentFullname,@Email,@Phone)";
        return connection.Execute(cmd, parent);
    }

    public int DeleteParent(int parentId)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"delete from parent
        where parentId = @parentId";
        return connection.Execute(cmd, new { parentId });

    }

    public List<Parent> GetParents()
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = "select * from parent";
        return connection.Query<Parent>(cmd).ToList();
    }

    public int UpdateParent(Parent parent)
    {
        using var connection = _context.GetConnection();
        connection.Open();
        var cmd = $@"update parent
        set parentCode = @ParentCode,parentFullname = @ParentFullname,Email = @Email,Phone = @Phone
        where parentId = @ParentId";
        return connection.Execute(cmd, parent);
    }
}

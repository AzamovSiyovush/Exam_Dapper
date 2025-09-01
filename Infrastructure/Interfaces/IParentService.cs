using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IParentService
{
    List<Parent> GetParents();
    int AddParent(Parent parent);
    int UpdateParent(Parent parent);
    int DeleteParent(int parentId);
}

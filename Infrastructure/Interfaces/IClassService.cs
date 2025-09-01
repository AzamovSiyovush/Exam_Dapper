using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IClassService
{
    List<Class> GetClasses();
    int CreateClass(Class @class);
    int UpdateClass(Class @class);
    int DeleteClass(int classId);
}

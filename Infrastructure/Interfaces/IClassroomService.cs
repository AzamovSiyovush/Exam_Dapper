using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IClassroomService
{
    List<Classroom> GetClassrooms();
    int CreateClassroom(Classroom classroom);
    int UpdateClassroom(Classroom classroom);
    int DeleteClassroom(int classroomId);
}

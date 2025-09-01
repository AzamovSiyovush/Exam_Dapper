using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ITeacherService
{
    List<Teacher> GetTeachers();
    int AddTeacher(Teacher teacher);
    int UpdateTeacher(Teacher teacher);
    int DeleteTeacher(int teacherId);
}

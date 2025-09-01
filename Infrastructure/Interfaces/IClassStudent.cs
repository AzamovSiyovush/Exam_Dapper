using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IClassStudentService
{
    List<ClassStudent> GetClassStudents();
    int AddClassStudent(ClassStudent classStudent);
    int UpdateClassStudent(ClassStudent classStudent);
    int DeleteClassStudent(int classStudentId);
}

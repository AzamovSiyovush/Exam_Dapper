using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IStudentParentService
{
    List<StudentParent> GetStudentParents();
    int AddStudentParent(StudentParent studentParent);
    int UpdateStudentParent(StudentParent studentParent);
    int DeleteStudentParent(int studentParentId);
}

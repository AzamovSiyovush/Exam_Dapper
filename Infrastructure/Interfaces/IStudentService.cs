using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IStudentService
{
    List<Student> GetStudents();
    int AddStudent(Student student);
    int UpdateStudent(Student student);
    int DeleteStudent(int studentId);
}

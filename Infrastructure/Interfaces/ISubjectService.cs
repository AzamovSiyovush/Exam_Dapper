using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ISubjectService
{
    List<Subject> GetSubjects();
    int CreatedSubject(Subject subject);
    int UpdateSubject(Subject subject);
    int DeleteSubject(int subjectId);
}

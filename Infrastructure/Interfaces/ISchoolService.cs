using System;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ISchoolService
{
    List<School> GetSchools();
    int CreateSchool(School school);
    int UpdateSchool(School school);
    int DeleteSchool(int schoolId);
}

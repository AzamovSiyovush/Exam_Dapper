using System;

namespace Domain.Entities;

public class Student
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; }
    public string StudentFullName { get; set; }
    public int Gender { get; set; }
    public DateTime dob { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int SchoolId { get; set; }
    public int Stage { get; set; }
    public char section { get; set; }
    public int IsActive { get; set; }
    public DateTime JoinDate = DateTime.Now;
    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;
}

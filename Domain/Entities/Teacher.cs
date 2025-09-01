using System;

namespace Domain.Entities;

public class Teacher
{
    public int TeacherId { get; set; }
    public string TeacherCode { get; set; }
    public string TeacherFullname { get; set; }
    public int Gender { get; set; }
    public DateTime Dob { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int IsActive { get; set; }
    public DateTime JoinDate = DateTime.Now;
    public int WorkingDays { get; set; }
    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;
}

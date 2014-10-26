using System;
using System.Collections.Generic;
using System.Linq;
public class Student: ICloneable, IComparable<Student>
{
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }
    public string SSN { get; private set; }
    public string Adress { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public byte Course { get; set; }
    public University University { get; set; }
    public Faculty Faculty { get; set; }
    public Specialty Specialty { get; set; }
    public Student(string firstName, string middleName, string lastName, string ssn, byte course, string adress,
        string phone, string email, University university, Faculty faculty, Specialty specialty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Course = course;
        this.Adress = adress;
        this.Phone = phone;
        this.Email = email;
        this.University = university;
        this.Faculty = faculty;
        this.Specialty = specialty;
    }
    public override bool Equals(object param)
    {
        // If the cast is invalid, the result will be null
        Student student = param as Student;
        // Check if we have valid not null Student object
        if (student == null)
            return false;
        // Compare the reference type member fields
        if (!(Object.Equals(this.FirstName, student.FirstName) || Object.Equals(this.MiddleName, student.MiddleName) ||
            Object.Equals(this.LastName, student.LastName) || Object.Equals(this.SSN, student.SSN)))
            return false;
        return true;
    }
    public static bool operator ==(Student student1,
                                  Student student2)
    {
        return Student.Equals(student1, student2);
    }
    public static bool operator !=(Student student1,
                       Student student2)
    {
        return !(Student.Equals(student1, student2));
    }
    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ LastName.GetHashCode();
    }
    public override string ToString()
    {
        return String.Format("{0} {1} {2}, SSN: {3}, Course: {4}\nUniversity: {5}, Faculty: {6}, Specialty: {7}\nAdress: {8}, E-mail: {9}, Phone: {10}",
            this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Course, this.University,this.Faculty, this.Specialty, this.Adress, this.Email, this.Phone);
    }
    public object Clone()
    {
        return new Student(
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.SSN,
            this.Course,
            this.Adress,
            this.Phone,
            this.Email,
             this.University,
            this.Faculty,
            this.Specialty)as object;
    }
    public int CompareTo(Student student)
    {
        if (this.FirstName.CompareTo(student.FirstName) != 0)
        {
            return this.FirstName.CompareTo(student.FirstName);
        }
        else if (this.MiddleName.CompareTo(student.MiddleName) != 0)
        {
            return this.MiddleName.CompareTo(student.LastName);
        }
        else if (this.LastName.CompareTo(student.LastName) != 0)
        {
            return this.MiddleName.CompareTo(student.LastName);
        }
        else if (this.SSN.CompareTo(student.SSN) != 0)
        {
            return this.SSN.CompareTo(student.SSN);
        }
        else
        {
            return 0;
        }
    }

}
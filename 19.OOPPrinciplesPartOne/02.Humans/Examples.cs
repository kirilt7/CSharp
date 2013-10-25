using System;
using System.Collections.Generic;
using System.Linq;
class Examples
{
    static void Main()
    {
        List<Student> studentsList = new List<Student>();
        studentsList.Add(new Student("Peter", "Petrov", 4.57));
        studentsList.Add(new Student("Stoyan", "Petrov", 3.22));
        studentsList.Add(new Student("Georgi", "Georgiev", 5.59));
        studentsList.Add(new Student("Nikolay", "Kostov", 5.97));
        studentsList.Add(new Student("Angel", "Angelov", 4.63));
        studentsList.Add(new Student("Hristo", "Hristov", 4.21));
        studentsList.Add(new Student("Plamen", "Georgiev", 5.59));
        studentsList.Add(new Student("Ivan", "Georgiev", 5.59));
        studentsList.Add(new Student("Aleksander", "Aleksandrov", 3.97));
        studentsList.Add(new Student("Ivan", "Ivanov", 4.90));
        List<Student> sortedStudents =
            (from student in studentsList
             orderby student.Grade
             select student).ToList();
        List<Worker> workersList = new List<Worker>();
        workersList.Add(new Worker("Velizar", "Dimitrov", 880, 8));
        workersList.Add(new Worker("Stojko", "Sakaliev", 1100.55m, 9));
        workersList.Add(new Worker("Valentin", "Iliev", 1005.22m, 7.5));
        workersList.Add(new Worker("Jackson", "Mendy", 775.90m, 7.2));
        workersList.Add(new Worker("Apostol", "Popov", 580, 6));
        workersList.Add(new Worker("Ivaylo", "Chochev", 1389.40m, 9.2));
        workersList.Add(new Worker("Todor", "Yanchev", 888.88m, 8));
        workersList.Add(new Worker("Jeremy", "Fo Porret", 1500, 10));
        workersList.Add(new Worker("Emil", "Gargorov", 920.50m, 8));
        workersList.Add(new Worker("Tomas", "Cherny", 447.23m, 3.5));
        List<Worker> sortedWorkers =
            (from worker in workersList
             orderby worker.MoneyPerHour() descending
             select worker).ToList();
        List<Human> allHumans = new List<Human>();
        foreach (var student in sortedStudents)
        {
            allHumans.Add(student);
        }
        foreach (var worker in sortedWorkers)
        {
            allHumans.Add(worker);
        }
        var sortedHumans =
            from human in allHumans
            orderby human.LastName
            orderby human.FirstName
            select human;
        foreach (var human in sortedHumans)
        {
            Console.WriteLine(human);
        }
    }
}
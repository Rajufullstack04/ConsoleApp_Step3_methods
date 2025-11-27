using System;



namespace Mathod_Advanced_container
{
    class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Subject { get; set; }

    }
    class  StudentOperation
    {

        /// <summary>
        ///  Returns a single student as a class model.
        /// </summary>
        /// <returns>Studnet Model</returns>
        public static Student GetStudent()
        {
            //Student student = new Student();
            //Student.ID = 1;
            //Student.Name = "Raju";
            //Student.Age = 25;
            //Student.Subject = "C#.Net";
            //return Student;

            return new Student()
            {
                ID = 1,
                Name = "Raju",
                Age = 25,
                Subject = "C#.Net"

            };

        }
        /// <summary>
        /// Returns a list of students as class models.
        /// </summary>
        /// <returns>Students array</returns>
        public static Student[] GetStudents()
        {
            return new Student[]
            {
                new Student {ID=2 ,Name = "Venky",Age = 27,Subject ="Javascript"},
                new Student {ID=3 ,Name = "Adarsh",Age = 23,Subject ="Angular"},
                new Student {ID=4 ,Name = "Sathiesh",Age = 21,Subject ="HTML&CSS"}

            };


        }
        /// <summary>
        ///  Takes a student as input and returns the same student with updated details.
        /// </summary>
        /// <param name="student">Type is Studnet</param>
        /// <returns>Student</returns>
        public static Student UpdateStudent(Student student)
        {
            student.Subject = student.Subject + " - Advanced Leval";
            return student;
          
        }
        /// <summary>
        ///  Takes a list of students as input and returns the updated list of students.
        /// </summary>
        /// <param name="students">stuenetdnts type</param>
        /// <returns>stuendts</returns>

        public static Student[] UpdateStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                student.Subject = student.Subject + " - Advanced";
            }
            return students;
        }


    }
    class Program
    {
        static void Main()
        {
            // Method 1: Return a single class model
            var singleStudent = StudentOperation.GetStudent();
            Console.WriteLine($"Single Student: {singleStudent.Name}, {singleStudent.Age}, {singleStudent.Subject}");


            // Method 2: Return a list of class models
            Student[] studnetsList = StudentOperation.GetStudents();
            // var studnetsList = StudentOperations.GetStudents();
            Console.WriteLine("List of Students:");
            foreach (var student in studnetsList)
            {
                Console.WriteLine($"Single Student: {student.Name}, {student.Age}, {student.Subject}");
            }


            // Method 3: Take a class model as input and return an updated class model
            Student updatedStudent = StudentOperation.UpdateStudent(singleStudent);

            // Method 4: Take a list of class models as input and return an updated list of class models
            var updatedStudetns = StudentOperation.UpdateStudents(studnetsList);
            Console.WriteLine("List of Students:");
            foreach (var student in updatedStudetns)
            {
                Console.WriteLine($"Single Student: {student.Name}, {student.Age}, {student.Subject}");
            }


        }
    }



}



//GetStudent . name , age , subject
//GetStudentsList -- each student name , age , subject


//Update subject  - which student you have to update?????(input parameter)
//update subject for the studnents.




















using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part6_Angular.Models
{
    public class RegistratioVMBuilder
    {
        public CourseVM[] GetCourses()
        {
            //Creating fake Course details
            var courses = new[]
            {
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345},
                new CourseVM{Name = "Creature of universe" , Instructor = "John Doe", Number = 12345}
            };

            //returnning list of courseVMs
            return courses;
        }


        public InstructorVM[] GetInstructors()
        {
            //Creating fake instructor details
            var instructors = new[]
            {
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
                new InstructorVM{Name = "Kobe Brayant" , Email = "KobeBrayant@gmail.com", RoomNumber = 12},
            };

            return instructors;
        }
    }
}
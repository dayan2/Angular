using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part6_Angular.Models
{
    public class RegistratioVMBuilder
    {
        //making it easy to access to the instructors and courses List
        public RegistrationVM BuildRegistrationVM()
        {
            //getting both Course and instructor details into one model
            var registrationVM = new RegistrationVM
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };
            return registrationVM;
        }

        public string GetSerializedCourses()
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

            //to make the serialized string convert into camelcase support string(otherwise view-angularJs code will not be able to read)
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }


        public string GetSerializedInstructors()
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

            //to make the serialized string convert into camelcase support string(otherwise view-angularJs code will not be able to read)
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(instructors, Formatting.None, settings);
        }
    }
}
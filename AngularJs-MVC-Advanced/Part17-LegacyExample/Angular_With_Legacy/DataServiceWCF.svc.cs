using Angular_With_Legacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Angular_With_Legacy
{
    public class DataServiceWCF : IDataServiceWCF
    {    

        List<Course> IDataServiceWCF.GetCourses()
        {
            return GetCatalogList();
        }

        Course IDataServiceWCF.GetCourse(int id)
        {
            Course course = new Course { iD = 11, instructorName = "yoyo", name = "LOL" , credits = 200};
            return course;
        }

        Course IDataServiceWCF.UpdateCourse(int id, Course course)
        {
            //var courseToUpdate = GetCatalogList().Single(c=> c.iD == course.iD);
            //courseToUpdate.registered = course.registered;
            //return courseToUpdate;
            return null;
        }


        private List<Course> GetCatalogList()
        {
            List<Course> list = new List<Course>
            {
                new Course{iD = 1, credits = 200, instructorName = "John Doe", name = "Neranjan Mendis"},
                new Course{iD = 2, credits = 600, instructorName = "John Doe", name = "Dayan Mendis"},
                new Course{iD = 3, credits = 900, instructorName = "John Doe", name = "Ewerdney Mendis"},
                new Course{iD = 4, credits = 100, instructorName = "John Doe", name = "Dan Mendis"}
            };
            return list;
        }

    }
}

using Angular_With_Legacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Angular_With_Legacy
{
    //Creating WCF Service/////////////////////////
    //step1-create a WCF service
    //step2-Create ur method in this file, as following :
    //step3-change some settings in the webConfig file
    //step4-goto this site and see whether it is working? 'http://localhost:50760/DataServiceWCF.svc/courses/ '
    [ServiceContract]
    public interface IDataServiceWCF
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "courses/")]
        List<Course> GetCourses();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "courses/{id}")]
        Course GetCourse(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Bare, 
            UriTemplate = "courses/{id}")]
        Course UpdateCourse(int id, Course course);
    }
}

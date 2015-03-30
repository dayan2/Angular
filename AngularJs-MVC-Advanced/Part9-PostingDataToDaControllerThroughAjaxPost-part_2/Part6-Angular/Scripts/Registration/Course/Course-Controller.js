
registrationModule.controller('CoursesController', function ($scope, CourseRepository) {

    //calling the 'CourseRepository' get property(method), then it will send the promise, which could be a success or error msg
    CourseRepository.get().then(function (courses) {
        //this function is for the success msg(Error function is not that necessary in this case)
        //if it is a success it will send the course data as well to this function
        $scope.courses = courses;
    });

});
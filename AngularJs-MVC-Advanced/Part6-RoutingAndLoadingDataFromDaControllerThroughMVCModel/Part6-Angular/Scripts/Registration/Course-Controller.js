//registrationModule.controller('CourseController', function ($scope) {
//    $scope.values = "hello ";
//});

registrationModule.controller('CoursesController', function ($scope, bootstrapData) {
    //bringing another parameter which is the data from the service u have created, and giving the value to it.....(to run in the ng-repeat)
    $scope.courses = bootstrapData.courses;
});

registrationModule.controller('CoursesController', function ($scope, CourseRepository) {

    //calling the 'CourseRepository' get property(method), then it will send the promise, which could be a success or error msg through $resourse
    //$resourse can be directly put into the $scope value
    $scope.courses = CourseRepository.get();
});
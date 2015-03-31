'use strict';

registrationModule.controller('InstructorsController', function ($scope, InstructorRepository) {    
    
    //calling the 'InstructorRepository' get property(method), then it will send the promise, which could be a success or error msg through $resourse
    //$resourse can be directly put into the $scope value
    $scope.instructors = InstructorRepository.get();
});
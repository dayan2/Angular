'use strict';

registrationModule.controller('InstructorsController', function ($scope, InstructorRepository) {    

    InstructorRepository.get().then(function (instructors) {
        //this function is for the success msg(Error function is not that necessary in this case)
        //if it is a success it will send the instructors data as well to this function
        $scope.instructors = instructors;
    });
});
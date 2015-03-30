'use strict';

registrationModule.controller("InstructorsController", function ($scope, bootstrapInstructors) {
    //bringing another parameter which is the data from the service u have created, and giving the value to it.....(to run in the ng-repeat)
    $scope.instructors = bootstrapInstructors.instructors;
});
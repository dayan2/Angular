var registrationModule = angular.module('registrationModule', ['ngRoute']);

registrationModule.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/Courses', {
        templateUrl: '/templates/Courses.html',
        controller: 'CoursesController'
    }).
    when('/Instructors', {
        templateUrl: '/templates/Instructors.html',
        controller: 'InstructorsController'
    });

}]);

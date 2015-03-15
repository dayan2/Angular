var myApp = angular.module('myApp', ['ngRoute', 'myApp']);

myApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/Courses', {
        templateUrl: '/templates/partial1.html',
        controller: 'controller'
    });
}]);
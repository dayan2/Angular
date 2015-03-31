'use strict';

registrationModule.controller('AccountController', function ($scope, AccountRepository, $location) {

    $scope.save = function (student) {
        $scope.errors = [];
        //nothing changing adding '$promise' to middle
        AccountRepository.save(student).$promise.then(
            function () { $location.url('/api/Registration');},
            function (response) { $scope.errors = response.data; }//getting the errorDescription arrary from the MVC controller as response
            );
    };
});
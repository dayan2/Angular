'use strict';

registrationModule.controller('AccountController', function ($scope, AccountRepository, $location) {

    $scope.save = function (student) {
        $scope.error = false;
        //nothing changing adding '$promise' to middle
        AccountRepository.save(student).$promise.then(
            function () { $location.url('/Registration');},
            function () { $scope.error = true;}
            );
    };
});
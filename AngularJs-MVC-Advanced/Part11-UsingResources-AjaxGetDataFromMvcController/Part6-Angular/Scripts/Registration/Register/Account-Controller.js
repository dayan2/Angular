'use strict';

registrationModule.controller('AccountController', function ($scope, AccountRepository, $location) {

    $scope.save = function (student) {
        $scope.error = false;
        AccountRepository.save(student).then(
            function () { $location.url('/Registration');},
            function () { $scope.error = true;}
            );
    };
});
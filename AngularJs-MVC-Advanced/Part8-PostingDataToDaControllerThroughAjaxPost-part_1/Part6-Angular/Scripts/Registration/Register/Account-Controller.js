'use strict';

registrationModule.controller('AccountController', function ($scope, AccountRepository) {

    $scope.save = function (student) {
        AccountRepository.save(student);
    };
});
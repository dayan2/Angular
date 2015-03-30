//this is like a service
registrationModule.factory('AccountRepository', function ($http, $q) {
    return {
        save: function (student) {
            var deferred = $q.defer();

            //posting student instance to the controller, if it succeed redirect to CoursePage otherwise give an error msg
            $http.post('/RegisterUser/Save', student)
            .success(function () { deferred.resolve(); })
            .error(function () { deferred.reject(); });

            return deferred.promise;
        }
    };
});
//this is like a service
registrationModule.factory('InstructorRepository', function ($http, $q) {
    return {
        get: function () {
            //creating a deferred object
            var deferred = $q.defer();

            //requesting for the Json and when it succeed this will call deferred.resolve if not it will call deferred.reject
            $http.get('/api/Instructor').success(deferred.resolve).error(deferred.reject);//(MVC controller inside $http.get()  )

            //return the promise(message) 
            return deferred.promise;
        }
    };
});
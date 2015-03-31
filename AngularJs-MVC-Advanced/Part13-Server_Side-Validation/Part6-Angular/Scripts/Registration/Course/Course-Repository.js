//when ur using '$resourse' u don't need to use '$http, $q' - promises and http connections are built in $resourse
registrationModule.factory('CourseRepository', function ($resource) {
    return {
        get: function () {

            //requesting for the Json and returning the promise
            return $resource('/api/Course').query();//u insert here 'query' because ur requesting for a List(if it is a single data u can use .get)

        }
    };
});

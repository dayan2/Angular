//when ur using '$resourse' u don't need to use '$http, $q' - promises and http connections are built in $resourse
registrationModule.factory('AccountRepository', function ($resource) {
    return {
        save: function (student) {
            //posting student instance to the controller, if it succeed redirect to CoursePage otherwise give an error msg
            return $resource('/api/RegisterUser').save(student);
        }
    };
});
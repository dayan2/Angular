//this is like a service
registrationModule.factory('AccountRepository', function ($http, $q) {
    return {
        save: function (student) {
            //posting the student instance to the controller
            $http.post('/RegisterUser/Save' , student);//(MVC controller inside $http.get()  )

        }
    };
});
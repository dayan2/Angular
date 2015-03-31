
app.value('followedInstructors', [
    { id: 1, name: 'Professor Snape' },
    { id: 2, name: 'Professor McGonagal' },
    { id: 3, name: 'Professor Dumbaldore' }
]);


app.value('catalog', [
    { id: 1, name: "70's Studies", credits: 3, instructorName: "Professor Dumbledore" },
    { id: 2, name: "Care Creatures", credits: 3, instructorName: "Professor Sluger" },
    { id: 3, name: "Plagarism in 21 st century", credits: 3, instructorName: "Professor Dumbledore" },
    { id: 4, name: "Defense Art", credits: 3, instructorName: "Professor Snape" },
    { id: 5, name: "Chemistry", credits: 3, instructorName: "Professor McGonagal" },
    { id: 6, name: "Bio", credits: 3, instructorName: "Professor Sluger" },
    { id: 7, name: "Enviroment Studies", credits: 3, instructorName: "Professor Snape" }
]);

//------------------------ 1 - Using Global variables------------------------------//
//app.value('currentUser', currentUser);//putting the global variable into a service


////---------------- 2 - Get value by ajax async way(User)------------------------------//
app.service("GetCurrentUser", function ($http, $q) {
    var deferred = $q.defer();
    $http.get('/Home/GetCurrentUser').then(function (data) {
        console.log("service: " + data);
        deferred.resolve(data);

    });
    this.getUser = function () {
        return deferred.promise;
    };
});


////---------------- 2 - Get value by ajax async way(catalog)------------------------------//
//app.service("GetCatalog", function ($http, $q) {
//    var deferred = $q.defer();
//    $http.get('/Home/GetCatalog').then(function (data) {        
//        deferred.resolve(data);
//        console.log("service-catalog: " + data);

//    });
//    this.getCat = function () {
//        return deferred.promise;
//    };
//});

////---------------- 3 - Get value by ajax async way(catalog)------------------------------//
//app.factory('GetCatalogs', function ($http) {
//    //creating an array to push the necessary data 
//    var catalog = [];

//    return {
//        get: function () {
//            $http.get('/Home/GetCatalog').then(function (response) {
//                catalog.length = 0;

//                response.data.forEach(function (item) {
//                    catalog.push({ id: item.id, name: item.name, instructorName: item.instructorName, credits: item.credits });
//                });
//            })
//            return catalog;
//        }

//    }

//});

////---------------- 4 - Get value by WCF service------------------------------//
app.factory('GetCatalogs', function ($resource) {
    return $resource('/DataServiceWCF.svc/courses');
});



////---------------- 3 - Get value by ajax async way(user)------------------------------//
//app.factory('GetCurrentUser', function ($http) {    

//return {
//    get: function () {
//        $http.get('/Home/GetCurrentUser').then(function (response) {                
//            user = response.data;
//            console.log("user: " + user.name);
//            return response.data;
//        })
//        return user;
//    }
//}

//var GetCurrentUser = {
//    get: function () {
//        $http.get('/Home/GetCurrentUser').then(function (response) {
//            var user = "";
//            user = response.data;
//            console.log("user: " + user.name);
//            return response.data;
//            return user;
//        })

//    }
//};
//console.log("GetCurrentUser: " + GetCurrentUser);
//return GetCurrentUser;


//});
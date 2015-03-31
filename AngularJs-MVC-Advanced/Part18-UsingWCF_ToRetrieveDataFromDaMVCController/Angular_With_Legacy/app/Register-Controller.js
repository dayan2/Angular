//bringing in 5 services in plus scope
app.controller('registerController', function ($scope, toastr, identity, catalog, followedInstructors, GetCatalogs, GetCurrentUser) {
    //bring-in the services and puting them in scope
    $scope.identity = identity;

    //-------------------- factory GetCatalogs ---------------//
    //$scope.catalog = GetCatalogs.get();

    //-------------------- WCF service factory GetCatalogs ---------------//
    $scope.catalog = GetCatalogs.query();

    //$scope.followedInstructors = followedInstructors;

    //-------------------- factory GetCatalogs ---------------//
    //$scope.identity.currentUser = GetCurrentUser.GetCurrentUser.get();
    //console.log("$scope.identity.currentUser: " + $scope.identity.currentUser);

    //$scope.identity.currentUser = Repository.get();
    //console.log($scope.identity.currentUser);

    //----------------------Service GetCurrentUser----------------------//
    var promise = GetCurrentUser.getUser();
    promise.then(function (data) {
        $scope.identity.currentUser = data;
        console.log("controller: " + data.data.name);
    }
    , function (reason) {
        alert('Failed: ' + reason);
    }
    );

    //-------------------------------Service 'GetCatalog' -----------------//
    //var promise = GetCatalog.getCat();
    //promise.then(function (data) {
    //    $scope.catalog = data;
    //    console.log("controller: " + data.data);
    //}
    //,function(reason)
    //{
    //    alert('Failed: ' + reason);
    //}
    //);

    /////////////////////////////////////////////////////////////

    ////http://www.webdeveasy.com/angularjs-data-model/

    /////////////////////////////////////////////////////



});
app.controller('SheduleController', function ($scope, notifier) {
    $scope.unRegisterCourse = function (course) {
        //course.registered = false;
        //course.$save();
        //notifier.notify('You have unRegistered for   ' + course.name);

        //$scope.catalog.remove({ name: course.name });
        //notifier.notify('You have registered for - ' + course.name);

        var index = $scope.catalog.indexOf(course);
        $scope.catalog.splice(index, 1);
        notifier.notify('You have registered for - ' + course.name);

    };
});
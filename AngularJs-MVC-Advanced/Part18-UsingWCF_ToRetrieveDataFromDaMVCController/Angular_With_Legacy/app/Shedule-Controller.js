app.controller('SheduleController', function ($scope) {
    $scope.unRegisterCourse = function (course) {
        course.registered = false;
        course.$save();
        notifier.notify('You have unRegistered for   ' + course.name);
    };
});
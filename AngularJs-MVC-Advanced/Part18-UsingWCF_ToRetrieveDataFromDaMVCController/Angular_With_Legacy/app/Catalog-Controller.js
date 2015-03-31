app.controller('CatalogController', function ($scope, notifier) {
    $scope.registerCourse = function (course) {
        course.registered = false;
        course.$save();
        notifier.notify('You have registered for - ' + course.name);
    };

    $scope.followInstructor = function (instructorName) {
        var found = false;
        $scope.followedInstructors.foreach(function (instructor) {
            if (instructor.name === instructorName) {
                found = true;
            }
        });

        if (!found) {
            $scope.followedInstructors.push({ name: instructorName });
            notifier.notify('You are now following  ' + instructorName);
        }

    };

});
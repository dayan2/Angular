app.controller('CatalogController', function ($scope, notifier) {
    $scope.registerCourse = function (course) {
        //course.registered = false;
        //course.$save();
        //notifier.notify('You have registered for - ' + course.name);

        $scope.catalog.push({ name: course.name, credits: course.credits, instructorName: course.instructorName });
        notifier.notify('You have registered for - ' + course.name);

    };

    $scope.followInstructor = function (instructorName) {
        var found = false;
        $scope.followedInstructors.forEach(function (instructor) {
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
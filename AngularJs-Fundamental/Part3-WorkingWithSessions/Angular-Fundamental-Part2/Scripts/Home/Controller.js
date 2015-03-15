myApp.controller("HomeCntrl", function ($scope) {
    $scope.values = {
        Name: "dayan mendis",
        Date: "1/1/2015",
        time: "10.30pm",
        Location: {
            Address: "Google SriLanka",
            City: "Colombo"
        },
        //Creating Sessions
        Sessions:[
            {
                Name: "Classes Directory",
                CreatorName: "Bob Smith"
            },
            {
                Name: "Views Directory",
                CreatorName: "John Doe"
            },
            {
                Name: "Modules Directory",
                CreatorName: "Adam Quote"
            }
        ]
    }
});
var app = angular.module('app', []);

//prompting login details in the Console
$.connection.hub.logging = true;

//Telling SignalR to Start 
$.connection.hub.start();


//Error
$.connection.hub.error(function (err) {
    console.log('An error Occurred   ' + err);
});

//defining the 'ChatHub' class 
angular.module('app').value('chat', $.connection.chat);



app.controller('MainController', function ($scope, chat) {
    //declaring an Array for messages to store
    $scope.messages = [];


    //when u click the 'send' button
    $scope.sendMessage = function () {
        //sending the textBox message to the chatHub
        chat.server.sendMessage($scope.newMessage);

        //prompting the messages which are sent to the Hub
        alert("Message new : " + $scope.newMessage);
        console.log("Message new : " + $scope.newMessage);

        //clearing the textbox
        $scope.newMessage = "";

    };


    //Calling the 'newMessage()' inside 'SendMessage()' to get each message and will add into an array
    chat.client.newMessage = function onNewMessage(message) {

        //adding each element to the array
        $scope.messages.push({ message: message });

        //without this array elements will be not inserted
        $scope.$apply();

        //displaying in Console
        console.log(message);
    };

});

app.controller('MainController', function ($scope, chat) {
    //declaring an Array for messages to store
    $scope.messages = [];

    $scope.inRoom = false;
    $scope.nameSet = false;

    $scope.setName = function () {
        $scope.nameSet = true;
    };

    $scope.joinRoom = function () {
        $scope.inRoom = true;

        //tell server to add
        chat.server.joinRoom($scope.roomName);
    };

    $scope.leaveRoom = function () {
        $scope.inRoom = false;

        //tell server to remove from da room
        chat.server.leaveRoom($scope.roomName);

    };

    //when u click the 'send' button
    $scope.sendMessage = function () {

        //sending the textBox message ,room and userName to the 'sendMessage()' in chatHub
        chat.server.sendMessage({ name : $scope.name , message : $scope.newMessage, roomName: $scope.roomName});

        //prompting the messages which are sent to the Hub
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
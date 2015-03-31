var app = angular.module('app', ['ngResource']);

//defining services - 3 services
app.value('identity', {});//Identity service is for keep track of the current user
app.value('toastr', toastr);

app.factory('notifier', function (toastr) {
    return {
        notify: function (msg) {
            toastr.success(msg);
            console.log(msg);
        }
    };
});//notifier service allows to notify messages for da user
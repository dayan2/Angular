var myApp = angular.module('myApp', [
	'ngRoute',
	'artistControllers'
]);

myApp.config(['$routeProvider',function($routeProvider){
	$routeProvider.
	when('/list', {
		templateUrl: 'partials/list.html',
		controller: 'ListController'
	}).
	when('/details/:itemid', {
		templateUrl: 'partials/details.html',
		controller: 'detailsController'
	}).
	otherwise({
		redirectTo:'/list'
	});
}]);
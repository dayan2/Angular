var artistControllers = angular.module('artistControllers', []);

artistControllers.controller('ListController', ['$scope','$http', function($scope,$http) {
  $http.get('js/data.json').success(function(data){
      $scope.artists = data;
  });
}]);


artistControllers.controller('detailsController',['$scope','$http','$routeParams', function($scope,$http,$routeParams){
	$http.get('js/data.json').success(function(data){
		$scope.artists = data;
		$scope.whichItem = $routeParams.itemid;

		if($routeParams.itemid > 0)	{
			$scope.prevItem = Number($routeParams.itemid)-1;
		}else{
			$scope.prevItem = ($scope.artists.length)-1;
		}
		if($routeParams.itemid < ($scope.artists.length) - 1)
		{
			$scope.nextItem = Number($routeParams.itemid)+1;
		}else{
			$scope.nextItem = 0;
		}
	});
}]);
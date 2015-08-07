var LoginController = function ($scope, $routeParams) {
	var loginForm =
	{
		emailAddress: "",
		password: "",
		rememberMe: false,
		returnUrl: $routeParams
	};

	$scope.login = function () {

	}
}

LoginController.$inject = ["$scope", "$routeParams"];
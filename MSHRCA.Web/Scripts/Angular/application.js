var Application = angular.module("Application", ["ngRoute"]);

Application.controller("HomePageController", HomePageController);
Application.controller("LoginController", LoginController);

Application.factory("AuthHTTPResponseInterception", AuthHTTPResponseInterception);

var configFunction = function ($routeProvider, $httpProvider) {
	$routeProvider
		.when("/First", {
			templateUrl: "routes/First"
		})
		.when("/Second", {
			templateUrl: "routes/Second"
		})
		.when("/Third", {
			templateUrl: "routes/Third"
		})
		.when("/Login", {
			templateUrl: "/Account/Login",
			Controller: LoginController
		});

	$httpProvider.interceptors.push("AuthHTTPResponseInterception");
}
configFunction.$inject = ["$routeProvider", "$httpProvider"];

Application.config(configFunction);
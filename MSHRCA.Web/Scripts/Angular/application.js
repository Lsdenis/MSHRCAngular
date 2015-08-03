var Application = angular.module("Application", ["ngRoute"]);

Application.controller("HomePageController", HomePageController);

var configFunction = function ($routeProvider) {
    $routeProvider
        .when("/First", {
            templateUrl: "routes/First"
        })
        .when("/Second", {
            templateUrl: "routes/Second"
        })
        .when("/Third", {
            templateUrl: "routes/Third"
        });
}
configFunction.$inject = ["$routeProvider"];

Application.config(configFunction);
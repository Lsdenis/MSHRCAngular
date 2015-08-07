var AuthHTTPResponseInterception = function ($q, $location) {
	return {
		response: function (response) {
			if (response.status == 401) {
				console.log("Response 401");
			}
		},
		responseError: function (rejection) {
			if (rejection.status == 401) {
				console.log("Response error 401", rejection);
				$location.path('/login').search('returnUrl', $location.path());
			}

			return $q.reject(rejection);
		}
	}
}

AuthHTTPResponseInterception.$inject = ["$q", '$location'];


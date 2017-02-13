var app;
(function () {
    app = angular.module('myApp', ['ngRoute']);
    app.controller('HomeController', function ($scope)
    {
        $scope.message="Wellcom to angular"
    })
})();
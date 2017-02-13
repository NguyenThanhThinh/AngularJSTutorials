/// <reference path="../angular.min.js" />
var app = angular.module('myApp', []);
app.controller('myController', function ($scope) {
    $scope.firstName = 'Thịnh';
    $scope.lastName = 'Nguyễn Thành';
});
app.directive('w3TestDirective', function ($scope) {
    return {
        template: "I was made in a directive constructor!"
    };
});
(function () {

    var app = angular.module("personApp", []);

    var appController = function ($scope, $http) {

        $scope.sortVar = "+Name";

        $scope.getData = function () {
            $http.get('/api/person/get')
                .then(function (response) {
                    $scope.data = response.data;
                });
        }

        $scope.sendData = function () {
            $http.post('/api/person/post', $scope.Person)
                .then(function (response) {
                    document.getElementById("leForm").reset();
                });
        }

        $scope.editData = function (d) {
            $http.post('/api/person/edit', d);
        }

        $scope.toEdit = function (d) {
            $scope.editPerson = d;
        }

        $scope.delete = function (d) {
            $http.get('/api/person/delete?p=' + d);
        }

        $scope.sortName = function () {
            $scope.sortVar = "+Name";
        }

        $scope.sortCity = function () {
            $scope.sortVar = "+City";
        }

        $scope.sortOccu = function () {
            $scope.sortVar = "+Occupation";
        }

    }

    app.controller("appController", ["$scope", "$http", appController]);

}());
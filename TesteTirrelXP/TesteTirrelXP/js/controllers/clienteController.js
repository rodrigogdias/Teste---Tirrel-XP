var clienteController;

app.controller("clienteController", function ($scope, $http, $rootScope, $location, $timeout) {

    $scope.Save = function () {
        try {
            $http.post('Cliente/Save', $scope.oCliente)
            .success(function (data, status, headers, config) {
                $location.path("cadCliente");
                alert("Cadastro realizado com sucesso!")
                delete $scope.oCliente;
            }).error(function (data, status, header, config) {
                alert("erro");
            });
        } catch (err) {
            console.log("clienteController >> Save >> " + err.message);
        }
    }

    $scope.ListCliente = function () {
        try {
            $http.get('Cliente/List')
            .success(function (data, status, headers, config) {
                $scope.Clientes = data;
            }).error(function (data, status, header, config) {
                alert("erro");
            });
        } catch (err) {
            console.log("clienteController >> ListCliente >> " + err.message);
        }
    }

    $scope.GetCliente = function (sIdCliente) {
        try {
            $http.get('Cliente/Get/' + sIdCliente)
            .success(function (data, status, headers, config) {
                $scope.oCliente = data;
            }).error(function (data, status, header, config) {
                alert("erro");
            });
        } catch (err) {
            console.log("clienteController >> ListCliente >> " + err.message);
        }
    }

    $scope.Update = function () {
        try {
            $http.post('Cliente/Update', $scope.oCliente)
            .success(function (data, status, headers, config) {
                $location.path("manutencaoCliente");
                alert("Cliente alterado sucesso!")
                delete $scope.oCliente;
            }).error(function (data, status, header, config) {
                alert("erro");
            });
        } catch (err) {
            console.log("clienteController >> Update >> " + err.message);
        }
    }

    clienteController = $scope;
    clienteController.ListCliente();
});
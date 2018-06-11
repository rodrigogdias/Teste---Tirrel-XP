var vendedorController;

app.controller("vendedorController", function ($scope, $http, $rootScope, $location, $timeout) {

    $scope.Login = function () {
        try {
            $http.get('Vendedor/Login/' + $scope.oVendedor.Login + '/' + $scope.oVendedor.Senha)
            .success(function (data, status, headers, config) {
                if (data == true) {
                    $location.path("manutencaoCliente");
                } else {
                    alert("Usuario/Senha inválida")
                    $location.path("loginVendedor");
                }
            }).error(function (data, status, header, config) {
                alert("erro");
            });
        } catch (err) {
            console.log("gatewayController >> Insert >> " + err.message);
        }
    }

    clienteController = $scope;
});
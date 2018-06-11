var app = angular.module('app', ['ngRoute']);

app.config(function ($routeProvider, $locationProvider) {

    $routeProvider

    .when("/cadCliente", {
        templateUrl: "views/cadCliente.html",
        controller: "clienteController"
    })

    .when("/manutencaoCliente", {
        templateUrl: "views/manutencaoCliente.html",
        controller: "clienteController"
    })

    .when("/loginVendedor", {
        templateUrl: "views/loginVendedor.html",
        controller: "vendedorController"
    })

});
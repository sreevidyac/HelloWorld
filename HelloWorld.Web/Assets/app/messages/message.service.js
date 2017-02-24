(function() {
    angular.module('app')
        .factory('messageService', messageService);

    messageService.$inject = ['$http'];

    function messageService($http) {
        var service = {
            GetMessage: getMessage
        };

        function getMessage() {
            return $http.get('/api/message/');
        }

        return service;
    }
})(angular);
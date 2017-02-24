(function() {
    angular.module('app')
        .controller('messageController', messageController);

    messageController.$inject = ['messageService'];

    function messageController(messageService) {
        var vm = this;

        vm.message = '';

        function activate() {
            messageService.GetMessage().then(function(result) {
                if (result.status == 200) {
                    vm.message = result.data;
                }
            });
        }

        activate();
    }
})(angular);
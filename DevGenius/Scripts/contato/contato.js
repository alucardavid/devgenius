var main = function () {

    $('#contato').submit(function (e) {
        e.preventDefault();
        EnviarContato($(this));
    });




    // ENVIAR CONTATO
    function EnviarContato(form) {
        var dados = form.serialize();

        $.confirm({
            title: "DevGenius",
            content: function () {
                
                var self = this;
                return $.ajax({
                    type: "POST",
                    url: "/Contato/SalvarContato",
                    data: dados
                }).done(function (r) {
                    self.setContent(r);
                }).fail(function (r) {
                    self.setContent(r);
                });
            },
            buttons: {
                Ok: function () {

                }
            }
        });
    }

};

$(document).ready(main);
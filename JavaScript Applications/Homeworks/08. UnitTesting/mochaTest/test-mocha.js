(function () {
    requirejs.config({
        paths: {
            'jquery': '../scripts/libs/jquery.min',
            'mocha': '../scripts/libs/mocha',
            'chai': '../scripts/libs/chai',
            'sinon': '../scripts/libs/sinon',
            'httpRequest' : '../scripts/crowdChat/httpRequest',
            'Q' : '../scripts/libs/q.min'
        }
    });

    require(['mocha', 'chai', 'sinon'], function () {
        mocha.setup('bdd');
        require(['mochaTests'], function() {
            mocha.run();
        });
    });
}());

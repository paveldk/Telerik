(function () {
    requirejs.config({
        paths: {
            'jquery': '../scripts/libs/jquery.min',
            'mocha': '../scripts/libs/mocha',
            'chai': '../scripts/libs/chai',
            'sinon': '../scripts/libs/sinon',
            'httpRequest' : '../scripts/crowdChat/httpRequest',
            'Q' : '../scripts/libs/q.min',
            'logic': '../scripts/crowdChat/logic',
            'sammy': "../scripts/libs/sammy-latest.min",
            'handlebars': "../scripts/libs/handlebars",
            'kendo': "../scripts/libs/kendo.web.min",
            'cryptojs': '../scripts/libs/cryptojs',
            'sha1': '../scripts/libs/sha1',
            'underscore': '../scripts/libs/underscore',
            'ui': "../scripts/crowdChat/ui",
            'events': "../scripts/crowdChat/events"
        }
    });

    require(['mocha', 'chai', 'sinon'], function () {
        mocha.setup('bdd');
        require(['mochaTests'], function() {
            mocha.run();
        });
    });
}());

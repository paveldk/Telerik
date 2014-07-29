var tests = [];
for (var file in window.__karma__.files) {
    if (/Tests\.js$/.test(file)) {
        tests.push(file);
    }
}

requirejs.config({
    // Karma serves files from '/base'
    baseUrl: '/base/scripts',

    paths: {
        'jquery': 'libs/jquery.min',
        'underscore': 'libs/underscore',
        'logic': 'crowdChat/logic',
        'ui' : 'crowdChat/ui',
        'httpRequest' : 'crowdChat/httpRequest'
    },

    shim: {
        'underscore': {
            exports: '_'
        }
    },

    // ask Require.js to load these files (all our tests)
    deps: tests,

    // start test run, once Require.js is done
    callback: window.__karma__.start
});

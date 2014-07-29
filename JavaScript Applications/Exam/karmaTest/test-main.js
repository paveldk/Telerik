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
		'jquery': '../scripts/libs/jquery.min',
		'mocha': '../scripts/libs/mocha',
		'chai': '../scripts/libs/chai',
		'sinon': '../scripts/libs/sinon',
		'httpRequest' : '../scripts/crowdShare/httpRequest',
		'Q' : '../scripts/libs/q.min',
		'logic': '../scripts/crowdShare/logic',
		'sammy': "../scripts/libs/sammy-latest.min",
		'handlebars': "../scripts/libs/handlebars",
		'kendo': "../scripts/libs/kendo.web.min",
		'cryptojs': '../scripts/libs/cryptojs',
		'sha1': '../scripts/libs/sha1',
		'underscore': '../scripts/libs/underscore',
		'ui': "../scripts/crowdShare/ui",
		'events': "../scripts/crowdShare/events"
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

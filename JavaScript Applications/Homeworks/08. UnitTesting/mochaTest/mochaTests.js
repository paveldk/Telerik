define(['chai', 'jquery', 'httpRequest', 'Q'], function(chai, $, httpRequest) {
	var url = "http://crowd-chat.herokuapp.com/posts",
		contentType = 'application/json',
		acceptType = 'application/json';

	describe('AJAX', function() {
		var expect = chai.expect;

		beforeEach(function() {
			sandbox = sinon.sandbox.create();
		});

		afterEach(function () {
			sandbox.restore();
		});
		
		it("should make a request to the correct URL", function() {
			sandbox.spy($, "ajax");
			httpRequest.postJSON(url);
			expect($.ajax.getCall(0).args[0]['url']).to.equal("http://crowd-chat.herokuapp.com/posts");
		});

		it("should send correct Data", function() {
			sandbox.spy($, "ajax");
			httpRequest.postJSON(url, contentType,  acceptType, 'Hello world');
			expect($.ajax.getCall(0).args[0]['data']).to.equal('"Hello world"');
		});

		it("should get a request from the correct URL", function() {
			sandbox.spy($, "ajax");
			httpRequest.getJSON(url);
			expect($.ajax.getCall(0).args[0]['url']).to.equal("http://crowd-chat.herokuapp.com/posts");
		});

		it("should recieve a data", function(done) {
			sandbox.spy($, "ajax");
			this.timeout(30000);

			// This is async, so should wait a little bit and will get the resul that it's passed
			httpRequest.getJSON(url, contentType, acceptType)
				.then(function (data) {
					setTimeout(30000);
					expect(data.length).not.to.equal(0);
					done();
				});
		});
	});

/*    describe('UI', function() {
		it("should load home page correctly", function() {
			var title = $(document).load("index.html")

			expect(title.innerHTML).to.equal('Karma v0.12.17 - connected');
		});
	});*/
});

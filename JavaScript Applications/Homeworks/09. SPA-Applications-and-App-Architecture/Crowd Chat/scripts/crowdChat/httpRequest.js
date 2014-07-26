define(['jquery', 'rsvp'], function () {
	var httpRequest = (function () {
		var getJSON = function(url, contentType, acceptType) {
			var promise = new RSVP.Promise(function (resolve, reject) {
				$.ajax({
					url: url,
					type: 'GET',
					contentType : contentType || '',
					acceptType : acceptType || '',
					success: function (data) {
						resolve(data);
					},
					error: function (err) {
						reject(err);
					}
				});
			});

			return promise;
		};

		var postJSON = function(url, contentType, acceptType, data) {
			var promise = new RSVP.Promise(function (resolve, reject) {
				if (data) {
					data = JSON.stringify(data);
				}
				else {
					data = {_method: 'delete'};
				}

				$.ajax({
					url: url,
					type: "POST",
					contentType: contentType,
					acceptType: acceptType,
					data: data,
					success: function (data) {
						resolve(data);
					},
					error: function (err) {
						reject(err);
					}
				});
			});
			return promise;
		};

		return {
			getJSON: getJSON,
			postJSON: postJSON
		};
	}());
	return httpRequest;
});
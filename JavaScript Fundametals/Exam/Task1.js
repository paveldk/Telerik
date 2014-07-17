function Solve(args) {
	var leva = parseInt(args[0]),
		firstCakePrice = parseInt(args[1]),
		secondCakePrice = parseInt(args[2]),
		thirdCakePrice = parseInt(args[3]),
		maxLeva = parseInt(0);

	for (var i = 0; i <= leva/firstCakePrice; i++) {
		for (var j = 0; j < leva/secondCakePrice; j++) {
			for (var k = 0; k < leva/thirdCakePrice; k++) {
				var currentSum = parseInt(i * firstCakePrice + j * secondCakePrice + k * thirdCakePrice);
				if ((currentSum > maxLeva) && currentSum <= leva) {
					maxLeva = currentSum;
				};	
			};
		};	
	};	
	return maxLeva;
}

test1 = [
	'110',
	'13',
	'15',
	'17',
];


test2 = [
'20',
'11',
'200',
'300',

];

Solve(test1);	
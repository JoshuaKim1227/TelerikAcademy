var args = [ "3","-1","-10","-15" ];

console.log(Solve(args));

function Solve(args) {
	var numbers = [];
	var currentSum = 0;
	var bestSum = -1000000;

	for (var index = 1; index < args.length; index++) {
		numbers.push(parseInt(args[index]));
	}

	for (var position = 0; position < numbers.length - 1; position++) {
		currentSum = numbers[position];

		if (numbers[position] >= 0) {
			while (position < numbers.length - 1) {
				currentSum += numbers[position + 1];

				if (bestSum < currentSum) {
					bestSum = currentSum;
				}

				if (currentSum < 0) {
					currentSum = 0;
				}

				position++;
			}
		}
		else if (bestSum < currentSum) {
			bestSum = currentSum;
		}

		currentSum = 0;
	}

	return bestSum;
}
args = ["7","1","2","-3","4","4","0","1"];

console.log(Solve(args));

function Solve(args) {
	var numbers = [];
	var seqCounter = 0;
	var nextNum = 2000000001;
	var sequenceCounted = false;

	for (var index = 1; index < args.length; index++) {
		numbers[index - 1] = parseInt(args[index]);
	}

	for (var index = 0; index < numbers.length; index++) {
		nextNum = numbers[index + 1];

		if (nextNum >= numbers[index]) {
			continue;
		}
		seqCounter++;
	}

	return seqCounter;
}
args = ["6 7 4",
		"0 0",
		"2 2",
		"-2 2",
		"3 -1",
		"-1 -1"];

console.log(Solve(args));

function Solve(args) {
	// Initializing variables
	var fieldSizeStr = args[0].split(" ");
	var fieldSize = [];
	var field = [];
	var jumpsCount = parseInt(fieldSizeStr.pop());
	var startPosStr = args[1].split(" ");
	var startPos = [];
	var jumpsStr = [];
	var jumps = [];
	var counter = 1;
	var valueCounter;
	var currentPos = [];
	var nextPos = [];
	var visited = [];
	var numberOfJumps = 1;

	// Parsing input
	for (var index = 0; index < fieldSizeStr.length; index++) {
		fieldSize[index] = parseInt(fieldSizeStr[index]);
	}

	// Parsing input
	for (var index = 0; index < startPosStr.length; index++) {
		startPos[index] = parseInt(startPosStr[index]);
	}

	// Parsing input
	for (var jump = 0; jump < jumpsCount; jump++) {
		jumpsStr[jump] = args[jump + 2].split(" ");
		jumps[jump] = [];

		for (var index = 0; index < jumpsStr[jump].length; index++) {
			jumps[jump][index] = parseInt(jumpsStr[jump][index]);
		}
	}

	// Initializng jump field
	for (var row = 0; row < fieldSize[0]; row++) {
		field[row] = [];
		visited[row] = [];

		for (var col = 0; col < fieldSize[1]; col++) {
			field[row][col] = counter++;
			visited[row][col] = false;
		}
	}


	// Main program
	currentPos = startPos;
	valueCounter = field[startPos[0]][startPos[1]];

	for (var jump = 0; jump < jumps.length; jump++) {
		visited[currentPos[0]][currentPos[1]] = true;

		nextPos = BunnyJump(currentPos, jumps[jump]);
		numberOfJumps++;

		if (nextPos[0] > field[0].length - 1 || nextPos[1] > field[1].length - 1) {
			return "escaped " + valueCounter;
		}
		else {
			valueCounter += field[nextPos[0]][nextPos[1]];
		}

		if (visited[nextPos[0]][nextPos[1]] == true) {
			return "caught " + numberOfJumps;
		}

		currentPos = nextPos;

		if (jump == jumps.length - 1) {
			jump = -1;
		}
	}

	function BunnyJump(position, jumpInfo) {
		var newPosition = position;

		for (var axis = 0; axis < 2; axis++) {
			newPosition[axis] = position[axis] + jumpInfo[axis];
		}

		return newPosition;
	}
}
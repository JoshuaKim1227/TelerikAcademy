args = ["5 8","0 0","rrrrrrrd","rludulrd","lurlddud","urrrldud","ulllllll"];

console.log(Solve(args));

function Solve(args) {
	// Initializing variables
	var fieldSizeStr = args[0].split(" ");
	var fieldSize = [];
	var field = [];
	var startPosStr = args[1].split(" ");
	var startPos = [];
	var currentPos = [];
	var directions = [];
	var isVisited = [];
	var cellValue = 1;

	// Parsing to numbers
	for (var index = 0; index < 2; index++) {
		fieldSize.push(parseInt(fieldSizeStr[index]));
		startPos.push(parseInt(startPosStr[index]));
	}

	// Initializing cell values
	for (var row = 0; row < fieldSize[0]; row++) {
		field[row] = [];
		isVisited[row] = [];

		for (var col = 0; col < fieldSize[1]; col++) {
			field[row].push(cellValue);
			cellValue++;
			isVisited[row].push(false);
		}
	}

	// Getting directions
	for (var row = 0; row < field.length; row++) {
		directions[row] = [];
		directions[row] = args[row + 2].split("");
	}

	// Movement
	var cellCounter = 0;
	var cellValuesCounter = 0;

	currentPos = startPos;

	while (currentPos[0] >= 0 && currentPos[0] < fieldSize[0] && currentPos[1] >= 0 && currentPos[1] < fieldSize[1] ) {
		cellValuesCounter += field[currentPos[0]][currentPos[1]];
		cellCounter++;
		isVisited[currentPos[0]][currentPos[1]] = true;

		currentPos = Move(currentPos[0], currentPos[1], directions);

		if (isVisited[currentPos[0]][currentPos[1]] == true) {
			return "lost " + cellCounter;
		}
	}

	return "out " + cellValuesCounter;

	function Move(positionRow, positionCol, directions) {
	var newPosition = [];

	switch (directions[positionRow][positionCol]) {
		case "l": 
			newPosition[0] = positionRow;
			newPosition[1] = positionCol - 1;
			break;
		case "r": 
			newPosition[0] = positionRow;
			newPosition[1] = positionCol + 1;
			break;
		case "u": 
			newPosition[0] = positionRow - 1;
			newPosition[1] = positionCol;
			break;
		case "d": 
			newPosition[0] = positionRow + 1;
			newPosition[1] = positionCol;
			break;
		}

	return newPosition;
	}
}
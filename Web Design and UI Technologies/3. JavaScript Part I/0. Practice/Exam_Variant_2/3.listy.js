args = ["   def    func min[5, 3, 2  ,    2,    6, 3]",
		"def func2 [5, 3, 7, 2, 6, 3]",
		"def func3 min[func2]",
		"def func4 max[5, 3, 7, 2, 6, 3]",
		"def func5 avg[5, 3, 7, 2, 6, 3]",
		"def func6 sum[func2, func3, func4 ]",
		"sum[func6, func4]"];

console.log(Solve(args));

function Solve(args) {
	for (var line = 0; line < args.length; line++) {
		if (args[line].contains("def")) {
			declareVar(args[0]);
		}
	}


	function declareVar(line) {
		var operation = getOperation(line);
		var list = getList(line);
		var variables = {};
		var funcName = getFuncName(line);

		variables[getFuncName(line)] = 0;
		var b;
		
		processStatement(funcName, operation, list);


		function getFuncName(line) {
			var indexAfterDef = line.indexOf("def") + 3;
			var declarationStr = line.substr(indexAfterDef).trim();
			var funcNameEndIndex = declarationStr.indexOf(" ");
			var result = declarationStr.substring(0, funcNameEndIndex);

			return result;
		}

		function getOperation(line) {
			if (line.contains("min")) {
				return "min";
			}
			else if (line.contains("max")) {
				return "max";
			}
			else if (line.contains("avg")) {
				return "avg";
			}
			else if (line.contains("sum")) {
				return "sum";
			}
			else {
				return "";
			}
		}

		function getList(line) {
			var listStartIndex = line.indexOf("[") + 1;
			var listEndIndex = line.indexOf("]");

			var listStr = line.substring(listStartIndex, listEndIndex);
			
			var list = listStr.split(",");
			
			for (var item = 0; item < list.length; item++) {
				if (/[A-Za-z]/.test(list[item])) {
					list[item] = list[item].trim();
				}
				else {
					list[item] = parseInt(list[item].trim());
				}
			}
			
			return list;
		}

		function processStatement(variables, funcName, operation, list) {
			var funcVar;
			eval("var " + funcName + ";");

			switch (operation) {
				case "min": variables[funcVar] = getMinValue(list); break;
				case "max": variables[funcVar] = getMaxValue(list); break;
				case "avg": variables[funcVar] = getAvgValue(list); break;
				case "sum": variables[funcVar] = getSumValue(list); break;
				default: variables[funcVar] = getArray(list);
			}

			return funcVar;
		}

		function getMinValue(variables, list) {
			var result = 4000000;

			for (var item = 0; item < list.length; item++) {
				if (/[A-Za-z]/.test(list[item])) {
					// ???
				}
				else {
					if (result > list[item]) {
						result = list[item];
					}
				}
			}

			return result;
		}

		function getMaxValue(list) {
			var result = -4000000;

			for (var item = 0; item < list.length; item++) {
				if (/[A-Za-z]/.test(list[item])) {
					getMaxNumber(eval(list[item]));
				}
				else {
					if (result < list[item]) {
						result = list[item];
					}
				}
			}

			return result;
		}

		function getAvgValue(list) {
			var sum = 0;

			for (var item = 0; item < list.length; item++) {
				if (/[A-Za-z]/.test(list[item])) {
					getAvgNumber(eval(list[item]));
				}
				else {
					sum += list[item];
				}
			}

			return parseInt(sum / list.length);
		}

		function getSumValue(list) {
			var sum = 0;

			for (var item = 0; item < list.length; item++) {
				if (/[A-Za-z]/.test(list[item])) {
					getAvgNumber(eval(list[item]));
				}
				else {
					sum += list[item];
				}
			}

			return sum;
		}
	}
}
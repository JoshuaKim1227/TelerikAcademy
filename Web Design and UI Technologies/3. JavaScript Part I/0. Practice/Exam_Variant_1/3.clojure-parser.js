args = ["(def func 10)",
		"(def newFunc (+  func 2))",
		"(def sumFunc (+ func func newFunc 0 0 0))",
		"(* sumFunc 2)"]

console.log(Solve(args));

function Solve(args) {
	var commands = args;
	var operation;

	for (var line = 0; line < commands.length; line++) {
		var operation = commands[0].indexOf("+");
	}
}
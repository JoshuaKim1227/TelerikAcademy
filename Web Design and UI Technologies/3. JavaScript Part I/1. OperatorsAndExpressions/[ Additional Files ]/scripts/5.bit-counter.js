var number = 264;
var position = 3;

var mask = 1 << position;
var result = mask & number;

result = result >> position;

if (result == 1) {
	console.log("The third bit is 1!");
}
else {
	console.log("The third bit is 0!");
}
var circleCenterX = 0;
var circleCenterY = 0;
var circleRadius = 5;

var pointX = 3;
var pointY = 4;

var equationLeftPart = (pointX - circleCenterX) * (pointX - circleCenterX) + (pointY - circleCenterY) * (pointY - circleCenterY);
var equationRightPart = circleRadius * circleRadius;

if (equationLeftPart < equationRightPart) {
	console.log("The point [" + pointX + ", " + pointY + "] is inside the circle!");
}
else {
	console.log("The point [" + pointX + ", " + pointY + "] is not inside the circle!");
}
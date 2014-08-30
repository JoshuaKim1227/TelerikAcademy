var circleCenterX = 1;
var circleCenterY = 1;
var circleRadius = 3;

var rectangleTop = 1;
var rectangleLeft = -1;
var rectangleWidth = 6;
var rectangleHeight = 2;

var pointX = 1;
var pointY = 2;

var isInCircle = false;
var isOutOfRectangle = false;

var equationLeftPart = (pointX - circleCenterX) * (pointX - circleCenterX) + (pointY - circleCenterY) * (pointY - circleCenterY);
var equationRightPart = circleRadius * circleRadius;

if (equationLeftPart < equationRightPart) {
	isInCircle = true;
}

if (pointX >= rectangleLeft || pointX <= rectangleLeft + rectangleWidth ||
	pointY >= rectangleTop || pointY <= rectangleTop - rectangleHeight) {
	isOutOfRectangle = true;
}


if (isInCircle && isOutOfRectangle) {
	console.log("The point [" + pointX + ", " + pointY + " is within the circle and out of the rectangle!");
}
else {
	console.log("The point [" + pointX + ", " + pointY + " is NOT within the circle and out of the rectangle!");
}
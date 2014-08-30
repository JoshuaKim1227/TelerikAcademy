var number = 37;
var maxValue = 100;
var isPrime = true;

for (var devisor = 2; devisor < number; devisor++) {
	if (number % devisor == 0) {
		isPrime = false;
	}	
}

console.log("The number " + number + " is prime: " + isPrime);


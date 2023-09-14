var number = prompt("Enter a three-digit number:");
var reversedNumber = (number % 10) * 100 + ((Math.floor(number / 10) % 10) * 10) + Math.floor(number / 100);
alert("Number backwards: " + reversedNumber);
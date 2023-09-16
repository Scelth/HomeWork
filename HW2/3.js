var number = prompt("Enter a three-digit number: ");

var hundreds = Math.floor(number / 100);
var remainder = number % 100;
var tens = Math.floor(remainder / 10);
var ones = remainder % 10;

if (hundreds === tens || hundreds === ones || tens === ones) {
    alert("There are identical numbers in the number " + number);
} else {
    alert("There are no identical numbers in the number " + number);
}
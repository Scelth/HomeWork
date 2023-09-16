var userInput = prompt("Enter a number from 1 to 9: ");
var number = parseInt(userInput);
var specialChars = ["!", "@", "#", "$", "%", "^", "&", "*", "(", ")"];
var specialChar = specialChars[number - 1];
alert("The special character for the number " + number + " is: " + specialChar);
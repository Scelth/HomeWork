const currentYear = new Date().getFullYear();
var birthYear = prompt("Enter your birth date:");
var age = currentYear - birthYear;
alert("You are " + age + " years old");
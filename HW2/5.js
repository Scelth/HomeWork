var number = prompt("Enter a five-digit number: ");
var numberStr = number.toString();
var reversedStr = numberStr.split("").reverse().join("");
if (numberStr === reversedStr) {
    alert("The number " + number + " is palindrome");
} else {
    alert("The number " + number + " is not palindrome");
}
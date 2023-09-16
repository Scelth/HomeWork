var circumference = prompt("Enter the circumference: ");
var squarePerimeter = prompt("Enter the perimeter of the square: ");

var radius = circumference / (2 * Math.PI);

var squareSide = squarePerimeter / 4;
var squareDiagonal = squareSide * Math.sqrt(2);

if (radius <= squareDiagonal / 2) {
  alert("The circle can fit into the specified square");
} else {
  alert("The circle cannot fit into the specified square");
}
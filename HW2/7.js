var purchaseAmount = prompt("Enter the purchase amount: ");
var discount = 0;

if (purchaseAmount >= 200 && purchaseAmount < 300) {
        discount = 0.03;
} else if (purchaseAmount >= 300 && purchaseAmount < 500) {
        discount = 0.05;
} else if (purchaseAmount >= 500) {
        discount = 0.07;
}

var totalAmount = purchaseAmount * (1 - discount);
alert("The amount to be paid including the discount: " + totalAmount);
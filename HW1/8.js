var money = prompt("Enter the amount of money in the wallet: ");
var price = prompt("Enter the price of one chocolate bar: ");
var chocolatesToBuy = Math.floor(money / price);
var change = money - chocolatesToBuy * price;
alert("You can buy " + chocolatesToBuy + " chocolates and you will have " + change.toFixed(2) + " dollars left.");
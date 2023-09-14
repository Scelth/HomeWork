var money = prompt("Enter the amount of money in the wallet: ");
var price = prompt("Enter the price of one chocolate bar: ");
var chocolatesToBuy = Math.floor(money / price);
var change = money - chocolatesToBuy * price;
alert("Вы можете купить " + chocolatesToBuy + " шоколадок и у вас останется " + change.toFixed(2) + " денег в кошельке.");
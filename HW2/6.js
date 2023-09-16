var currency = prompt("Choose a currency (1 - EUR, 2 - RUB, 3 - AZN): ");
var usd = prompt("Enter the amount in dollars: ");
switch(currency){
    case `1`:
        const usdToEur = 0.93;
        var euro = usd * usdToEur;
        alert(usd + " dollars equals " + euro + " euros");
        break;
    case `2`:
        const usdToRub = 96.8;
        var rub = usd * usdToRub;
        alert(usd + " dollars equals " + euro + " rubles");
        break;
    case `3`:
        const ustToAzn = 1.7;
        var azn = usd * ustToAzn;
        alert(usd + " dollars equals " + euro + " azn");
        break;
}
function getTotal(){
    var summary = "";
    var cost = "";
    var runningTotal = 0;
    var sizeTotal = 0;
	var sizeArray = document.getElementsByClassName("pizzaSize");
	for (var i = 0; i < sizeArray.length; i++) {
		if (sizeArray[i].checked) {
			var selectedSize = sizeArray[i].value;
			summary = summary + selectedSize + "<br>";
		}
	}
	if (selectedSize == "Personal Pizza") {
        sizeTotal = 6;
        cost = sizeTotal + "<br>";
	} else if (selectedSize == "Medium Pizza") {
        sizeTotal = 10;
        cost = sizeTotal + "<br>";
	} else if (selectedSize == "Large Pizza") {
        sizeTotal = 14;
        cost = sizeTotal + "<br>";
	} else if (selectedSize == "Extra Large Pizza") {
        sizeTotal = 16;
        cost = sizeTotal + "<br>";
	}
	runningTotal = sizeTotal;
	console.log(selectedSize + " = $" + sizeTotal + ".00");
	console.log("pizzaSize orderSummaryHeader: " + orderSummaryHeader);
	console.log("subtotal: $" + runningTotal + ".00");
	getMeat(runningTotal,summary,cost); // All three of these variables will be passed on to each function
};

function getMeat(runningTotal,summary,cost) {
	var meatTotal = 0;
    var selectedMeat = [];
    var meatArray = document.getElementsByClassName("meatChoice");
	for (var j = 0; j < meatArray.length; j++) {
		if (meatArray[j].checked) {
            selectedMeat.push(meatArray[j].value);
			console.log("selected meat item: (" + meatArray[j].value + ")");
            summary = summary + meatArray[j].value + "<br>";
		}
	}
	var meatCount = selectedMeat.length;
	if (meatCount > 1) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
	}
    runningTotal = (runningTotal + meatTotal);
    for (var j = 0; j < selectedMeat.length; j++) {
        if (meatCount <= 1) {
            cost = cost + 0 + "<br>";
            meatCount = meatCount - 1;
        } else if (meatCount == 2) {
            cost = cost + 1 + "<br>";
            meatCount = meatCount - 1;
        } else {
            cost = cost + 1 + "<br>";
            meatCount = meatCount - 1;
        }
    }
	console.log("total selected meat items: " + meatCount);
	console.log(meatCount + " meat - 1 free meat = " + "$" + meatTotal + ".00");
	console.log("meat summary: " + summary);
	console.log("Purchase Total: " + "$" + runningTotal + ".00");
    getVeggies(runningTotal,summary,cost);
};

function getVeggies(runningTotal,summary,cost) {
	var veggieTotal = 0;
    var selectedVeggie = [];
    var veggieArray = document.getElementsByClassName("veggieChoice");
	for (var j = 0; j < veggieArray.length; j++) {
		if (veggieArray[j].checked) {
            selectedVeggie.push(veggieArray[j].value);
			console.log("selected veggie item: (" + veggieArray[j].value + ")");
            summary = summary + veggieArray[j].value + "<br>";
		}
	}
	var veggieCount = selectedVeggie.length;
	if (veggieCount > 1) {
		veggieTotal = (veggieCount - 1);
	} else {
		veggieTotal = 0;
	}
    runningTotal = (runningTotal + veggieTotal);
    for (var j = 0; j < selectedVeggie.length; j++) {
        if (veggieCount <= 1) {
            cost = cost + 0 + "<br>";
            veggieCount = veggieCount - 1;
        } else if (veggieCount == 2) {
            cost = cost + 1 + "<br>";
            veggieCount = veggieCount - 1;
        } else {
            cost = cost + 1 + "<br>";
            veggieCount = veggieCount - 1;
        }
    }
	console.log("total selected veggie items: " + veggieCount);
	console.log(veggieCount + " veggie - 1 free veggie = " + "$" + veggieTotal + ".00");
	console.log("veggie summary: " + summary);
	console.log("Purchase Total: " + "$" + runningTotal + ".00");
    getCheese(runningTotal,summary,cost);
};

function getCheese(runningTotal,summary,cost) {
    var cheeseTotal = 0;
    var selectedCheese = [];
    var cheeseArray = document.getElementsByClassName("cheeseOption");
    for (var j = 0; j < cheeseArray.length; j++) {
        if (cheeseArray[j].checked) {
            selectedCheese.push(cheeseArray[j].value);
            if (selectedCheese == "Extra Cheese") {
                cheeseTotal = 3;
            }
            console.log("selected cheese item: (" + cheeseArray[j].value + ")");
            summary = summary + cheeseArray[j].value + "<br>";
            cost = cost + cheeseTotal + "<br>";
        }
    }
    runningTotal = runningTotal + cheeseTotal;
    console.log("cheese summary: " + summary);
    console.log("Purchase total: " + "$" + runningTotal + ".00");
    getCrust(runningTotal,summary,cost);
}

function getCrust(runningTotal,summary,cost) {
    var crustTotal = 0;
    var selectedCrust = [];
    var crustArray = document.getElementsByClassName("crustOption");
    for (var j = 0; j < crustArray.length; j++) {
        if (crustArray[j].checked) {
            selectedCrust.push(crustArray[j].value);
            if (selectedCrust == "Cheese Stuffed Crust") {
                crustTotal = 3;
            }
            console.log("selected cheese item: (" + crustArray[j].value + ")");
            summary = summary + crustArray[j].value + "<br>";
            cost = cost + crustTotal + "<br>";
        }
    }
    runningTotal = runningTotal + crustTotal;
    console.log("crust summary: " + summary);
    console.log("Purchase total: " + "$" + runningTotal + ".00");
    getSauce(runningTotal,summary,cost);
}

function getSauce(runningTotal,summary,cost) {
    var sauceTotal = 0;
    var selectedSauce = [];
    var sauceArray = document.getElementsByClassName("sauceOption");
    for (var j = 0; j < sauceArray.length; j++) {
        if (sauceArray[j].checked) {
            selectedSauce.push(sauceArray[j].value);
            console.log("selected sauce item: (" + sauceArray[j].value + ")");
            summary = summary + sauceArray[j].value + "<br>";
            cost = cost + sauceTotal + "<br>";
        }
    }
    console.log("sauce summary: " + summary);
    console.log("Purchase total: " + "$" + runningTotal + ".00");
    orderOutput(runningTotal,summary,cost);
}

function orderOutput(runningTotal,summary,cost) {
    document.getElementById("orderOverview").style.opacity = 1;
    document.getElementById("orderSummary").innerHTML = summary;
    document.getElementById("orderSubtotal").innerHTML = cost;
    document.getElementById("totalCost").innerHTML = "</h3><strong>$" + runningTotal + ".00" + "</h3>";

};



function resetForm() {
    document.getElementById("orderMenu").reset();
    document.getElementById("orderOverview").style.opacity=0;
};
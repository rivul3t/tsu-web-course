let expression = "";
let lastIsOperator = false;

const screen = document.querySelector('.screen');

document.querySelectorAll('.number').forEach(btn =>
    btn.addEventListener('click', () => addNumber(btn.innerText))
);

document.querySelectorAll('.operation').forEach(btn =>
    btn.addEventListener('click', () => addSymbol(btn.innerText))
);

function addNumber(num) {
    if (expression.endsWith("=")) {
        expression = num;
    } else {
        expression += ' ' + num;
    }
    lastIsOperator = false;
    screen.innerText = expression;
}

function addSymbol(symbol) {
    if (symbol === "C") {
        expression = "0";
        screen.innerText = expression;
        expression = "";
        return;
    }

    if (symbol === "←") {
        expression = expression.slice(0, -1);
        if (expression === "") expression = "0";
        screen.innerText = expression;
        return;
    }

    if (symbol === "=") {
        calculate();
        return;
    }

    if (symbol === ".") {
        expression += ".";
        screen.innerText = expression;
        return;
    }

    if (lastIsOperator) {
        expression = expression.slice(0, -1) + symbol;
    } else {
        expression += ' ' + symbol;
    }

    lastIsOperator = true;
    screen.innerText = expression;
}

function calculate() {
    try {
        let jsExpr = expression
            .replace(/×/g, "*")
            .replace(/÷/g, "/");

        let result = Function("return " + jsExpr)();

        screen.innerText = expression + " = " + result;
        expression = result.toString(); // new base for next calc

    } catch (e) {
        screen.innerText = "Ошибка";
        expression = "";
    }
}

function randomIntFromInterval(min, max) { 
    return Math.floor(Math.random() * (max - min + 1) + min);
}

function createShape(className) {
    let count = document.querySelector("input").value;
    
    for (let i = 0; i < count; ++i) {
        let node = document.createElement("div");
        node.classList = className;
        
        if (className === "triangle") {
            node.style.borderLeft = randomIntFromInterval(100, 200) + "px solid transparent";
            node.style.borderRight = node.style.borderLeft;
            node.addEventListener("click", e => e.target.style.borderBottom = "100px solid yellow");
        } else {
            node.style.height = randomIntFromInterval(100, 200) + "px";
            node.style.width = node.style.height;
            node.addEventListener("click", e => e.target.style.background = "yellow");
        }
        
        node.style.top = randomIntFromInterval(50, 500) + "px";
        node.style.left = randomIntFromInterval(10, document.documentElement.clientWidth - 200) + "px";
        canvas.appendChild(node);
        
        node.addEventListener("dblclick", e => e.target.remove());
    }
}

let canvas = document.getElementById("canvas");

document.getElementById("button-rectangle").addEventListener("click", () => {
    createShape("rectangle");
});
document.getElementById("button-triangle").addEventListener("click", () => {
    createShape("triangle");
});
document.getElementById("button-circle").addEventListener("click", () => {
    createShape("circle");
});

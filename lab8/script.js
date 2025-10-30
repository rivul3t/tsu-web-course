let node = document.querySelector(".container").cloneNode(true);

const AddNewLine = () => {
    document.querySelector(".list").append(node.cloneNode(true));
    attachEvents();
};

const DeleteLine = (pointer) => {
    pointer.parentElement.remove();
};

const UpArrow = (pointer) => {
    let previous = pointer.parentElement.previousElementSibling;
    if (previous) pointer.parentElement.after(previous);
};

const DownArrow = (pointer) => {
    let next = pointer.parentElement.nextElementSibling;
    if (next) pointer.parentElement.before(next);
};

const Save = () => {           
    let string = "";
    let containers = document.querySelectorAll(".container");
    
    for (let node of containers) {
        let key = node.children[0].value;
        let value = node.children[1].value;
        string += `"${key}":"${value}",`;
    }
    
    document.querySelector(".content").innerHTML = `{${string.slice(0, -1)}}`;
};

function attachEvents() {
    document.querySelectorAll(".btn-delete").forEach(btn =>
        btn.onclick = () => DeleteLine(btn)
    );
    document.querySelectorAll(".btn-up").forEach(btn =>
        btn.onclick = () => UpArrow(btn)
    );
    document.querySelectorAll(".btn-down").forEach(btn =>
        btn.onclick = () => DownArrow(btn)
    );
}

attachEvents();

document.getElementById("add").onclick = AddNewLine;
document.getElementById("save").onclick = Save;

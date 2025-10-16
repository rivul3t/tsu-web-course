const button_left = document.getElementById('button-left')
const button_both = document.getElementById('button-both')
const button_right = document.getElementById('button-right')

const cat = document.getElementById('cat')
const dog = document.getElementById('dog')

button_left.addEventListener('click', () => {
    cat.style.width = "90%";
    dog.style.width = "5%";

    cat.children[0].style.display = "inline-block";
    dog.children[0].style.display = "none"

    cat.style.justifyContent = "flex-start"; 
});

button_both.addEventListener('click', () => {
    dog.style.width = "50%";
    cat.style.width = "50%";

    dog.children[0].style.display = "inline-block";
    cat.children[0].style.display = "inline-block";

    cat.style.justifyContent = "center";
    dog.style.justifyContent = "center";
});

button_right.addEventListener('click', () => {
    dog.style.width = "90%";
    cat.style.width = "5%";

    dog.children[0].style.display = "inline-block";
    cat.children[0].style.display = "none"

    dog.style.justifyContent = "flex-end";
});
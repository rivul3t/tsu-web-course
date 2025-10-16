var opened;
var fade;
var flag;

function openWin (id) {
    opened = document.getElementById(id);
    opened.style.display = "block";
    fade = document.getElementById("fade");
    fade.style.display = "block";
    flag = true;
};

function closeWin() {
    if (flag) {
        fade.style.display = "none";
        flag = false;
        opened.style.display = "none";
    }
};
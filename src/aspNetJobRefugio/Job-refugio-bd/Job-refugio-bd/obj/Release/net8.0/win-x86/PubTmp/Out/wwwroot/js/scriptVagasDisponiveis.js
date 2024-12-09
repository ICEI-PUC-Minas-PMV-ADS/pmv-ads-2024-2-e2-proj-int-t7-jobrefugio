function search() {

    let input = document.getElementById('searchbar').value;
    input = input.toLowerCase();
    let x = document.getElementsByClassName('cards');

    for (i = 0; i < x.length; i++) {
        if (!x[i].innerHTML.toLowerCase().includes(input)) {
            x[i].style.transition = "1s ease";
            x[i].style.display = "none";


        } else {
            x[i].style.transition = "1s ease";
            x[i].style.display = "flex";

        }
    }
}
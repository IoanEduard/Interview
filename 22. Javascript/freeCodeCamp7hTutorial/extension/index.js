let myLeads = [];
const inputbtn = document.getElementById("input-btn");
const inputEl = document.getElementById("input-el");
const ulEl = document.getElementById("ul-el");

function save() {
    let el = inputEl.value;
    myLeads.push(el);
    inputEl.value = "";

    let li = document.createElement("li");
    let link = document.createElement("a");
    link.textContent = myLeads[myLeads.length - 1];
    link.setAttribute("href", myLeads[myLeads.length - 1]);
    link.setAttribute("target", "_blank");

    li.appendChild(link);
    ulEl.appendChild(li);
    console.log(ulEl);

    // I can use .innerHtml "<li> some text </li>" will recognized as html
}
// inputbtn.addEventListener("click", save());
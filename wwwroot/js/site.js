// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//var cartButton = document.querySelector(".AddButton")

//cartButton.addEventListener("click", (e) => {
//    console.log(e.target.parentNode.parentNode)
//    console.log(e.target.parentNode.parentNode.querySelector(".ProductName").innerText)
//})


function addToBasket(e) {
    e = e || window.event
    var createProductName = e.target.parentNode.parentNode.querySelector(".ProductName").innerText;
    var createProductPrice = e.target.parentNode.parentNode.querySelector(".ProductPrice").innerText;
    var createProductId = e.target.parentNode.parentNode.querySelector(".ProductId").innerText;

    localStorage.setItem("createProductName", createProductName)
    localStorage.setItem("createProductPrice", createProductPrice)
    localStorage.setItem(`${createProductName} price`, createProductPrice)
    localStorage.setItem(`${createProductName} id`, createProductId)

}

function updatePrice(){
    var createPrice = document.querySelector(".CartPrice")
    var createName = document.querySelector(".CartName").value;
    var createQuantity = document.querySelector(".CartQuantity").value;
    var productPrice = localStorage.getItem(`${createName} price`)
    createPrice.value = Number(createQuantity * productPrice).toFixed(2)
}
//function updateEditPrice() {
//    var cartPrice = document.querySelector(".cartPrice");
//    var cartName = document.querySelector(".cartName").value;
//    var cartQuantity = document.querySelector(".cartQuantity").value;
//    var productPrice = localStorage.getItem(`${cartName} price`)
//    cartPrice.value = Number(cartQuantity * productPrice).toFixed(2)
//}

function updateImage() {
    var image = document.querySelector(".productImage");
    var product = document.querySelector(".CartName").value;
    var material = document.querySelector(".productMaterial").value;
    image.src = `/resources/${material}/${product} ${material}.jpg`;
}
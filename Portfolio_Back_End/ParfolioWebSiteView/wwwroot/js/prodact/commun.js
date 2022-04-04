// Check Product
if(localStorage.getItem("product")==null){
    localStorage.setItem("product", JSON.stringify([]))
}

function BasketCount(){
    $("#baketCountType").text(JSON.parse(localStorage.getItem("product")).length)
}
BasketCount()

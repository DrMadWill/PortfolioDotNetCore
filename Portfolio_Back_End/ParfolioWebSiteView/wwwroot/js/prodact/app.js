
$(".btn").each(function(item){
    $(this).click(function(e){
        e.preventDefault();
        let id=(this.parentElement.parentElement.getAttribute("data-id"))
        let prodName=this.parentElement.firstElementChild.innerText;
        let prodImage=this.parentElement.previousElementSibling.getAttribute("src");
        let price=this.previousElementSibling.innerText;

        let product = JSON.parse(localStorage.getItem("product"))
        existProduct = product.find(dr=>dr.id == id)

        if(existProduct==null){
            product.push(
                {
                    id:id,
                    name:prodName,
                    src:prodImage,
                    price:price,
                    count:1
                }
            )
        }else{
            existProduct.count = existProduct.count+1
        }
        localStorage.setItem("product",JSON.stringify(product))
        BasketCount()
    })
})



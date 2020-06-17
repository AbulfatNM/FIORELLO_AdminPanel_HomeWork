$(document).ready(function () {
    let skip = 4
    let productCount = $("#PrdouctCount").val();
    $("#loadMore").click(function () {
        $.ajax({
            url: "Product/Load?skip="+skip,
            type: "Get",
            success: function (response) {
                $(".mainproduct").append(response);
                skip += 4;
                if (skip >= productCount) {
                    $("#loadMore").remove();
                }

       
                //Old version
                //-------------------------------------
                //for (var product of response) {
                //    let col = $("<div>").addClass("col-lg-3 card_hover");
                //    let card = $("<div>").addClass("card cardMargin");
                //    let a = $("<a>");
                //    let image = $("<img>").attr("src", "images/" + product.image)
                //    a.append(image),
                //        card.append(a);
                //    let cardParagraf = $("<div>").addClass("cardParagraf");
                //    let h6 = $("<h6>").text(product.title)
                //    let addToCardsDiv = $("<div>").addClass("addToCards");
                //    let aAddtoCard = $("<a>").text("Add to cart");
                //    addToCardsDiv.append(aAddtoCard);
                //    let price = $("<div>").addClass("price");
                //    let span = $("<span>").text(product.price);
                //    price.append(span);
                //    cardParagraf.append(h6),
                //    cardParagraf.append(addToCardsDiv),
                //    cardParagraf.append(price);
                //    col.append(card),
                //        col.append(cardParagraf);
                //    $(".mainproduct").append(col);

                //}
            }
        })
    })

// Navbar start
$("#search li:first").click(function(){
    $(".search").toggleClass("Searchactive");
    
});
//  Home click underline 

// $(".homeMenu ul li a").click(function(){
// $("home a").css("border-bottom","1px solid")   
// });

// Navbar end

// Slider Start
let icon_right= $(".icon_right ");
let icon_left=$(".icon_left");
let left_right_icon=$(".icon_right,.icon_left");
let images=document.querySelector(".images")
icon_right.click(RightClick)
let interval=setInterval(RightClick, 6000)
left_right_icon.mouseenter(function(){
    clearInterval(interval);
})
left_right_icon.mouseleave(function(){
    interval=setInterval(RightClick, 6000);
})
function RightClick(){
    let active = document.querySelector(".activeImages");
    active.classList.remove("activeImages");   
    if(active.nextElementSibling!=null)
    {
        active.nextElementSibling.classList.add("activeImages");
    }else{
        images.firstElementChild.classList.add("activeImages")
    }
}
 icon_left.click(function(){
    let active = document.querySelector(".activeImages");
    active.classList.remove("activeImages");   
    if(active.previousElementSibling!=null){
        active.previousElementSibling.classList.add("activeImages");
    }else{
        images.lastElementChild.classList.add("activeImages");
    }
   
})
// Slider end
})

$(document).ready(function () {

    
    //  Progress Bar start

    $(function() { 
        $('#bar1').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white",
    });
    $('#bar2').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white"
    });
    $('#bar3').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white"
    });
    $('#bar4').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white",
    });
    $('#bar5').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white"
    });
    $('#bar6').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white"
    });
    $('#bar7').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white",
    });
    $('#bar8').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white"
    });
    $('#bar9').barfiller({
        barColor:"#f34f3f",
        duration:"1000",
        color:"white"
    });
     });


//  Progress Bar end


 
    // Navbar start
    $("#search li:first").click(function () {
        $(".search").toggleClass("Searchactive");

    });

    // Navbar end

    // Slider Start
    let icon_right = $(".icon_right ");
    let icon_left = $(".icon_left");
    let left_right_icon = $(".icon_right,.icon_left");
    let images = document.querySelector(".images")
    icon_right.click(RightClick)
    let interval = setInterval(RightClick, 6000)
    left_right_icon.mouseenter(function () {
        clearInterval(interval);
    })
    left_right_icon.mouseleave(function () {
        interval = setInterval(RightClick, 6000);
    })
    function RightClick() {
        let active = document.querySelector(".activeImages");
        active.classList.remove("activeImages");
        if (active.nextElementSibling != null) {
            active.nextElementSibling.classList.add("activeImages");
        } else {
            images.firstElementChild.classList.add("activeImages")
        }
    }
    icon_left.click(function () {
        let active = document.querySelector(".activeImages");
        active.classList.remove("activeImages");
        if (active.previousElementSibling != null) {
            active.previousElementSibling.classList.add("activeImages");
        } else {
            images.lastElementChild.classList.add("activeImages");
        }

    })
    // Slider end

    // Product start
    $(".productMenu ul li a").click(function (e) {
        e.preventDefault()
        $(".productMenuColor").removeClass("productMenuColor");
        $(this).addClass("productMenuColor")
    });
    $("#All").click(function(){

        $(".popularImages").css("display","none");
        $(".winterImages").css("display","none");
        $(".variousImages").css("display","none");
        $(".exoticImages").css("display","none");
        $(".greensImages").css("display","none");
        $(".cactusesImages").css("display","none");
        $(".allImages").css("display","block");
    });
    $("#Popular").click(function(){
        $(".cactusesImages").css("display","none");
        $(".greensImages").css("display","none");
        $(".exoticImages").css("display","none");
        $(".variousImages").css("display","none");
        $(".winterImages").css("display","none");
        $(".allImages").css("display","none");
        $(".popularImages").css("display","block");
    });
    $("#Winter").click(function(){
        $(".cactusesImages").css("display","none");
        $(".greensImages").css("display","none");
        $(".exoticImages").css("display","none");
        $(".variousImages").css("display","none");
        $(".allImages").css("display","none");
        $(".popularImages").css("display","none");
        $(".winterImages").css("display","block");
    });
    $("#Various").click(function(){
        $(".cactusesImages").css("display","none");
        $(".greensImages").css("display","none");
        $(".exoticImages").css("display","none");
        $(".allImages").css("display","none");
        $(".popularImages").css("display","none");
        $(".winterImages").css("display","none");
        $(".variousImages").css("display","block");
    });
    $("#Exotic").click(function(){
        $(".cactusesImages").css("display","none");
        $(".greensImages").css("display","none");
        $(".allImages").css("display","none");
        $(".popularImages").css("display","none");
        $(".winterImages").css("display","none");
        $(".variousImages").css("display","none");
        $(".exoticImages").css("display","block");
    });
    $("#Greens").click(function(){
        $(".cactusesImages").css("display","none");
        $(".allImages").css("display","none");
        $(".popularImages").css("display","none");
        $(".winterImages").css("display","none");
        $(".variousImages").css("display","none");
        $(".exoticImages").css("display","none");
        $(".greensImages").css("display","block");
    });
    $("#Cactuses").click(function(){
        $(".allImages").css("display","none");
        $(".popularImages").css("display","none");
        $(".winterImages").css("display","none");
        $(".variousImages").css("display","none");
        $(".exoticImages").css("display","none");
        $(".greensImages").css("display","none");
        $(".cactusesImages").css("display","block");
    });

    // Product end
    // Contact input start

    // Contact input end


 $(".input a").click(function(e){
     e.preventDefault();
    let input=$(".input input").val();
    
  let reg = /^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/
  reg.test(input)
    if(IsEmail(input)==false){
        $(".inpuRrequired_False").slideDown();
        $(".inpuRrequired_True").slideUp();

    }else{
        $(".inpuRrequired_False").slideUp();
        $(".inpuRrequired_True").slideDown();
        
    }
    function IsEmail(input) {
        var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if(!regex.test(input)) {
           return false;
        }else{
           return true
        }
    }
})
  

    //  Worker slider start 

let workerSliderRightIcon=$(".workerSliderRightIcon");
let workerSliderLeftIcon=$(".workerSliderLeftIcon");
let workerSliderLeftIcon_workerSliderRightIcon=$(".workerSliderRightIcon,.workerSliderLeftIcon")
let workerItemImages=document.querySelector(".workerItemImages");
workerSliderRightIcon.click(Worker_right_click)
let worker_Slider_interval=setInterval(Worker_right_click, 3000);
workerSliderLeftIcon_workerSliderRightIcon.mouseenter(function () {
    clearInterval(worker_Slider_interval);
})
workerSliderLeftIcon_workerSliderRightIcon.mouseleave(function () {
    worker_Slider_interval = setInterval(Worker_right_click, 6000);
})
workerSliderLeftIcon.click(function(){
    let workersliderActive=  document.querySelector(".workersliderActive");
    workersliderActive.classList.remove("workersliderActive");
    if(workersliderActive.previousElementSibling!=null){
        workersliderActive.previousElementSibling.classList.add("workersliderActive")
    }else{
        workerItemImages.lastElementChild.classList.add("workersliderActive");
    }
})
function Worker_right_click(){
    let workersliderActive=  document.querySelector(".workersliderActive");
    workersliderActive.classList.remove("workersliderActive");
    if(workersliderActive.nextElementSibling!=null){
        workersliderActive.nextElementSibling.classList.add("workersliderActive")
    }else{
        workerItemImages.firstElementChild.classList.add("workersliderActive");
    }
}
    //  Worker slider end 
//  Owl Carousel start
 let owl = $('.owl-carousel');
 $('.owl-main-page').owlCarousel({
    loop:true,
    margin:5,
    nav:true,
    responsive:{
        0:{
            items:1
        },
        500:{
            items:3
        },
        1200:{
            items:7.5
        }
    }
 })


//  Accordion Page start 
$(".cardHeaderPosetion_1").click(function(){
  $(".cardHeader_1").removeClass("cardHeader_1");
  $(this).addClass("cardHeader_1");
  $(".cardBody_1").not($(this).next()).slideUp();
  $(this).next().slideToggle();
  $(".cardBody_1").not($(this).next()).slideUp();
  $(this).parent().siblings().find("i").removeClass("fa-minus").addClass("fa-plus");
  $(this).find("i").toggleClass("fa-plus").toggleClass("fa-minus");
 });

 $(".cardHeaderPosetion_2").click(function(){

    $(".cardHeader_2").removeClass("cardHeader_2");
    $(this).addClass("cardHeader_2")
    $(".cardBody_2").not($(this).next()).slideUp()
    $(this).next().slideToggle();
    $(this).parent().siblings().find("i").removeClass("fa-minus").addClass("fa-plus");
    $(this).find("i").toggleClass("fa-plus").toggleClass("fa-minus");
  });

  $(".cardHeaderPosetion_3").click(function(){

    $(".cardHeader_3").removeClass("cardHeader_3");
    $(this).addClass("cardHeader_3");
    $(".cardBody_3").not($(this).next()).slideUp()
    $(this).next().slideToggle();
    $(this).parent().siblings().find("i").removeClass("fa-minus").addClass("fa-plus");
    $(this).find("i").toggleClass("fa-plus").toggleClass("fa-minus");
  });


$(".cardHeaderPosetion_4").click(function(){

    $(".cardHeader_4").removeClass("cardHeader_4");
    $(this).addClass("cardHeader_4")
    $(".cardBody_4").not($(this).next()).slideUp()
    $(this).next().slideToggle();
    $(this).parent().siblings().find("i").removeClass("fa-minus").addClass("fa-plus");
    $(this).find("i").toggleClass("fa-plus").toggleClass("fa-minus");
  });
//  Accordion Page end 

// Tabs Page start

let menus= document.querySelectorAll(".tabMenu_1 div")
let tabMenuContent_1 = document.querySelectorAll(".tabMenuContent_1 div")
for( let menu of menus){
    menu.onclick=function(e){
    e.preventDefault()
     document.querySelector(".tabMenu_1_bgColor").classList.remove("tabMenu_1_bgColor");
     this.classList.add("tabMenu_1_bgColor")
     let dataId=this.getAttribute("data-id")
     for(let tabMenuContents_1 of tabMenuContent_1){
         if(dataId== tabMenuContents_1.getAttribute("data-id")){
            tabMenuContents_1.className=""
         }else{
            tabMenuContents_1.classList.add("d-none")
         }
     }
    }
}
let menus_2= document.querySelectorAll(".tabMenu_2 div")
let tabMenuContent_2 = document.querySelectorAll(".tabMenuContent_2 div")
for( let menu_2 of menus_2){
    menu_2.onclick=function(e){
        e.preventDefault()
     document.querySelector(".tabMenu_2_bgColor").classList.remove("tabMenu_2_bgColor");
     this.classList.add("tabMenu_2_bgColor")
     let dataId=this.getAttribute("data-id")
     for(let tabMenuContents_2 of tabMenuContent_2){
         if(dataId== tabMenuContents_2.getAttribute("data-id")){
            tabMenuContents_2.className=""
         }else{
            tabMenuContents_2.classList.add("d-none")
         }
     }
    }
}
let menus_3= document.querySelectorAll(".tabMenu_3 div")
let tabMenuContent_3 = document.querySelectorAll(".tabMenuContent_3 div")
for( let menu_3 of menus_3){
    menu_3.onclick=function(e){
        e.preventDefault()
     document.querySelector(".tabMenu_3_bgColor").classList.remove("tabMenu_3_bgColor");
     this.classList.add("tabMenu_3_bgColor")
     let dataId=this.getAttribute("data-id")
     for(let tabMenuContents_3 of tabMenuContent_3){
         if(dataId== tabMenuContents_3.getAttribute("data-id")){
            tabMenuContents_3.className=""
         }else{
            tabMenuContents_3.classList.add("d-none")
         }
     }
    }
}
let menus_4= document.querySelectorAll(".tabMenu_4 div")
let tabMenuContent_4 = document.querySelectorAll(".tabMenuContent_4 div")
for( let menu_4 of menus_4){
    menu_4.onclick=function(e){
        e.preventDefault()
     document.querySelector(".tabMenu_4_bgColor").classList.remove("tabMenu_4_bgColor");
     this.classList.add("tabMenu_4_bgColor")
     let dataId=this.getAttribute("data-id")
     for(let tabMenuContents_4 of tabMenuContent_4){
         if(dataId== tabMenuContents_4.getAttribute("data-id")){
            tabMenuContents_4.className=""
         }else{
            tabMenuContents_4.classList.add("d-none")
         }
     }
    }
}

// Tabs Page end

//  Product List start 
let productTabHeads= document.querySelectorAll(".productTabHeads div")
let productTabContent = document.querySelectorAll(".productTabContent div")
for( let productTabHead of productTabHeads){
    productTabHead.onclick=function(e){
    e.preventDefault()
     document.querySelector(".product_bgColor").classList.remove("product_bgColor");
     this.classList.add("product_bgColor")
     let dataId=this.getAttribute("data-id")
     for(let productTabContents of productTabContent){
         if(dataId== productTabContents.getAttribute("data-id")){
            productTabContents.classList.remove("d-none")
            
         }else{
            productTabContents.classList.add("d-none")
         }
     }
    }
}
//  Product List end 

});
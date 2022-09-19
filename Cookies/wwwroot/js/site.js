
// $( ".arrow-img" ).each(function(index) {
//     $(this).on("click", function(){
//         // For the boolean value
//          $(this).toggleClass('rotate');
//          $(this).toggleClass('rotate-reset');
//          $(".recipe").toggleClass('recipe-show');

//     });
// });
// $(document).ready(function(){
//     $(".recipe-total > .arrow").children().addClass("hide");
//     $(".recipe-total > .arrow-img").addClass("hide");
//   });
// const random2 = document.querySelectorAll('.recipe-total');
// console.log(('.recipe-total').children());

$(".recipe-total").each(function (index) {

    $('.recipe-total > .arrow-img').on("click", function () {
        $('.recipe-total > .arrow-img').toggleClass('rotate');
        $(this).toggleClass('rotate-reset');
        $('.recipe').toggleClass('recipe-show');

    });
});


// When the user scrolls down 50px from the top of the document, resize the header's font size
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
        document.getElementById("logo-top").style.height = "120px";
        document.getElementById("logo-sec-bg").style.height = "130px";



    } else {
        document.getElementById("logo-top").style.height = "120px";
        document.getElementById("logo-sec-bg").style.height = "130px";

    }
}
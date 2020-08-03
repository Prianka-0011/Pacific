
$(document).ready(function () {
    $('.sidemenuToggler').on('click', function () {
        $('.wrapper').toggleClass('active');
    });

    $('.prod-btn').click(function () {
        $('.prod-show').toggleClass("show");
        $('.first').toggleClass("rotate");
    });
    $('.cat-btn').click(function () {
        $('.cat-show').toggleClass("show1");
        $('.second').toggleClass("rotate1");
    });
   
    //$('.toggle-btn1').click(function () {

    //    $('.toggle-btn2').toggleClass("toggle-btn3");
       
    //});
    //$('.toggle-btn2').click(function () {

    //    $('.toggle-btn1').toggleClass('toggle-btn4');

    //});
});
//top: 0;
//left: 0;
//position: absolute;
//width: 110px;
//height: 100 %;
//color: #fff;
//background: linear - gradient(to right, #ff105f, #ffad06);
//border - radius: 30px;
//transition: 0.5s;
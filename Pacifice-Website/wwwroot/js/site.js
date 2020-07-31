
$(document).ready(function () {
    $('.sidemenuToggler').on('click', function () {
        $('.wrapper').toggleClass('active');
    });

    //var adjustSidebar = function () {
    //    $('.sidebar').slimScroll({
    //        height: document.documentElement.clientHeight - $('.navbar').outerHeight()
    //    });
    //};

    //adjustSidebar();
    //$(window).resize(function () {
    //    adjustSidebar();
    //});
    //var dropdown = document.getElementsByClassName("dropdown-btn");
    //var i;

    //for (i = 0; i < dropdown.length; i++) {
    //    dropdown[i].addEventListener("click", function () {
    //        this.classList.toggle("active");
    //        var dropdownContent = this.nextElementSibling;
    //        if (dropdownContent.style.display === "block") {
    //            dropdownContent.style.display = "none";
    //        } else {
    //            dropdownContent.style.display = "block";
    //        }
    //    });
    //}
});
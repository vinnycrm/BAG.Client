/** 
 * Header JS
 * -----------------
 * Header with Slider
 * 
 */
$(function() {
	$("body").on("click",".fsnav-left",function() {
		$("#fsnav-wrapper-left").addClass("fsnav-wrapper-active");
	});
	$("body").on("click",".fsnav-submenu-link",function() {
		if($(this).find(".fsnav-li-exticon").hasClass("fsnav-li-extopen")) {
			$(this).find(".fsnav-li-exticon").removeClass("fsnav-li-extopen");
			$(this).find(".fsnav-li-exticon").find(".fa").attr("class","fa fa-plus");
		} else {
			$(this).find(".fsnav-li-exticon").addClass("fsnav-li-extopen");
			$(this).find(".fsnav-li-exticon").find(".fa").attr("class","fa fa-minus");
		}
		$(this).find(".fsnav-li-exticon").addClass("fsnav-wrapper-active");
	});
	$("body").click(function(e) {
	    if ($(e.target).closest("#fsnav-wrapper-left").length === 0 && e.target.className !== 'fsnav-left' && e.target.className !== 'fa fa-bars fsnav-left' && e.target.className !== 'nvc-lhsmenu') {
	    	if($("#fsnav-wrapper-left").hasClass("fsnav-wrapper-active")) {
	    		$("#fsnav-wrapper-left").removeClass("fsnav-wrapper-active");
	    	}
	    }
	    if(e.target.className == "fsnav-lhs-close" || e.target.className == "fa fa-close fsnav-lhs-closeicon") {
	    	$("#fsnav-wrapper-left").removeClass("fsnav-wrapper-active");
	    }
	});
	
});




$(window).scroll(function() {     
    var scroll = $(window).scrollTop();
    if (scroll > 0) {
        $(".fsnavbar-header").addClass("shadow-active");
    }
    else {
        $(".fsnavbar-header").removeClass("shadow-active");
    }
});

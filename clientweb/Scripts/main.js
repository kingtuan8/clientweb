 AOS.init({
 	duration: 100,
 	easing: 'slide',
 	once: false
 });

jQuery(document).ready(function($) {

	"use strict";

	$(".loader").delay(1000).fadeOut("slow");
  $("#overlayer").delay(1000).fadeOut("slow");	

	var siteMenuClone = function() {

		$('.js-clone-nav').each(function() {
			var $this = $(this);
			$this.clone().attr('class', 'site-nav-wrap').appendTo('.site-mobile-menu-body');
		});


		setTimeout(function() {
			
			var counter = 0;
      $('.site-mobile-menu .has-children').each(function(){
        var $this = $(this);
        
        $this.prepend('<span class="arrow-collapse collapsed">');

        $this.find('.arrow-collapse').attr({
          'data-toggle' : 'collapse',
          'data-target' : '#collapseItem' + counter,
        });

        $this.find('> ul').attr({
          'class' : 'collapse',
          'id' : 'collapseItem' + counter,
        });

        counter++;

      });

    }, 1000);

		$('body').on('click', '.arrow-collapse', function(e) {
      var $this = $(this);
      if ( $this.closest('li').find('.collapse').hasClass('show') ) {
        $this.removeClass('active');
      } else {
        $this.addClass('active');
      }
      e.preventDefault();  
      
    });

		$(window).resize(function() {
			var $this = $(this),
				w = $this.width();

			if ( w > 768 ) {
				if ( $('body').hasClass('offcanvas-menu') ) {
					$('body').removeClass('offcanvas-menu');
				}
			}
		})

		$('body').on('click', '.js-menu-toggle', function(e) {
			var $this = $(this);
			e.preventDefault();

			if ( $('body').hasClass('offcanvas-menu') ) {
				$('body').removeClass('offcanvas-menu');
				$this.removeClass('active');
			} else {
				$('body').addClass('offcanvas-menu');
				$this.addClass('active');
			}
		}) 

		// click outisde offcanvas
		$(document).mouseup(function(e) {
	    var container = $(".site-mobile-menu");
	    if (!container.is(e.target) && container.has(e.target).length === 0) {
	      if ( $('body').hasClass('offcanvas-menu') ) {
					$('body').removeClass('offcanvas-menu');
				}
	    }
		});
	}; 
	siteMenuClone();





	

    var siteCarousel = function () {

        $('.with-dots').owlCarousel({
            center: false,
            items: 1,
            loop: true,
            stagePadding: 0,
            margin: 0,
            autoplay: true,
            smartSpeed: 1357,
            pauseOnHover: true,
            nav: false,
            dots: true,
            navText: ['<span class="icon-keyboard_arrow_left">', '<span class="icon-keyboard_arrow_right">']
        });

        if ($('.owl-all').length > 0) {
            $('.owl-all').owlCarousel({
                center: false,
                items: 1,
                loop: false,
                stagePadding: 0,
                margin: 0,
                autoplay: false,
                nav: false,
                dots: true,
                touchDrag: true,
                mouseDrag: true,
                smartSpeed: 1000,
                navText: ['<span class="icon-arrow_back">', '<span class="icon-arrow_forward">'],
                responsive: {
                    768: {
                        margin: 30,
                        nav: false,
                        responsiveRefreshRate: 10,
                        items: 1
                    },
                    992: {
                        margin: 30,
                        stagePadding: 0,
                        nav: false,
                        responsiveRefreshRate: 10,
                        touchDrag: false,
                        mouseDrag: false,
                        items: 3
                    },
                    1200: {
                        margin: 30,
                        stagePadding: 0,
                        nav: false,
                        responsiveRefreshRate: 10,
                        touchDrag: false,
                        mouseDrag: false,
                        items: 3
                    }
                }
            });
        }


	

	 
		
	};
	siteCarousel();

	


	// siteCountDown();

	var siteDatePicker = function() {

		if ( $('.datepicker').length > 0 ) {
			$('.datepicker').datepicker();
		}

	};
	// siteDatePicker();

	var siteSticky = function() {
		$(".js-sticky-header").sticky({topSpacing:0});
	};
	siteSticky();

	// navigation
    var OnePageNavigation = function () {
        //var navToggler = $('.site-menu-toggle');

        //$("body").on("click", ".main-menu li a[href^='#'], .smoothscroll[href^='#'], .site-mobile-menu .site-nav-wrap li a[href^='#']", function (e) {
        //    e.preventDefault();

        //    var hash = this.hash;

        //    $('html, body').animate({
        //        'scrollTop': $(hash).offset().top - 50
        //    }, 600, 'easeInOutExpo', function () {
        //        // window.location.hash = hash;

        //    });
        //});

        $('.gototop').on('click', function () {
            $('html, body').animate({
                'scrollTop': $('body').offset().top
            }, 600, 'easeInOutExpo');
        });


    };
  OnePageNavigation();

  var siteScroll = function() {

  	

  	$(window).scroll(function() {

  		var st = $(this).scrollTop();

            if (st > 100) {
                $('.js-sticky-header').addClass('shrink');
            } else {
                $('.js-sticky-header').removeClass('shrink');
            }

            if (st > 200) {
                $('.gototop').addClass('active');
            } else {
                $('.gototop').removeClass('active');
            }

  	}) 

  };
  siteScroll();


    var counter = function () {

        $('#about-section').waypoint(function (direction) {

            if (direction === 'down' && !$(this.element).hasClass('ftco-animated')) {

                var comma_separator_number_step = $.animateNumber.numberStepFactories.separator(',')
                $('.number > span').each(function () {
                    var $this = $(this),
                        num = $this.data('number');
                    $this.animateNumber(
                        {
                            number: num,
                            numberStep: comma_separator_number_step
                        }, 7000
                    );
                });

            }

        }, { offset: '95%' });

    };

    //var siteScroll = function () {



    //    $(window).scroll(function () {

    //        var st = $(this).scrollTop();

    //        if (st > 100) {
    //            $('.js-sticky-header').addClass('shrink');
    //        } else {
    //            $('.js-sticky-header').removeClass('shrink');
    //        }


    //        if (st > 200) {
    //            $('.gototop').addClass('active');
    //        } else {
    //            $('.gototop').removeClass('active');
    //        }

    //    })

    //};
    //counter();
    //siteScroll();



});
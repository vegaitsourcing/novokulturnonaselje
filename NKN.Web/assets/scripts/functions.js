var mobileView = $(window).width() < 768;
var mobileAndTabletView = $(window).width() < 1025;

var functions = (function() {
	return {
		languageSwitcher: function () {
			$('.js-selected-item').on('click', function () {
				if (!$(this).hasClass('open')) {
					$(this).addClass('open');
					$(this).next('.js-language-list').stop().slideDown();

					if (mobileAndTabletView) {
						$('.js-header-hamburger').removeClass('open');
						$('.js-nav').hide();
					}
				} else {
					$(this).removeClass('open');
					$(this).next('.js-language-list').stop().slideUp();
				}
			});
		},

		mobileNavInit: function () {
			$('.js-header-hamburger').on('click', function () {
				if (!$(this).hasClass('open')) {
					$(this).addClass('open');
					$('.js-nav').stop().slideDown();

					if (mobileAndTabletView) {
						$('.js-selected-item').removeClass('open');
						$('.js-language-list').hide();
					}
				} else {
					$(this).removeClass('open');
					$('.js-nav').stop().slideUp();
				}
			});
		},

		stickyHeader: function () {
			if ($(window).scrollTop() >= 500) {
				$('.js-header').addClass('header-sticky');
			}
			else {
				$('.js-header').removeClass('header-sticky');
			}
		},

		sliderInit: function () {
			var $missionSlider = $('.js-mission-slider');
			var $contributorsSlider = $('.js-contributors-slider');
			var $projectSlider = $('.js-projects-slider');
			var $gallerySimple = $('.js-gallery-simple');
			var $imageGallery = $('.js-album-slider');

			if ($('.js-slider').length) {
				$('.js-slider').slick({
					infinite: true,
					slidesToShow: 1,
					slidesToScroll: 1,
					dots: true,
					arrows: false
				});

				//mission slider
				if ($missionSlider.length) {
					$missionSlider.slick('slickSetOption', {
						slidesToShow: 4,
						slidesToScroll: 1,
						slidesPerRow: 4,
						rows: 1,
						arrows: true,
						dots: false,
						responsive: [
							{
								breakpoint: 768,
								settings: {
									slidesToShow: 1,
									slidesPerRow: 1,
									rows: 2
								}
							}
						]
					}, true);
				}

				//contributors slider
				if ($contributorsSlider.length) {
					$contributorsSlider.slick('slickSetOption', {
						slidesToShow: 4,
						responsive: [
							{
								breakpoint: 768,
								settings: {
									slidesToShow: 1
								}
							}
						]
					}, true);
				}
			}

			//projects slider
			if ($projectSlider.length) {
				$projectSlider.slick({
					infinite: true,
					slidesToScroll: 1,
					slidesPerRow: 3,
					rows: 2,
					dots: true,
					arrows: false,
					responsive: [
						{
							breakpoint: 768,
							settings: {
								slidesPerRow: 1,
								rows: 1
							}
						}
					]
				});
			}

			//gallery simple slider
			if ($gallerySimple.length) {
				$gallerySimple.slick({
					infinite: true,
					slidesToScroll: 1,
					slidesPerRow: 3,
					rows: 2,
					dots: true,
					arrows: false,
					swipe: false,
					responsive: [
						{
							breakpoint: 768,
							settings: {
								slidesPerRow: 1,
								rows: 1
							}
						}
					]
				});
			}

			if ($imageGallery.length) {
				$imageGallery.slick({
					infinite: true,
					slidesToScroll: 1,
					slidesPerRow: 4,
					rows: 4,
					dots: true,
					arrows: false,
					swipe: false,
					responsive: [
						{
							breakpoint: 1024,
							settings: {
								rows: 2
							}
						},
						{
							breakpoint: 768,
							settings: {
								slidesPerRow: 2,
								rows: 1
							}
						}
					]
				});
			}
		},

		equalHeightInit: function () {
			if ($('.js-contributors-slider').length) {
				$('.js-contributors-slider').each(function () {
					helpers.equalHeight($(this).find('.js-image-holder'), 4);
				});
			}

			if ($('.js-four-highlighted-block').length) {
				if (!mobileView) {
					$('.js-four-highlighted-block').each(function () {
						helpers.equalHeight($(this).find('.image-holder'), 4);
					});
				} else {
					$('.js-four-highlighted-block').find('.image-holder').css('height', '');
				}
			}
		},

		subscribe: function () {

			$('.newsletter-form .btn-white').off('click').on('click', function (e) {

				const error = $('span#EmailAddress-error').text();
				if (error) return;
				const controllerUrl = $(this).data('controller-url');
				console.log(controllerUrl);
				const emailAddress = $('.newsletter-form input').val();
				if (!emailAddress) return;
				e.preventDefault();
				$.post(controllerUrl, { emailAddress: emailAddress }, function (response) {
					$('.newsletter-form .fieldset-inner').empty();
					$('.newsletter-form .fieldset-inner').append("<h2 class='centered'>" + response + "</h2>");
				}, 'html');

			});
		},



		popupClose: function () {
			$(document).on('click', '.js-popup-overlay, .js-popup-close', function () {
				helpers.closePopupActions();
			});

			if ($(document).find('.js-popup.open').length) {
				$(document).on('keyup', function(e){
					if (e.which == 27) {
						helpers.closePopupActions();
					}
				});
			}
		},

		simpleGalleryInit: function () {
			var popupClass = '.js-popup';
			$('.js-open-gallery-simple').on('click', function () {
				var $this = $(this);
				var thiSrc = $this.find('.js-gallery-simple-src').data('src');
				var $activePopup = $this.parents('.js-gallery-simple').next(popupClass);

				$activePopup.stop().fadeIn().addClass('open');
				$('body').css('overflow', 'hidden');
				$activePopup.find('.js-gallery-simple-image').attr('src', thiSrc);
			});
		},

		simpleVideoInit: function () {
			$('.js-video-thumbnail').on('click', function () {
				var $activePopup = $(this).next('.js-popup');
				var $video = $activePopup.find('.js-simple-video-iframe');
				var videoSrc = $video.data('src');

				$activePopup.stop().fadeIn().addClass('open');
				$('body').css('overflow', 'hidden');
				$video.attr('src', videoSrc);
			});
		}
	}
}());

var helpers = (function() {
	return {
		equalHeight : function (arrayItems, count) {
			if (arrayItems !== undefined && arrayItems.length > 0) {
				arrayItems.height('');

				let maxH = 0;

				if (count) {
					let arrays = [];
					while (arrayItems.length > 0) {
						arrays.push(arrayItems.splice(0, count));
					}

					for (let i = 0; i < arrays.length; i += 1) {
						let data = arrays[i];
						maxH = 0;
						for (let j = 0; j < data.length; j += 1) {
							let currentH = $(data[j]).outerHeight(true);
							if (currentH > maxH) {
								maxH = currentH;
							}
						}

						for (let k = 0; k < data.length; k += 1) {
							$(data[k]).css('height', maxH);
						}
					}
				} else {
					arrayItems.each(function () {
						let currentH2 = $(this).outerHeight(true);
						if (currentH2 > maxH) {
							maxH = currentH2;
						}
					});

					arrayItems.css('height', maxH);
				}
			}
		},

		closePopupActions: function () {
			$('.js-popup').fadeOut();
			$('body').css('overflow', '');

			if ($('.js-popup').find('.js-simple-video-iframe').length) {
				$('.js-simple-video-iframe').removeAttr('src');
			}
		}
	}
}());

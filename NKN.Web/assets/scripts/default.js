$(function(){

	functions.accordion();
	functions.heroSlider();

});

$(window).on('load', function() {

	console.log('window loaded');

});

$(window).resize(function(){

	console.log('window resized');

});
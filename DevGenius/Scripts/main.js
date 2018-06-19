


var main = function(){

    for (i = 5; i < 10; i++){
		$('.load img').fadeOut(800);
		$('.load img').fadeIn(800);	
		
    }

	$('.load').delay('3000').fadeOut('3000');
    
	$('.content').removeClass('content-hide');	
	
	// EFEITO SCROLL REVEL ITEMS 
    window.sr = ScrollReveal({ reset: true });
    sr.reveal('.logo', {
        duration: 900, 
        mobile: true
    });

    sr.reveal('.main-menu nav ul li', {
        duration: 300,
        mobile: true,
        rotate: { z: 10 },
        distance: '90px',
        easing: 'ease-in-out',
        origin: 'right'
    },
    50);
	
	// EFEITO SCROLL MENU PRINCIPAL
	$('.main-menu nav ul li a').click(function(){
			var destino = $(this).attr('href');
			$('html, body').animate({
				scrollTop: $(destino).offset().top
			}, 1000);
			return false;
	});
	
	//$('.main-menu ul li a').click(function(){
	//	var destino = $(this).attr('href');
	//	//$('body').scrollTo('.empresa', 800);	
	//	return false;
	//	//$(this).scrollTo(
	//});
	
	// MENU SERVICOS BOX
    $('.servicos-container ul li').click(function () {
        if (!$(this).hasClass('active')) {
			$('.servicos-container ul li').removeClass('active');	
			$(this).addClass('active');			
		}
	});
	
	// ATIVAR DIV MENU SERVICOS SELECIONA	
	$('.servicos-container ul li a').click(function(e){
		e.preventDefault();
		var divAtivar = $($(this).attr('href'));
		if (!divAtivar.hasClass('servicos-active')){
			$('.servicos-box div').removeClass('servicos-active');
			divAtivar.addClass('servicos-active');
		}
	});
	
	
	var offset = 300,
		offsetOpacity = 1200,
		scrollTopDuration = 700,
		$backToTop = $('.cd-top');
	
	
	$(window).scroll(function(){
        $(this).scrollTop() > offset ? $backToTop.addClass('cd-is-visible') : $backToTop.removeClass('cd-is-visible cd-fade-out');
		if ($(this).scrollTop() > offsetOpacity) {
			$backToTop.addClass('cd-fade-out');
		}
	});
	
	$backToTop.on('click', function(event){
		event.preventDefault();
		$('body,html').animate({
            scrollTop: 0,
        }, scrollTopDuration
		);
	});
}

$(document).ready(main);

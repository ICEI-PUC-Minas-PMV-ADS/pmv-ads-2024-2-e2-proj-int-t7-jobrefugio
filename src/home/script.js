window.addEventListener('scroll', function(){

    var menu = document.querySelector('.nav');
    
    
        menu.classList.toggle('sticky', window.scrollY > 4);
    
    
    })

    new Swiper('.div_empresas', {

        loop: true,
        spaceBetween: 30,
      
        // If we need pagination
        pagination: {
          el: '.swiper-pagination',
          clickable: true,
          dynamicBullets: true
        },
      
        // Navigation arrows
        navigation: {
          nextEl: '.swiper-button-next',
          prevEl: '.swiper-button-prev',
        },
    
        breakpoints: {
        0: {
            slidesPerView: 1
        },
        768: {
            slidesPerView: 3
        },
        1024: {
            slidesPerView: 4
        },
        }
      
      });
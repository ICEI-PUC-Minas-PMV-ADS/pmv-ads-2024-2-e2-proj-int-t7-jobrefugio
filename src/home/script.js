window.addEventListener('scroll', function(){

    var menu = document.querySelector('.nav');
    
    
        menu.classList.toggle('sticky', window.scrollY > 4);
    
    
    })

//Slide Empresas parceiras
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

//Banner Página home
      let currentIndex = 0;
const items = document.querySelectorAll('.carousel-item');
const totalItems = items.length;

function showImage(index) {
    const carouselInner = document.querySelector('.carousel-inner');
    carouselInner.style.transform = `translateX(-${index * 100}%)`;
}

function showNextImage() {
    currentIndex = (currentIndex + 1) % totalItems;
    showImage(currentIndex);
}

function showPrevImage() {
    currentIndex = (currentIndex - 1 + totalItems) % totalItems;
    showImage(currentIndex);
}

// Inicializa o carrossel
setInterval(showNextImage, 10000); // Troca a cada 10 segundos

document.getElementById('next').addEventListener('click', showNextImage);
document.getElementById('prev').addEventListener('click', showPrevImage);

window.addEventListener('scroll', function(){

    var menu = document.querySelector('.nav');
    
    
        menu.classList.toggle('sticky', window.scrollY > 4);
    
    
    })
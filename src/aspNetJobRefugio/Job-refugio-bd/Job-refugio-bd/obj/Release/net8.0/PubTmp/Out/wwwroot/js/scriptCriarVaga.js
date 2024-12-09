const mobileMenu = document.getElementById('mobile-menu');
        const navList = document.getElementById('nav-list');

        mobileMenu.addEventListener('click', () => {
            navList.classList.toggle('active');
        });

if (!User.Identity.IsAuthenticated) {

    var element = document.getElementById('login-btn');
    element.parentElement.removeChild(element);
};
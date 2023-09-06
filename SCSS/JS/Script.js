// JavaScript to toggle the mobile navigation menu
const navBody = document.querySelector('.Nav-Body');
const mobileMenuButton = document.querySelector('.mobile-menu-button');

mobileMenuButton.addEventListener('click', () => {
    navBody.classList.toggle('active');
});

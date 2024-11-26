// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let currentSlide = 0;

function showSlide(index) {
    const slides = document.querySelectorAll('.slide');
    if (index >= slides.length) {
        currentSlide = 0;
    } else if (index < 0) {
        currentSlide = slides.length - 1;
    } else {
        currentSlide = index;
    }

    const offset = -currentSlide * 100;
    document.querySelector('.slides').style.transform = translateX(${ offset } %);
}

function changeSlide(direction) {
    showSlide(currentSlide + direction);
}

// Автоматическая смена слайдов
setInterval(() => {
    changeSlide(1);
}, 3000); // Смена каждые 3 секунды

// Изначально показываем первый слайд
showSlide(currentSlide);

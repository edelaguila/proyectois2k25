document.addEventListener('DOMContentLoaded', function () {
    const toggleBtn = document.getElementById('userDropdownBtn');
    const menu = document.getElementById('userDropdownMenu');

    toggleBtn.addEventListener('click', function (e) {
        e.stopPropagation();
        menu.style.display = menu.style.display === 'block' ? 'none' : 'block';
    });

    // Cierra el menú si se hace clic fuera
    window.addEventListener('click', function () {
        menu.style.display = 'none';
    });
});
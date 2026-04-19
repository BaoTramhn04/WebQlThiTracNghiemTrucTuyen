// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script>
    let current = 0;

    function goSlide(index) {
    const track = document.querySelector(".highlight-track");
    const dots = document.querySelectorAll(".dot");

    current = index;

    track.style.transform = `translateX(-${index * 100}%)`;

    dots.forEach(dot => dot.classList.remove("active"));
    dots[index].classList.add("active");
}
</script>
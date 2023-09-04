document.addEventListener("DOMContentLoaded", function () {
  const music = document.getElementById("music");
  const toggleButton = document.getElementById("music-button");

  music.play();

  toggleButton.addEventListener("click", function () {
    if (music.paused) {
      music.play();
    } else {
      music.pause();
    }
  });
});

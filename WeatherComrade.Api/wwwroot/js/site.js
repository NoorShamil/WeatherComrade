// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", () => {

    const canvas =
        document.getElementById("temperatureChart");

    if (!canvas)
        return;

    const labels =
        JSON.parse(canvas.dataset.labels);

    const temperatures =
        JSON.parse(canvas.dataset.temperatures);

    new Chart(canvas, {

        type: "line",

        data: {
            labels: labels,

            datasets: [{
                label: "Temperature °C",
                data: temperatures,
                tension: 0.3
            }]
        },

        options: {
            responsive: true
        }
    });

});
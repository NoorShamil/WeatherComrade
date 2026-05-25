// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", () => {

    const canvas =
        document.getElementById("temperatureChart");
    if (canvas) {
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
    }

    const weatherPage =
        document.querySelector(".weather-page");

    if (!weatherPage)
        return;

    const condition =
        weatherPage.dataset.weatherCondition?.toLowerCase();

    if (!condition)
        return;

    if (condition.includes("clear")) {
        weatherPage.classList.add("sunny-weather");
    }
    else if (condition.includes("rain")) {
        weatherPage.classList.add("rainy-weather");
    }
    else if (condition.includes("snow")) {
        weatherPage.classList.add("snowy-weather");
    }
    else if (condition.includes("cloud")) {
        weatherPage.classList.add("cloudy-weather");
    }
    else if (condition.includes("thunder")) {
        weatherPage.classList.add("storm-weather");
    }
    else {
        weatherPage.classList.add("default-weather");
    }
});

const tabs =
    document.querySelectorAll(".forecast-tab");

const contents =
    document.querySelectorAll(".forecast-day-content");

tabs.forEach(tab => {

    tab.addEventListener("click", () => {

        const target =
            tab.dataset.day;

        tabs.forEach(t =>
            t.classList.remove("active-tab"));

        contents.forEach(c =>
            c.classList.remove("active-day"));

        tab.classList.add("active-tab");

        document
            .getElementById(target)
            .classList.add("active-day");
    });

});
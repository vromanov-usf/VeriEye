document.addEventListener("DOMContentLoaded", () => {
    loadFraudInsights();
});

async function loadFraudInsights() {
    try {
        const response = await fetch("/data/ftcFraudInsights.json");

        if (!response.ok) {
            throw new Error("FTC fraud insight data could not be loaded.");
        }

        const data = await response.json();

        updateMetricCards(data.summary);
        renderCategoryChart(data.fraudReportsByCategory);
        renderLossChart(data.consumerLossesByYear);
        renderIdentityChart(data.identityTheftTrend);
    } catch (error) {
        console.error(error);
        document.getElementById("metricLosses").innerText = "$12.5B+";
        document.getElementById("metricReports").innerText = "2.6M+";
    }
}

function updateMetricCards(summary) {
    document.getElementById("metricLosses").innerText = summary.totalConsumerLosses;
    document.getElementById("metricReports").innerText = summary.totalFraudReports;
}

function renderCategoryChart(items) {
    const ctx = document.getElementById("categoryChart");

    new Chart(ctx, {
        type: "bar",
        data: {
            labels: items.map(item => item.category),
            datasets: [{
                label: "Reports",
                data: items.map(item => item.reports)
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: { display: false }
            },
            scales: {
                y: { beginAtZero: true }
            }
        }
    });
}

function renderLossChart(items) {
    const ctx = document.getElementById("lossChart");

    new Chart(ctx, {
        type: "line",
        data: {
            labels: items.map(item => item.year),
            datasets: [{
                label: "Consumer Losses in Billions",
                data: items.map(item => item.lossesInBillions),
                tension: 0.35,
                fill: true
            }]
        },
        options: {
            responsive: true,
            plugins: {
                tooltip: {
                    callbacks: {
                        label: context => "$" + context.raw + "B"
                    }
                }
            },
            scales: {
                y: { beginAtZero: true }
            }
        }
    });
}

function renderIdentityChart(items) {
    const ctx = document.getElementById("identityChart");

    new Chart(ctx, {
        type: "doughnut",
        data: {
            labels: items.map(item => item.type),
            datasets: [{
                label: "Identity Theft Reports",
                data: items.map(item => item.reports)
            }]
        },
        options: {
            responsive: true
        }
    });
}
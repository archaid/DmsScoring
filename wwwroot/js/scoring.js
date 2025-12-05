let rows = [];
let grouped = {};

document.addEventListener("DOMContentLoaded", loadRows);

// LOAD DEFAULT ROWS
async function loadRows() {
    const res = await fetch("/api/scoring/default-rows");
    rows = await res.json();

    // simpan nilai default F original
    rows.forEach(r => r.defaultF = r.bobotF);

    groupPreprocess();
    applyInitialSelection(); // item pertama per groupItem aktif
    renderTable();
    calculate();
}

// GROUP PREPROCESS
function groupPreprocess() {
    grouped = {};
    rows.forEach(r => {
        if (!grouped[r.group]) grouped[r.group] = {};
        if (!grouped[r.group][r.groupItem]) grouped[r.group][r.groupItem] = [];
        grouped[r.group][r.groupItem].push(r);
    });
}

// INITIAL: ITEM PERTAMA PER GROUP ITEM AKTIF
function applyInitialSelection() {
    Object.keys(grouped).forEach(group => {
        Object.keys(grouped[group]).forEach(groupItem => {
            const items = grouped[group][groupItem];

            items.forEach((row, idx) => {
                // hanya item pertama yang aktif pakai defaultF
                row.bobotF = (idx === 0) ? row.defaultF : 0;
            });
        });
    });
}

// RENDER TABLE
function renderTable() {
    const tbody = document.querySelector("#tblScoring tbody");
    tbody.innerHTML = "";

    const scrollY = window.scrollY;

    Object.keys(grouped).forEach(group => {
        const groupItems = grouped[group];
        const groupRowCount = Object.values(groupItems).flat().length;

        let firstGroupRow = true;

        Object.keys(groupItems).forEach(groupItem => {
            const items = groupItems[groupItem];
            const groupItemRowCount = items.length;
            let firstItemRow = true;

            items.forEach(r => {
                const tr = document.createElement("tr");

                // GROUP (rowspan) + BOBOT B (rowspan)
                if (firstGroupRow) {
                    tr.innerHTML += `
                        <td rowspan="${groupRowCount}" class="align-middle fw-bold bg-light">${group}</td>
                        <td rowspan="${groupRowCount}" class="align-middle">
                            <input type="number" step="0.01"
                                   class="form-control form-control-sm text-end inp-bobotB"
                                   data-group="${group}" value="${r.bobotB}">
                        </td>
                    `;
                }

                // GROUP ITEM (rowspan) + BOBOT D (rowspan)
                if (firstItemRow) {
                    tr.innerHTML += `
                        <td rowspan="${groupItemRowCount}" class="align-middle">${groupItem}</td>
                        <td rowspan="${groupItemRowCount}" class="align-middle">
                            <input type="number" step="0.01"
                                   class="form-control form-control-sm text-end inp-bobotD"
                                   data-group="${group}" data-groupitem="${groupItem}"
                                   value="${items[0].bobotD}">
                        </td>
                    `;
                }

                // ITEM
                tr.innerHTML += `
                    <td>${r.item}</td>
                `;

                // PILIH (RADIO) — per groupItem
                tr.innerHTML += `
                    <td class="text-center">
                        <input type="radio"
                               name="radio_${sanitize(group)}_${sanitize(groupItem)}"
                               class="inp-radioSelect"
                               data-id="${r.id}"
                               ${r.bobotF > 0 ? "checked" : ""}>
                    </td>
                `;

                // BOBOT F (INPUT)
                tr.innerHTML += `
                    <td>
                        <input type="number" step="0.01"
                               class="form-control form-control-sm text-end inp-bobotF"
                               data-id="${r.id}" value="${r.bobotF}">
                    </td>
                `;

                // BOBOT F * D
                tr.innerHTML += `
                    <td class="td-fd text-center"></td>
                `;

                // SUM H × BOBOT B (merge per GROUP)
                if (firstGroupRow) {
                    tr.innerHTML += `
                        <td rowspan="${groupRowCount}"
                            class="td-score-group text-center align-middle fw-bold"
                            data-group="${group}"></td>
                    `;
                }

                tbody.appendChild(tr);

                firstItemRow = false;
                firstGroupRow = false;
            });
        });
    });

    window.scrollTo(0, scrollY);
}

// HITUNG KE BACKEND
async function calculate() {
    const res = await fetch("/api/scoring/calculate", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ rows })
    });

    const calc = await res.json();
    applyScores(calc);
    renderSummary(calc);
}

// TARUH SCORE KE TABEL
function applyScores(calc) {
    const trs = document.querySelectorAll("#tblScoring tbody tr");
    let i = 0;

    // per-row FD (BOBOT F * BOBOT D)
    rows.forEach(r => {
        const fd = r.bobotF * (r.bobotD / 100);
        if (trs[i]) {
            const fdCell = trs[i].querySelector(".td-fd");
            if (fdCell) fdCell.innerText = fd.toFixed(2);
        }
        i++;
    });

    // per-group FINAL SCORE (SUM H × B)
    if (calc.groupSummaries) {
        calc.groupSummaries.forEach(g => {
            const cell = document.querySelector(
                `.td-score-group[data-group="${g.group}"]`
            );
            if (cell) {
                cell.innerText = g.finalScore.toFixed(2);
            }
        });
    }
}

// SUMMARY + TOTAL + RISK
function renderSummary(calc) {

    // RINGKASAN PER GROUP
    const summaryHtml = `
        <div class="summary-box mt-4">

            <div class="d-flex justify-content-between align-items-center mb-2">
                <h5 class="fw-bold mb-0">Ringkasan Per Group</h5>
                <span class="badge bg-info text-dark px-3 py-2">Summary Overview</span>
            </div>

            <table class="table table-sm summary-table mb-0">
                <thead>
                    <tr>
                        <th>Group</th>
                        <th>Total FD</th>
                        <th>Bobot B (%)</th>
                        <th>Final Score</th>
                    </tr>
                </thead>
                <tbody>
                    ${calc.groupSummaries.map(g => `
                        <tr>
                            <td class="summary-group-name">${g.group}</td>
                            <td>${g.totalFD.toFixed(2)}</td>
                            <td>${g.bobotB}</td>
                            <td class="summary-final-score">${g.finalScore.toFixed(2)}</td>
                        </tr>
                    `).join("")}
                </tbody>
            </table>
        </div>
    `;


    document.getElementById("summaryGroup").innerHTML = summaryHtml;


    // TOTAL AKHIR + RISK BADGE
    const risk = calc.riskCategory;
    const riskClassName =
        risk === "HIGH RISK" ? "text-risk-high" :
            risk === "MEDIUM RISK" ? "text-risk-medium" :
                "text-risk-low";

    document.getElementById("finalResult").innerHTML = `
        <div class="summary-box mt-3 text-center">
            <h4 class="fw-bold mb-1">Total Akhir</h4>
            <div class="display-6 fw-bold mb-2">${calc.totalFinalScore.toFixed(2)}</div>

            <div class="fs-3 fw-bold ${riskClassName}">
                ${calc.riskCategory}
            </div>
        </div>
    `;
}

function riskClass(risk) {
    if (risk === "HIGH RISK") return "text-risk-high";
    if (risk === "MEDIUM RISK") return "text-risk-medium";
    return "text-risk-low";
}

// EVENT HANDLER
document.addEventListener("input", e => {
    const t = e.target;

    // BOBOT B (per GROUP)
    if (t.classList.contains("inp-bobotB")) {
        rows.forEach(r => {
            if (r.group === t.dataset.group)
                r.bobotB = parseFloat(t.value) || 0;
        });
        calculate();
    }

    // BOBOT D (per GROUP ITEM)
    if (t.classList.contains("inp-bobotD")) {
        rows.forEach(r => {
            if (r.group === t.dataset.group && r.groupItem === t.dataset.groupitem)
                r.bobotD = parseFloat(t.value) || 0;
        });
        calculate();
    }

    // BOBOT F (manual edit per row)
    if (t.classList.contains("inp-bobotF")) {
        const row = rows.find(r => r.id == t.dataset.id);
        if (row) row.bobotF = parseFloat(t.value) || 0;
        calculate();
    }
});

// RADIO pakai change (bukan input)
document.addEventListener("change", e => {
    const t = e.target;

    if (t.classList.contains("inp-radioSelect")) {
        const id = parseInt(t.dataset.id);
        const selected = rows.find(r => r.id === id);
        if (!selected) return;

        // reset semua bobotF di groupItem yang sama
        rows.forEach(r => {
            if (r.group === selected.group && r.groupItem === selected.groupItem) {
                r.bobotF = 0;
                // sync ke input
                const fInput = document.querySelector(`.inp-bobotF[data-id="${r.id}"]`);
                if (fInput) fInput.value = 0;
            }
        });

        // item terpilih -> bobotF = defaultF
        selected.bobotF = selected.defaultF;
        const selectedInput = document.querySelector(`.inp-bobotF[data-id="${selected.id}"]`);
        if (selectedInput) selectedInput.value = selected.defaultF;

        calculate();
    }
});

// Helper
function sanitize(txt) {
    return String(txt || "").replace(/\s+/g, "_").replace(/[^\w]/g, "");
}

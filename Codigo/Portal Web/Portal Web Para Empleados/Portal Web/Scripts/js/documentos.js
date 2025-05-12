function formatFileSize(size) {
    const kb = size / 1024;
    const mb = kb / 1024;
    return mb > 1 ? mb.toFixed(1) + ' MB' : kb.toFixed(1) + ' KB';
}

function handleFileUpload(event) {
    const files = event.target.files;
    const list = document.getElementById("documentList");

    for (let file of files) {
        const item = document.createElement("div");
        item.className = "document-item";

        item.innerHTML = `
                    <div class="document-info">
                        <i class="fa-solid fa-file-pdf"></i>
                        <div class="document-text">
                            <div class="title">${file.name}</div>
                            <div class="details">PDF - ${formatFileSize(file.size)}</div>
                        </div>
                    </div>
                    <div class="document-actions">
                        <i class="fa-solid fa-download" title="Descargar" onclick="alert('Simulación de descarga: ${file.name}')"></i>
                        <i class="fa-solid fa-trash" title="Eliminar" onclick="this.closest('.document-item').remove()"></i>
                    </div>
                `;
        list.appendChild(item);
    }

    event.target.value = ''; // Limpiar input
}
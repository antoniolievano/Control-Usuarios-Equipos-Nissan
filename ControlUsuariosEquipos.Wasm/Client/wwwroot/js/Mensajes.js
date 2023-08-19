function mensaje(title, text, icon) {
    Swal.fire({
        title,
        text,
        icon,
    })
}

function confirmar(title, text, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sí',
            cancelButtonText: "Cancelar"
        }).then((result) => {
            resolve(result.isConfirmed)
        })
    })
}

function desarrollador() {
    Swal.fire({
        title: 'Datos de desarrollador',
        text: 'Víctor Antonio Gómez Liévano, ingeniero en sistemas computacionales',
        imageUrl: "images/LLM.png",
        imageWidth: 190,
        imageHeight: 220,
        imageAlt: 'LLM'
    })
}
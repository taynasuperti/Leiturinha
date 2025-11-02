document.addEventListener("DOMContentLoaded", function () {
    const stars = document.querySelectorAll('.star');
    const livroId = document.getElementById('livroId')?.value;

    if (!stars.length || !livroId) return;

    stars.forEach(star => {
        star.addEventListener('click', async function () {
            const nota = this.getAttribute('data-value');

            try {
                const response = await fetch('/Avaliacoes/Avaliar', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({ livroId, nota })
                });

                if (response.ok) {
                    highlightStars(nota);
                } else {
                    alert('Você precisa estar logado para avaliar este livro.');
                }
            } catch (error) {
                alert('Erro de conexão. Tente novamente mais tarde.');
            }
        });
    });

    function highlightStars(nota) {
        stars.forEach(s => {
            const icon = s.querySelector('i');
            if (s.getAttribute('data-value') <= nota) {
                icon.classList.remove('bi-star');
                icon.classList.add('bi-star-fill', 'text-warning');
            } else {
                icon.classList.remove('bi-star-fill', 'text-warning');
                icon.classList.add('bi-star');
            }
        });
    }
});

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
                    credentials: 'include',
                    body: JSON.stringify({ livroId, nota })
                });

                if (response.ok) {
                    highlightStars(nota);
                } else if (response.status === 401) {
                    alert('Você precisa estar logado para avaliar este livro.');
                } else {
                    alert('Erro ao registrar avaliação. Tente novamente.');
                }
            } catch (error) {
                alert('Erro de conexão. Tente novamente mais tarde.');
            }
        });
    });

    function highlightStars(nota) {
        stars.forEach(s => {
            const icon = s.querySelector('i');
            if (parseInt(s.getAttribute('data-value')) <= parseInt(nota)) {
                icon.classList.remove('bi-star');
                icon.classList.add('bi-star-fill', 'text-warning');
            } else {
                icon.classList.remove('bi-star-fill', 'text-warning');
                icon.classList.add('bi-star');
            }
        });
    }
});

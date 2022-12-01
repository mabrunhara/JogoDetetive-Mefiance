let senha = document.querySelector('#password');
    
    button.addEventListener('click', showHide); 
function showHide() {
    
    var num = '2733';
    
    if (senha.value ==num) {
       alert("Senha correta! Continue a desvendar.");
    } else {
        alert("Senha incorreta. Pesquise mais.");
    }
}
//CREAMOS EL OBJETO en otro ducmento a parte y en el script la usabilidad

var Matematicas = function (num) {
    this.numero = num; //No necesitamos pasarlo a int porque ya viene un número
    this.metodo = realizarDoble;
}

//FUNCION EXTERNA

function realizarDoble() {
    this.numero = this.numero * 2;
    document.getElementById("#out").innerHTML = this.numero;
}
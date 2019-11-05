//PARA REALIZAR ENXTENDS SE UTILIZA LA PALABRA PROTOTYPE
//SE AÑADEN MÉTODOS SOBRE LA CLASE
Array.prototype.contarElementos = function () {
    return this.length;
}
//UN METODO QUE EXISTE LO CAMBIAS 
//hace lo mismo pero cambia lo del dentro
//Lo sustituye
//extends funcionalidad que no tiene

Array.prototype.sumaElementos = function () {
    var suma = 0;
    for (var i = 0; i < this.length; i++) {
        suma += this[i];
    }
    return suma;
}
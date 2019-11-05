var ObjetoArray = function () {
    this.description = "Herencia de array de Jueves";
    this.contarElementos = function () {
        return this.length;
    };
    this.sumaElementos = function () {
        var suma = 0;
        for (var i = 0; i < this.length; i++) {
            suma += this[i];
        }
        return suma; 
    }
}

ObjetoArray.prototype = new Array();
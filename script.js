var n1 = document.getElementById("n1");
var op = document.getElementById("op")
var botao = document.getElementById("botao");
var resFinal = document.getElementById("resFinal");

botao.onclick = function() {
  fetch(`https://conversorback.thalesluiz2.repl.co/calculo?n1=${n1.value}&op=${op.value}`)

    .then(function(res) {
      return res.json()
    })

    .then(function(myJson) {
      resFinal.innerText = myJson.resultado
    })

}
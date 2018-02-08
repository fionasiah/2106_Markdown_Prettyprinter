function addText(event) {
  var textarea = document.getElementById("tooltest");
  var targ = event.target || event.srcElement;

  switch(targ.innerText){
    case "Bold":
          textarea.value += "****";
          break;
    case "Italic":
          textarea.value += "**";
          break;
    case "Underline":
          textarea.value += "____";
          break;
  }
}
// asdasdas

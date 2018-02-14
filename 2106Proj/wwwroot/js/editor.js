//function addText(event) {
//  var textarea = document.getElementById("tooltest");
//  var targ = event.target || event.srcElement;
//  //var targ = event.target || event.getElementById;

  

//  switch(targ.innerText){
//    case "Bold":
//          textarea.value += "****";
//          break;
//    case "Italic":
//          textarea.value += "**";
//          break;
//    case "Underline":
//          textarea.value += "____";
//          break;
//    case "Strikethrough":
//        textarea.value += "~~~~";
//        break;
//    case "BoldUnderline":
//        textarea.value += "**__**";
//        break;
//    case "H1":
//        textarea.value += "#";
//        break;
//    case "H2":
//        textarea.value += "##";
//        break;
//    case "H3":
//        textarea.value += "###";
//        break;
//    case "H4":
//        textarea.value += "####";
//        break;
//    case "H5":
//        textarea.value += "#####";
//        break;
//    case "H6":
//        textarea.value += "######";
//        break;
//    case "Unordered ":
//        textarea.value += "*Item1";
//        break;
//    case "Ordered":
//        textarea.value += "1.Item1";
//        break;
//    case "UnorderedSub":
//        textarea.value += "  Item1"
//        break;
//    case "OrderedSub":
//        textarea.value += "  1.Item1";
//        break;
//    case "BreakLine":
//        textarea.value += "  "
//        break;
//    case "ParaBreak":
//        textarea.value += "   ";
//        break;
//    case "Hyperlink":
//        textarea.value += "<A><A>";
//        break;
//    case "RedText":
//        textarea.value += "@@FF0000 Text Color @@";
//        break;
//    case "AlignLeft":
//        textarea.value += "<-Align Left</-";
//        break;
//    case "CenterAlign":
//        textarea.value += "<->Align Center<->";
//        break;
//    case "RightAlign":
//        textarea.value += "->Align Right-/>";
//        break;
//    case "Justify":
//        textarea.value += "<-->Justify<-->";
//        break;
//    case "Highlight":
//        textarea.value += "'Text Here'";
//        break;
    
    
//  }
//}
// asdasdas
$(function () {
    var textarea = document.getElementById("tooltest");

    $("#bold").click(function () {
        textarea.value += "**Bold Text Here**";
    });
    $("#italic").click(function () {
        textarea.value += "*Italic Text Here*";
    });
    $("#underline").click(function () {
        textarea.value += "__Underline Text Here__";
    });
    $("#strikethrough").click(function () {
        textarea.value += "~~Strikethrough Text Here~~";
    });
    $("#redtext").click(function () {
        textarea.value += "@@FF0000 Text Color @@";
    });
    $("#highlight").click(function () {
        textarea.value += "'Highlighted Text Here'";
    });
    $("#alignleft").click(function () {
        textarea.value += "*<-Align Left</-*";
    });
    $("#aligncenter").click(function () {
        textarea.value += "<->Align Center<->";
    });
    $("#alignright").click(function () {
        textarea.value += "->Align Left-/>";
    });
    $("#unorderedlist").click(function () {
        textarea.value += "*Item1\n*Item2";
    });
    $("#orderedlist").click(function () {
        textarea.value += "1. Item1\n2. Item2";
    });
});
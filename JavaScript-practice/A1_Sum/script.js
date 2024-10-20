// let number1=10
// let number2=13
// let sum=number1+number2;
// console.log("Sum: "+sum)
function Sum(){
    let number1 = parseFloat(document.getElementById('number1').value);
    let number2 = parseFloat(document.getElementById('number2').value);

    let sum=number1+number2;

    document.getElementById('result').innerText = "Sum: " + sum;

}
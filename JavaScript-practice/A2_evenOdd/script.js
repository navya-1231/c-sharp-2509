function result(){
    let number = parseFloat(document.getElementById('number').value);
    if (number%2==0){
        document.getElementById('result').innerText = "Even";
    }
    else{
        document.getElementById('result').innerText = "Odd";
    }
}
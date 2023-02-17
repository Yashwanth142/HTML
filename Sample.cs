html,input{
    font-family: sans-serif;
}
body{
    width: 100%;
    max-width: 600px;
    margin: 0px auto;
    padding: 2em;
    background-color: darkseagreen;
}

.headerContainer{
    display: flex;
    flex-flow: column wrap;
    align-content: center;
    background: tomato;
    font-weight: bold;
    margin-bottom: 20px;
}

form{
    margin-top: 50px;
    background-color: bisque;
}

div{
    margin-bottom: 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color:darkkhaki;
}

label,input,button{
    font-size: 16px;
    line-height: 1.5;
}
label{
    text-align: right;
    width: 30%;
    margin-right: 2%;
}

input{
    flex: auto;
}

button{
    width: 70%;
    margin: 0 auto;
}
error-output{
    font-size: 12px;
    font-style: italic;
    color: red;
}

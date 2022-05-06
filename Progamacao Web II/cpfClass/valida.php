<?php
    include('validaCPF.class.php');
    if($_POST['nome']!="" || $_POST['CPF']!="")
    {
        $nome=$_POST['nome'];
        $cpf=$_POST['CPF'];

        //criei um novo objeto
        $CPF = new CPF();

        //chamei o método com o novo objeto e verifiquei se ele é diferente de veridadeiro 
        if(($CPF -> verificaCPF($cpf)) != true)
        {
            //caso ele seja diferente de verdadeiro, o CPF vai ser validado
            echo "$nome, o seu CPF foi validado";
        }
        else
        {
            //se ele for igual a verdadeiro, o CPF vai ser validado.
            echo "$nome, o seu CPF não foi validado";
        }
    }
    else
    {
        echo "Você não informou alguma coisa";
    }
?>
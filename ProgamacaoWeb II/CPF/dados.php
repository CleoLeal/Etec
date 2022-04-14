<?php
    $n1=$_POST["n1"];
    $n2=$_POST["n2"];
    $n3=$_POST["n3"];
    $n4=$_POST["n4"];
    $n5=$_POST["n5"];
    $n6=$_POST["n6"];
    $n7=$_POST["n7"];
    $n8=$_POST["n8"];
    $n9=$_POST["n9"];

    if($n1=="" || $n2=="" || $n3=="" || $n4=="" || $n5=="" || $n6=="" || $n7=="" || $n8=="" || $n9=="")
    {
        echo "Você não escreveu nada! Volte e faça novamente!<br>";
        echo "<a href='formulario.html'>Voltar</a>";
    }
    else
    {
        $soma1=($n1*10)+($n2*9)+($n3*8)+($n4*7)+($n5*6)+($n6*5)+($n7*4)+($n8*3)+($n9*2);
        $d1=11-($soma1%11);
        if($d1==10 || $d1==11)
        {
            $d1=0;
        }
        $soma2=($n1*11)+($n2*10)+($n3*9)+($n4*8)+($n5*7)+($n6*6)+($n7*5)+($n8*4)+($n9*3)+($d1*2);
        $d2=11-($soma2%11);
        if($d2==10 || $d2==11)
        {
            $d2=0;
        }
        echo "O seu CPF completo é:<br><br>";
        echo $n1.$n2.$n3.".".$n4.$n5.$n6.".".$n7.$n8.$n9."-".$d1.$d2;
    }
?>
   



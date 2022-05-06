<?php
    class CPF
    {
        private $cpf;

        //Método da classe

        function verificaCPF($valor)
        {
            $this->CPF=$valor;
            for($i=0;$i<=11;$i++)
            {
                //modifiquei conventendo de string para inteiro.
                $n[$i+1]=(int)substr($this->CPF, $i, 1);
            }
            $soma1=($n[1]*10+$n[2]*9+$n[3]*8+$n[4]*7+$n[5]*6+$n[6]*5+$n[7]*4+$n[8]*3+$n[9]*2);
            $dgt1=11-($soma1%11);
            if($dgt1==10 || $dgt1==11)
            {
                $dgt1=0;
            }
            $soma2=($n[1]*11+$n[2]*10+$n[3]*9+$n[4]*8+$n[5]*7+$n[6]*6+$n[7]*5+$n[8]*4+$n[9]*3+$dgt1*2);
            $dgt2=11-($soma2%11);
            if($dgt2==10 || $dgt2==11)
            {
                $dgt2=0;
            }

            //criei uma variável para armazenar o 10 e o 11 número. e modifiquei os números de string para inteiro
            $dgtGet1 = (int)$n[10];
            $dgtGet2 = (int)$n[11];
            
            //verifico se ele dgt1 é diferente do dgtGet1 ou dgt2 é diferente do dgtGet2
            if($dgt1!=$dgtGet1 || $dgt2!=$dgtGet2)
            {
                //se eles forem diferentes, é verdade que está errado
                $erro=true;
            }
            else
            {
                //se eles forem iguais, é falso que está errado
                $erro=false;
            }
            return $erro;   
        }
    }
?>

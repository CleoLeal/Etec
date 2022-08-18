<!DOCTYPE html>
    <html lang="pt-br">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Página de cadastro</title>
    </head>
        <link rel="stylesheet" type="text/css" href="style.css" media="screen">
    <body>
        <form accept-charset="UTF-8" action="salvar.php" autocomplete="off" method="POST">
            <div class="font">E-mail:</div>
            <div class="input"><input type="email" name="email" maxlength="40"  require></div>
<br>
            <div class="font">Senha:</div>
            <div class="input"><input type="password" name="senha1" id="senha1" maxlength="40" required parttern="^(?=,*[a-z])(?=,*[A-Z])(?=,*[0-9]).{3,}$"></div>
<br>
            <div class="font">Confirmação de senha:</div>
            <div class="input"><input type="password" name="senha2" id="senha2" maxlength="40"></div>
<br>
            <div class="font">Nome:</div>
            <div class="input"><input type="nome" name="nome" maxlength="40"></div>
<br>
            <div class="font">Data de nascimento:</div>
            <div class="input"><input type="dtnc" name="dtnc" maxlength="40"></div>
<br>
            <button type="submit" name="enviar" id="enviar" class="botao">Enviar</button>
            <button type="reset" name="limpar" id="limpar" class="botao">Limpar</button>
        </form>
    </body>
</html>

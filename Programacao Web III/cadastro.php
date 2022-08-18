<!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Página de cadastro</title>
    </head>
        <link rel="stylesheet" type="text/css" href="syyle.css" media="screen">
    <body>
        <form accept-charset="UTF-8" action="salvar.php" autocomplete="off" method="POST">
            <table border="0">
            <tr>
                <td>E-mail:</td>
                <td><input type="email" name="email" id="email" require></td>
            </tr>  
            <tr>
                <td>Senha:</td>
                <td><input type="password" name="senha1" id="senha1"  required parttern="^(?=,*[a-z])(?=,*[A-Z])(?=,*[0-9]).{3,}$"></td>
            </tr>
            <tr>
                <td>Confirmação de senha:</td>
                <td><input type="password" name="senha2" id="senha2"  required parttern="^(?=,*[a-z])(?=,*[A-Z])(?=,*[0-9]).{3,}$"></td>
            </tr>
            <tr>
                <td>Nome:</td>
                <td><input type="text" name="nome" id="nome"></td>
            </tr>
            <tr>
                <td>Data de nascimento:</td>
                <td><input type="date" name="data" id="data"></td>
            </table>
<br>   
            <button type="submit" name="enviar" id="enviar" class="botao">Enviar</button>
        </form>
    </body>
</html>
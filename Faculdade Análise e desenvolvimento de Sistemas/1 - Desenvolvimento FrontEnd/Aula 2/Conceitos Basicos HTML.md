# Conceitos básicos do HTML

## O que é HTML

* Linguagem de Marcação de Hipertexto;

* Linguagem padrão criada para páginas da Web;

* Criada em 1991 pelo britânico Tim Berners-Lee e mantida pela W3C (World Wide Web Consortium);

* Decreve a estrutura básica do site;

* Consiste em uma série de elementos que informam ao navegador como exibir o conteúdo;

* O HTML através de seus elementos, define partes do conteúdo de uma página web indicando cada parte de sua estrutura como: "este é um título", "este é um parágrafo", " este é um link", etc. 

## Estutura básica de um código HTML

``` html

<!DOCTYPE html> <!-- Define que esse é um documento html  -->
<html lang="pt-br">  <!-- Define o idioma da página -->

<head> <!-- Dará informações para o navegador interpretar a página -->
    <meta charset="UTF-8">   <!-- Vai especificar a codificação de caracteres no documento, o "UTF-8" é o conjunto de carcteres universal -->
    <meta name="viewport" content="width=device-width, initial-scale=1.0">   <!-- Vai fornecer ao navegador instruções de como controlar e dimensionar, fazendo com que a página se adpte a tela de qualquer dispositivo -->
    <title>Document</title> <!-- Título da página -->
</head>

<body>  <!-- Onde fica todo o conteúdo visível da página  -->
    conteúdo
</body>

</html>
```

## Elementos básicos HTML

### Tags iniciais

* Título

As tags `<h1>` a `<h6>` são usadas para definir diferentes tamanhos de título. Onde `<h1>` define o título mais importante e `<h6>`, o título menos importante: `<h1> Meu primeiro título </h1>`

* Prágrafo

A tag `<p>` define um parágrafo. Os navegadores adicionam automaticamente uma única linha em branco antes e depois de cada elemento deste: `<p> Meu primeiro parágrafo </p>`

* Link

A tag `<a>`  define um hiperlink, que é usado para vincular uma página a outra ou uma âncora na mesma página. O atributo href desta tag define o destino do link. `<a href = "Link desejado"> Meu primeiro link </a>`

Exemplo

``` html

<!DOCTYPE html> 
<html lang="pt-br">  

<head> 
    <meta charset="UTF-8">  
    <meta name="viewport" content="width=device-width, initial-scale=1.0">   
    <title>Document</title>
</head>

<body> 
    <h1> Meu primeiro título </h1>
    <p>
        Meu primeiro parágrafo
        <a href = "https://www.link.com/"> </a>
    </p>
</body>

</html>
```

Referencia completa de tags HTML: [w3schools](https://www.w3schools.com/tags/default.asp)

## Semântica do HTML5

Um elemento semântico descreve claramente seu significado tanto para o navegador quanto pra o desenvolvedor. Deixando de ser nescessário usar `>div> </div>` para especificar toda a estrutura de uma página.
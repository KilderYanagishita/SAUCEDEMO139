#language: pt
@Loja
Funcionalidade: Selecionar Produto na Loja
    Cenario: Selecao de Produto com Sucesso
        Dado que acesso a pagina inicial do site
        Quando preecho o usuario como "standard_user"
        E a senha "secret_sauce" e clico no botao Login
        Entao exibe "Products" no Titulo da Selecao
        Quando adiciono o produto no "Sauce Labs Backpack" ao carrinho
        E clico no icone carrinho de compras
        Entao exibe a pagina do carrinho com a quantidade "1"
        E nome do produto "Sauce Labs Backpack"
        E o preco como "$29.99"
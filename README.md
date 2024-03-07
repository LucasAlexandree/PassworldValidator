
##### Validador de Senha
Este é um projeto de validação de senha que verifica se uma senha atende a determinados critérios. A senha é considerada válida se atender às seguintes definições:

Nove ou mais caracteres
Pelo menos 1 dígito
Pelo menos 1 letra minúscula
Pelo menos 1 letra maiúscula
Pelo menos 1 caractere especial (!@#$%^&*()-+)
Não possui caracteres repetidos dentro do conjunto
Espaços em branco não são considerados como caracteres válidos

##### Uso
Para usar este validador, basta chamar a função IsValid passando a senha como argumento. 

##### Estrutura do Projeto
O projeto é estruturado da seguinte forma:

PasswordValidator.sh: Contém a lógica de validação de senha.
example.sh: Um exemplo de como utilizar o validador.


##### Decisões de Projeto
O código foi projetado com foco em abstração, baixo acoplamento, extensibilidade e coesão. A estrutura modular permite fácil manutenção e adição de novas funcionalidades.

O validador utiliza expressões regulares e métodos específicos para cada critério de validação, proporcionando uma implementação limpa e legível.

##### Assunções e Premissas
Durante o desenvolvimento, assumi que caracteres especiais incluem apenas !@#$%^&*()-+. Além disso, espaços em branco não são considerados caracteres válidos.

##### Contato
Se surgirem dúvidas ou sugestões, sinta-se à vontade para abrir uma "Issue" no repositório ou entrar em contato via e-mail.

Obrigado por explorar este projeto!

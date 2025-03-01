# Controllers

No desenvolvimento web, os **controladores** (ou controllers) são componentes fundamentais para estruturar a lógica de uma aplicação, servindo como o intermediário entre as **rotas** e os **modelos** (dados) ou **visões** (componentes de interface). Eles ajudam a organizar e gerenciar o fluxo de dados e a lógica de negócio de maneira eficiente.

---

## **1. O que é um Controlador?**

Um controlador é uma entidade responsável por:

1. **Receber solicitações**: Processar as requisições feitas às rotas.
2. **Executar lógica de negócio**: Validar dados, interagir com modelos e processar resultados.
3. **Gerar respostas**: Retornar respostas ao cliente (HTML, JSON, etc.) ou renderizar visões.

### Exemplo Básico:

Em uma aplicação simples:

- **Rota:** `/users/1`
- **Controlador:** Busca o usuário no banco de dados e retorna os detalhes.
- **Resposta:** JSON com os dados do usuário.

---

## **2. Arquitetura MVC**

Os controladores são parte da **Arquitetura MVC (Model-View-Controller)**:

- **Model:** Representa os dados e a lógica de acesso a eles (ex.: banco de dados).
- **View:** A interface ou saída exibida ao usuário.
- **Controller:** A camada intermediária que processa a lógica e conecta os modelos às visões.

---

## **3. Funções do Controlador**

### **3.1 Receber Requisições**

O controlador recebe a solicitação HTTP feita por uma rota associada e extrai os dados necessários:

- **Parâmetros de Rota:** Dados passados na URL.
- **Query Params:** Dados enviados como parte da query string (`?key=value`).
- **Body:** Dados enviados no corpo da solicitação (ex.: JSON ou formulário).

### Exemplo:

```jsx

// Rota associada ao controlador
app.get('/users/:id', userController.getUser);

```

```jsx

// Controlador
const userController = {
    getUser: (req, res) => {
        const userId = req.params.id; // Captura o ID do usuário da rota
        res.send(`Buscando usuário com ID: ${userId}`);
    }
};

```

---

### **3.2 Processar Lógica de Negócio**

Os controladores manipulam dados ou realizam operações:

- Validação de entrada (ex.: checar se os dados fornecidos são válidos).
- Interação com o banco de dados por meio dos **modelos**.
- Aplicação de regras de negócio (ex.: verificar permissões ou calcular resultados).

### Exemplo com lógica de negócio:

```jsx

const userController = {
    getUser: async (req, res) => {
        const userId = req.params.id;
        try {
            const user = await UserModel.findById(userId); // Busca no banco de dados
            if (!user) {
                return res.status(404).send('Usuário não encontrado');
            }
            res.json(user); // Retorna o usuário encontrado
        } catch (error) {
            res.status(500).send('Erro ao buscar o usuário');
        }
    }
};

```

---

### **3.3 Gerar Respostas**

Os controladores formatam a resposta que será enviada ao cliente:

- **HTML:** Renderiza uma página (no caso de servidores com renderização).
- **JSON:** Retorna dados estruturados para APIs RESTful.
- **Erro:** Envia códigos de erro apropriados (404, 500, etc.).

### Exemplo de resposta JSON:

```jsx
const userController = {
    getUser: (req, res) => {
        const user = { id: 1, name: 'Adailson', age: 22 };
        res.json(user); // Retorna um objeto JSON com os dados do usuário
    }
};

```

---

## **4. Organização de Controladores**

Em aplicações maiores, é comum organizar controladores em arquivos ou módulos separados. Isso melhora a manutenibilidade do código.

### Estrutura de Pastas:

```

controllers/
    userController.js
    productController.js
routes/
    userRoutes.js
    productRoutes.js
models/
    userModel.js
    productModel.js

```

### Exemplo:

**userController.js**

```jsx
const UserModel = require('../models/userModel');

const userController = {
    getUser: async (req, res) => {
        const userId = req.params.id;
        const user = await UserModel.findById(userId);
        res.json(user);
    },
    createUser: async (req, res) => {
        const newUser = await UserModel.create(req.body);
        res.status(201).json(newUser);
    }
};

module.exports = userController;

```

**userRoutes.js**

```jsx
const express = require('express');
const router = express.Router();
const userController = require('../controllers/userController');

// Rotas associadas ao controlador
router.get('/:id', userController.getUser);
router.post('/', userController.createUser);

module.exports = router;

```

---

## **5. Boas Práticas para Controladores**

1. **Manter o controlador enxuto:**
    - Não sobrecarregue o controlador com lógica complexa.
    - Delegue lógica de negócios e interação com bancos de dados para os **modelos**.
2. **Reutilizar lógica com middlewares:**
    - Use middlewares para autenticação, validação e outras tarefas comuns.
3. **Seguir princípios RESTful:**
    - Nomeie métodos e rotas com base nas ações REST (`GET`, `POST`, etc.).
    - Exemplo:
        - `/users` → `GET`: Listar usuários.
        - `/users/:id` → `GET`: Detalhar usuário.
4. **Tratar erros corretamente:**
    - Retorne códigos de status apropriados (`400`, `404`, `500`, etc.).
    - Sempre capture exceções para evitar que erros não tratados derrubem o servidor.

---

## **6. Ferramentas e Frameworks Populares para Controladores**

1. **Node.js + Express:**
    - Controladores são definidos como funções associadas às rotas.
2. **Django (Python):**
    - Views atuam como controladores, conectando URLs a lógicas de negócio.
3. **Ruby on Rails:**
    - Os controladores são classes que seguem convenções pré-definidas.
4. **Spring Boot (Java):**
    - Usa anotação `@Controller` para definir controladores.

---

## **7. Diferenças entre Controladores no Backend e Frontend**

| Aspecto | Backend | Frontend |
| --- | --- | --- |
| **Propósito** | Processar lógica de negócio e dados | Gerenciar interações de interface |
| **Funções** | Validar, manipular e retornar dados | Atualizar estados e renderizar UI |
| **Exemplo** | Buscar dados no banco | Atualizar um componente React |

---

## **Resumo**

Os controladores desempenham um papel essencial no desenvolvimento web, conectando a entrada do usuário com a lógica da aplicação e a resposta final. Bem implementados, eles:

- Simplificam a organização do código.
- Facilitam a manutenção e escalabilidade.
- Garantem uma separação clara de responsabilidades.

Se você está desenvolvendo um web aplicativo, como o ensino de matrizes, os controladores seriam responsáveis por:

- Validar os dados das operações de matriz.
- Executar os cálculos necessários (como multiplicação ou inversão).
- Retornar os resultados para exibição ao usuário.
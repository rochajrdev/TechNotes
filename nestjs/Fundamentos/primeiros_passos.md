
# Primeiros Passos com NestJS

## 1. Linguagem

O NestJS é compatível com:
- **TypeScript** (recomendado) — com suporte completo a recursos modernos
- **JavaScript puro** — requer compilador Babel para usar recursos ES6+

O NestJS aproveita os recursos mais recentes das linguagens, oferecendo uma experiência melhorada com TypeScript.

---

## 2. Pré-requisitos

- **Node.js** versão 20 ou superior
- **npm** (incluído no Node.js)

Verifique sua versão:
```bash
node --version
npm --version
```

---

## 3. Instalação e Configuração

### 3.1 Instalar NestJS CLI

```bash
npm i -g @nestjs/cli
```

### 3.2 Criar um novo projeto

```bash
nest new project-name
```

Escolha o gerenciador de pacotes desejado quando solicitado (npm, yarn ou pnpm).

### 3.3 Opções adicionais

Para criar um projeto com recursos mais rigorosos de TypeScript:
```bash
nest new project-name --strict
```

Para pular a instalação de dependências:
```bash
nest new project-name --skip-install
```

---

## 4. Estrutura do Projeto

Após a criação, você encontrará a seguinte estrutura no diretório `src/`:

```
src/
├── app.controller.ts       # Controlador principal
├── app.controller.spec.ts  # Testes unitários do controlador
├── app.module.ts           # Módulo raiz da aplicação
├── app.service.ts          # Serviço principal
└── main.ts                 # Ponto de entrada da aplicação
```

### Descrição dos arquivos

| Arquivo | Descrição |
|---------|-----------|
| `app.controller.ts` | Controlador básico com uma única rota |
| `app.controller.spec.ts` | Testes unitários para o controlador |
| `app.module.ts` | Módulo raiz que organiza a aplicação |
| `app.service.ts` | Serviço com lógica de negócio |
| `main.ts` | Ponto de entrada e inicialização da aplicação |

---

## 5. Arquivo `main.ts`

O arquivo `main.ts` inicializa a aplicação NestJS:

```typescript
import { NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';

async function bootstrap() {
  const app = await NestFactory.create(AppModule);
  await app.listen(process.env.PORT ?? 3000);
}

bootstrap();
```

### Como funciona

- `NestFactory.create()` — Cria uma instância da aplicação NestJS
- `app.listen()` — Inicia o servidor HTTP
- `process.env.PORT ?? 3000` — Usa porta customizada ou padrão (3000)

### Opções avançadas

Para desabilitar o encerramento automático em caso de erro:
```typescript
const app = await NestFactory.create(AppModule, { abortOnError: false });
```

---

## 6. Plataformas HTTP Suportadas

O NestJS é agnóstico em relação à plataforma HTTP. Suporta nativamente:

### Express (Padrão)
- Framework web minimalista e popular
- Robusto e pronto para produção
- Muitos recursos da comunidade
- Instalado por padrão via `@nestjs/platform-express`

### Fastify
- Framework de alta performance
- Baixa latência e consumo de memória
- Ideal para aplicações que requerem máxima eficiência
- Requer instalação: `npm i @nestjs/platform-fastify`

### Usando Fastify

```typescript
import { NestFactory } from '@nestjs/core';
import { FastifyAdapter, NestFastifyApplication } from '@nestjs/platform-fastify';
import { AppModule } from './app.module';

async function bootstrap() {
  const app = await NestFactory.create<NestFastifyApplication>(
    AppModule,
    new FastifyAdapter(),
  );
  await app.listen(3000, '0.0.0.0');
}

bootstrap();
```

---

## 7. Executando a Aplicação

### Iniciar em modo produção

```bash
npm run start
```

A aplicação estará disponível em `http://localhost:3000/`

### Iniciar em modo desenvolvimento (com hot reload)

```bash
npm run start:dev
```

Monitora alterações e recompila automaticamente.

### Compilação otimizada com SWC (20x mais rápida)

```bash
npm run start -- -b swc
```

---

## 8. Análise de Código e Formatação

Todo projeto NestJS vem pré-configurado com:

- **ESLint** — Linter para análise de código
- **Prettier** — Formatador de código automático

### Verificar código com linter

```bash
npm run lint
```

### Corrigir automaticamente com ESLint

```bash
npm run lint -- --fix
```

### Formatar código com Prettier

```bash
npm run format
```

---

## 9. Dicas Importantes

> **Estrutura de Diretórios**: O NestJS encoraja manter cada módulo em seu próprio diretório dedicado para melhor organização.

> **TypeScript Rigoroso**: Use `--strict` para detecção mais rigorosa de erros de tipo.

> **SWC para Desenvolvimento**: Para desenvolvimento local, use SWC para compilações significativamente mais rápidas (até 20x).

---

## 10. Próximos Passos

Após a instalação, explore:
- Controladores e Roteamento
- Serviços e Injeção de Dependência
- Módulos
- Middlewares e Pipes
- Decoradores

Para mais informações, consulte a [documentação oficial do NestJS](https://docs.nestjs.com/)
# Docker - Visão Geral

## O que é o Docker?
O Docker é uma plataforma de software que permite criar, testar e executar aplicações em containers. Containers são ambientes leves e portáteis que garantem que o software seja executado de forma consistente, independentemente de onde seja executado, seja no seu computador, servidor ou na nuvem.

## Principais Conceitos

| Conceito       | Descrição                                                                 |
|----------------|---------------------------------------------------------------------------|
| **Containers** | Unidades leves e independentes que contêm tudo o que é necessário para rodar uma aplicação, como código, dependências e bibliotecas. |
| **Imagens (Images)** | Representação estática e imutável de um sistema de arquivos com o código e as dependências de uma aplicação. |
| **Dockerfile** | Um script de configuração usado para criar imagens Docker. Contém instruções para montar a imagem, como instalação de pacotes e configuração de variáveis de ambiente. |
| **Docker Compose** | Ferramenta para definir e rodar múltiplos containers de forma simples, configurados em um arquivo `docker-compose.yml`. |
| **Docker Hub** | Repositório oficial de imagens Docker, onde é possível encontrar imagens públicas ou fazer upload das suas próprias imagens. |
| **Volumes**    | Usados para persistir dados fora do container, garantindo que os dados não sejam perdidos quando o container for removido. |
| **Rede (Network)** | Docker permite a criação de redes virtuais para containers, facilitando a comunicação segura e eficiente entre eles. |

## Comandos Docker Básicos

| Comando               | Descrição                                                                |
|-----------------------|--------------------------------------------------------------------------|
| **docker build**       | Cria uma imagem a partir de um Dockerfile.                               |
| **docker run**         | Executa um container a partir de uma imagem.                             |
| **docker ps**          | Lista os containers em execução.                                         |
| **docker stop**        | Para um container em execução.                                           |
| **docker exec**        | Executa um comando dentro de um container em execução.                   |
| **docker rm**          | Remove um container.                                                    |
| **docker rmi**         | Remove uma imagem.                                                      |
| **docker-compose up**  | Inicia os serviços definidos no arquivo `docker-compose.yml`.           |
| **docker-compose down**| Para e remove os serviços definidos no arquivo `docker-compose.yml`.   |

## Benefícios do Docker

| Benefício            | Descrição                                                                 |
|----------------------|---------------------------------------------------------------------------|
| **Portabilidade**     | Docker permite que você execute sua aplicação em qualquer lugar.        |
| **Eficiência**        | Containers são leves e rápidos, consumindo menos recursos que máquinas virtuais. |
| **Isolamento**        | Cada container é isolado, evitando interferência entre aplicações.      |
| **Consistência**      | Garante que a aplicação seja executada de forma idêntica em diferentes ambientes. |

## Casos de Uso Comuns

| Caso de Uso                | Descrição                                                              |
|----------------------------|------------------------------------------------------------------------|
| **Desenvolvimento e Testes**| Facilita a criação de ambientes de desenvolvimento consistentes.      |
| **Microserviços**          | Ideal para arquiteturas baseadas em microserviços.                    |
| **CI/CD**                  | Integrado a pipelines de CI/CD para garantir consistência na implantação. |
| **Infraestrutura como Código** | Permite definir ambientes de infraestrutura em código.               |

## Conclusão
Docker é uma plataforma de containers poderosa, ideal para ambientes isolados e portáteis. Facilita o desenvolvimento, testes e implantação de aplicações de forma eficiente, escalável e consistente.

# Comandos de Navegação e Exploração no Terminal

A navegação eficiente é a base do trabalho no terminal. Entender como se mover pelo sistema de arquivos, visualizar seu conteúdo e encontrar o que você precisa rapidamente é o que torna o uso da linha de comando superior à interface gráfica.

---

## 1. Onde estou e como me mover (`pwd` e `cd`)

O sistema de arquivos do Linux é uma grande árvore, cujo topo é a raiz (`/`).

*   **`pwd`** (Print Working Directory): Mostra o caminho absoluto do diretório onde você está agora.
    ```bash
    pwd
    # Saída: /home/usuario/projetos
    ```

*   **`cd`** (Change Directory): Muda o diretório atual.
    *   **Caminho Absoluto:** Começa sempre da raiz (`/`). Ex: `cd /var/log/nginx`
    *   **Caminho Relativo:** A partir de onde você está. Ex: `cd src/components`

### Atalhos Ninja do `cd`:
*   `cd` ou `cd ~`: Volta imediatamente para sua pasta de usuário (Home).
*   `cd ..`: Sobe um nível (vai para o diretório pai). Para subir dois níveis: `cd ../..`
*   `cd -`: Retorna para o **último diretório que você estava**. Útil para ficar pulando entre duas pastas.
*   `cd /`: Vai direto para a raiz do sistema de arquivos.

---

## 2. Visualizando o Conteúdo (`ls` e `tree`)

O `ls` é provavelmente o comando que você mais vai digitar. Acostume-se a usar os sinalizadores (flags) para obter exatamente a informação que precisa.

*   **`ls`**: Lista arquivos e diretórios na pasta atual (esconde os ocultos).
*   **`ls -l`** (Long format): Mostra permissões, dono, tamanho e data de modificação.
*   **`ls -a`** (All): Mostra todos os arquivos, **incluindo os ocultos** (aqueles que começam com ponto, ex: `.bashrc`).
*   **`ls -la`** ou `ll`: Combina as duas opções acima (lista detalhada incluindo ocultos).
*   **`ls -h`** (Human readable): Trabalha junto com `-l`. Mostra os tamanhos em KB, MB, GB em vez de bytes puros (`ls -lh`).
*   **`ls -t`**: Ordena pela data de modificação (os mais recentes primeiro). `ls -lt` é excelente para achar o que você acabou de baixar ou editar.
*   **`ls -R`** (Recursive): Lista o conteúdo das subpastas também (cuidado em pastas muito grandes).

### O comando `tree`
Se não estiver instalado (`sudo apt install tree`), é uma ferramenta maravilhosa para visualizar a estrutura de pastas em formato de árvore.
```bash
tree
tree -L 2  # Mostra apenas até o nível 2 de profundidade
```

---

## 3. A Pilha de Diretórios (`pushd`, `popd`, `dirs`)

Para uso avançado, quando você está fazendo um script ou navegando por várias pastas distantes e quer manter uma "história" para voltar depois.

*   **`pushd /caminho`**: Vai para o caminho especificado, mas salva o diretório atual numa "pilha".
*   **`dirs -v`**: Lista todos os diretórios salvos na pilha.
*   **`popd`**: Retira o último diretório do topo da pilha e vai para ele.

---

## 4. O que é este arquivo? (`file` e `stat`)

Às vezes as extensões no Linux mentem ou não existem. 

*   **`file arquivo.ext`**: Analisa o cabeçalho do arquivo e te diz exatamente o que ele é (ex: "ASCII text", "PNG image data", "ELF 64-bit executable").
*   **`stat arquivo.txt`**: Mostra informações ultra detalhadas sobre o arquivo, incluindo datas exatas de acesso, modificação e alteração de status no sistema de arquivos.

---

## 5. Ferramentas Modernas de Exploração

Se você quer subir de nível, considere instalar alternativas mais modernas feitas em Rust que substituem as clássicas:

*   **`eza`** (ou o antigo `exa`): Um substituto moderno para o `ls` que traz cores melhores, ícones e integração com o status do Git por padrão.
    *   Exemplo: `eza --tree --level=2 -l`
*   **`zoxide`** (`z`): Um substituto inteligente para o `cd`. Ele aprende os diretórios que você mais acessa. Em vez de digitar `cd /home/user/projetos/backend/api`, você só precisa digitar `z api` e ele te leva lá na hora.
*   **`bat`**: Um clone do `cat` mas com syntax highlighting (cores de código) e paginação nativa (integração com o `less`). Excelente para "espiar" arquivos enquanto navega.

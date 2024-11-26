# TaskListAPI

TaskListAPI é uma API backend construída com **ASP.NET Core** para gerenciar tarefas de um aplicativo em **React Native**. Ela oferece endpoints para criar, listar e excluir tarefas, permitindo uma integração simples e eficiente com o aplicativo.

## Funcionalidades

- Adicionar novas tarefas com validação.
- Listar todas as tarefas ou buscar uma tarefa específica pelo ID.
- Excluir tarefas pelo ID com mensagens de confirmação.

## Endpoints

- **POST** `/api/task` - Adicionar uma nova tarefa.
- **GET** `/api/task` - Listar todas as tarefas.
- **GET** `/api/task/{id}` - Buscar uma tarefa pelo ID.
- **DELETE** `/api/task/{id}` - Excluir uma tarefa pelo ID.

Essa API foi projetada para fornecer suporte completo ao gerenciamento de tarefas no aplicativo React Native.

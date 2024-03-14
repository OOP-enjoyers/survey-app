# Платформа для проведения опросов и анкетирования

## Состав команды №8

- Кузнецов Артур Геннадьевич
- Бархатова Наталья Александровна
- Ребров Сергей Андреевич
- Власов Владислав Сергеевич
- Дущенко Даниил Александрович

## Доменные сущности

| Таблица            | Описание                                  | Поля                                                                                                                |
| ------------------ | ----------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `user`             | Пользователи                              | `id` (PK)<br>`role_id` (FK)<br>`full_name`<br>`email`<br>`password`                                                 |
| `survey`           | Опросы                                    | `id` (PK)<br>`title`<br>`description`<br>`status_id`                                                                |
| `question`         | Вопросы в опросах                         | `id` (PK)<br>`survey_id` (FK)<br>`question_type_id` (FK)<br>`title`<br>`description`<br>`is_necessary`<br>`answers` |
| `response`         | Ответы пользователей на вопросы           | `id` (PK)<br>`user_id` (FK)<br>`question_id` (FK)<br>`content`                                                      |
| `question_type`    | Типы вопросов                             | `id` (PK)<br>`title`                                                                                                |
| `role`             | Роли пользователей                        | `id` (PK)<br>`title`                                                                                                |
| `status`           | Статусы опросов                           | `id` (PK)<br>`title`                                                                                                |

## Диаграмма

![Диаграмма](https://i.postimg.cc/2SLrH4ft/2024-03-14-204145854.png)

## Описание API

### Добавление опроса
Запрос:
```
/api/v1/add_survey
```
Параметры:
```json
{
    "status_id": 1,
    "title": "SurveyTitle",
    "description": "SurveyDescription",
    "questions": [
        {
            "title": "QuestionTitle1",
            "description": "QuestionDescription1",
            "type_id": 1,
            "answers": [
                "Answer1",
                "Answer2"
            ]
        },
        {
            "title": "QuestionTitle2",
            "description": "QuestionDescription2",
            "type_id": 1,
            "answers": [
                "Answer1"
            ]
        }
    ]
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK",
    "content": {
        "survey_id": 1
    }
}
```
---
### Получение опроса по ID
Запрос:
```
/api/v1/get_survey
```
Параметры:
```json
{
    "survey_id": 1
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK",
    "content": {
        "status_id": 1,
        "title": "SurveyTitle",
        "description": "SurveyDescription",
        "questions": [
            {
                "title": "QuestionTitle1",
                "description": "QuestionDescription1",
                "type_id": 1,
                "answers": [
                    "Answer1",
                    "Answer2"
                ]
            },
            {
                "title": "QuestionTitle2",
                "description": "QuestionDescription2",
                "type_id": 1,
                "answers": [
                    "Answer1"
                ]
            }
        ]
    }
}
```
---
### Изменение опроса
Запрос:
```
/api/v1/edit_survey
```
Параметры:
```json
{
    "survey_id": 1,
    "status_id": 1,
    "title": "SurveyTitle",
    "description": "SurveyDescription",
    "questions": [
        {
            "title": "QuestionTitle1",
            "description": "QuestionDescription1",
            "type_id": 1,
            "answers": [
                "Answer1",
                "Answer2"
            ]
        },
        {
            "title": "QuestionTitle2",
            "description": "QuestionDescription2",
            "type_id": 1,
            "answers": [
                "Answer1"
            ]
        }
    ]
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK"
}
```
```json
{
    "status": 405,
    "message": "Method is not allowed when the survey is published"
}
```
---
### Удаление опроса
Запрос:
```
/api/v1/remove_survey
```
Параметры:
```json
{
    "survey_id": 1
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK"
}
```
---
### Добавление пользователя
Запрос:
```
/api/v1/add_user
```
Параметры:
```json
{
    "role_id": 1,
    "full_name": "UserFullname",
    "email": "UserEmail",
    "password": "UserPassword"
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK",
    "content": {
        "user_id": 1
    }
}
```
---
### Получение пользователя по ID
Запрос:
```
/api/v1/get_user
```
Параметры:
```json
{
    "user_id": 1
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK",
    "content": {
        "user_id": 1,
        "role_id": 1,
        "full_name": "UserFullname",
        "email": "UserEmail"
    }
}
```
---
### Изменение пользователя
Запрос:
```
/api/v1/edit_user
```
Параметры:
```json
{
    "user_id": 1,
    "role_id": 1,
    "full_name": "UserFullname",
    "email": "UserEmail",
    "password": "UserPassword"
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK"
}
```
---
### Удаление пользователя
Запрос:
```
/api/v1/remove_user
```
Параметры:
```json
{
    "user_id": 1
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK"
}
```
---
### Добавление ответов на опрос от пользователя
Запрос:
```
/api/v1/passing_survey
```
Параметры:
```json
{
    "survey_id": 1,
    "user_id": 1,
    "answers": [
        {
            "question_id": 1,
            "content": [
                "Answer1"
            ]
        },
        {
            "question_id": 2,
            "content": [
                "Answer1",
                "Answer2"
            ]
        }
    ]
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK"
}
```
---
### Получение ответов на опрос от пользователя
Запрос:
```
/api/v1/get_passing_survey
```
Параметры:
```json
{
    "survey_id": 1,
    "user_id": 1
}
```
Возвращает:
```json
{
    "status": 200,
    "message": "OK",
    "content": {
        "answers": [
            {
                "question_id": 1,
                "content": [
                    "Answer1"
                ]
            },
            {
                "question_id": 2,
                "content": [
                    "Answer1",
                    "Answer2"
                ]
            }
        ]
    }
}
```

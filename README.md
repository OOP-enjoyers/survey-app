# Платформа для проведения опросов и анкетирования

## Состав команды №8

- Кузнецов Артур Геннадьевич
- Бархатова Наталья Александровна
- Ребров Сергей Андреевич
- Власов Владислав Сергеевич
- Дущенко Даниил Александрович

## Доменные сущности

| Таблица            | Описание                                  | Поля                                                                                                |
| ------------------ | ----------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `user`             | Пользователи                              | `id`(PK)<br>`role_id`(FK)<br>`full_name`<br>`email`<br>`password`                                   |
| `survey`           | Опросы                                    | `id`(PK)<br>`title`<br>`description`<br>`status_id`                                                 |
| `question`         | Вопросы в опросах                         | `id`(PK)<br>`survey_id`(FK)<br>`question_type_id`(FK)<br>`title`<br>`description`<br>`is_necessary` |
| `question_type`    | Типы вопросов                             | `id`(PK)<br>`type_title`                                                                            |
| `question_answer`  | Ответы на вопросы                         | `id`(PK)<br>`question_id`(FK)<br>`is_right`<br>`content`                                            |
| `user_answer`      | Ответы пользователей на вопросы           | `id`(PK)<br>`user_id`(FK)<br>`question_answer_ids`(FK)<br>`content`                                 |
| `role`             | Роли пользователей                        | `id`(PK)<br>`title`                                                                                 |
| `status`           | Статусы опросов                           | `id`(PK)<br>`title`                                                                                 |

## Диаграмма

![Диаграмма](https://i.postimg.cc/02QhBM0X/erd.png)

## Описание API

### Создание опроса
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
                {
                    "content": "Answer1",
                    "is_right": false
                },
                {
                    "content": "Answer2",
                    "is_right": true
                }
            ]
        },
        {
            "title": "QuestionTitle2",
            "description": "QuestionDescription2",
            "type_id": 1,
            "answers": [
                {
                    "content": "Answer1",
                    "is_right": false
                }
            ]
        }
    ]
}
```
Возвращает:
```json
{
    "status": 200,
    "content": {
        "survey_id": 1
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
                {
                    "content": "Answer1",
                    "is_right": false
                },
                {
                    "content": "Answer2",
                    "is_right": true
                }
            ]
        },
        {
            "title": "QuestionTitle2",
            "description": "QuestionDescription2",
            "type_id": 1,
            "answers": [
                {
                    "content": "Answer1",
                    "is_right": false
                }
            ]
        }
    ]
}
```
Возвращает:
```json
{
    "status": 200
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
    "status": 200
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
    "status": 200
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
    "status": 200
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
            "content": "Answer1"
        },
        {
            "question_id": 2,
            "content": "Answer2"
        }
    ]
}
```
Возвращает:
```json
{
    "status": 200
}
```

# Introduction 
Esse projeto tem o intuito de implementar insites quanto a novas tecnologias a fim de produzir uma aplicacao SaaS que até o momtento te um foco de negocio desconhecido.

#Controle de Versao e Build
Esse projeto aplica continuous integration, o pull de commits é efetuado em 2 repositorios diferentes um no visual tfs online e outro no github
https://github.com/EarthW0rm/Northern-Lights.git

O projeto github é utilizado para integracao com o docker cloud.
https://hub.docker.com/r/earthworm013

No futuro pretendo havilitar o swarm para integrar a publicacao com o Azure.

#Modulos Propostos
1.  NorthernLights.ClientGate
    Esse modulo será responsável pela autenticacao de usuários;
2.  NorthernLigths.Enterprise
    Modulo para controle de contas de aplicativos e licencimento de usuários e nivel coorporativo;

# NorthernLights.ClientGate

## Tables
------
### oauth_access_tokens
```
+--------------+---------------+------+-----+---------+-------+
| Field        | Type          | Null | Key | Default | Extra |
+--------------+---------------+------+-----+---------+-------+
| access_token | varchar(40)   | NO   | PRI | NULL    |       |
| client_id    | varchar(80)   | YES  |     | NULL    |       |
| user_id      | varchar(80)   | YES  |     | NULL    |       |
| expires      | timestamp     | NO   |     | NULL    |       |
| scope        | varchar(4000) | YES  |     | NULL    |       |
+--------------+---------------+------+-----+---------+-------+
```
### oauth_authorization_codes
```
+--------------------+---------------+------+-----+---------+-------+
| Field              | Type          | Null | Key | Default | Extra |
+--------------------+---------------+------+-----+---------+-------+
| authorization_code | varchar(40)   | NO   | PRI | NULL    |       |
| client_id          | varchar(80)   | YES  |     | NULL    |       |
| user_id            | varchar(80)   | YES  |     | NULL    |       |
| redirect_uri       | varchar(2000) | NO   |     | NULL    |       |
| expires            | timestamp     | NO   |     | NULL    |       |
| scope              | varchar(4000) | YES  |     | NULL    |       |
| id_token           | varchar(1000) | YES  |     | NULL    |       |
+--------------------+---------------+------+-----+---------+-------+
```
### oauth_clients
```
+---------------+---------------+------+-----+---------+-------+
| Field         | Type          | Null | Key | Default | Extra |
+---------------+---------------+------+-----+---------+-------+
| client_id     | varchar(80)   | NO   | PRI | NULL    |       |
| client_secret | varchar(80)   | YES  |     | NULL    |       |
| redirect_uri  | varchar(2000) | YES  |     | NULL    |       |
| grant_types   | varchar(80)   | YES  |     | NULL    |       |
| scope         | varchar(4000) | YES  |     | NULL    |       |
| user_id       | varchar(80)   | YES  |     | NULL    |       |
+---------------+---------------+------+-----+---------+-------+
```
### oauth_jti
```
+----------+---------------+------+-----+---------+-------+
| Field    | Type          | Null | Key | Default | Extra |
+----------+---------------+------+-----+---------+-------+
| issuer   | varchar(80)   | NO   |     | NULL    |       |
| subject  | varchar(80)   | YES  |     | NULL    |       |
| audience | varchar(80)   | YES  |     | NULL    |       |
| expires  | timestamp     | NO   |     | NULL    |       |
| jti      | varchar(2000) | NO   |     | NULL    |       |
+----------+---------------+------+-----+---------+-------+
```
### oauth_jwt
```
+------------+---------------+------+-----+---------+-------+
| Field      | Type          | Null | Key | Default | Extra |
+------------+---------------+------+-----+---------+-------+
| client_id  | varchar(80)   | NO   |     | NULL    |       |
| subject    | varchar(80)   | YES  |     | NULL    |       |
| public_key | varchar(2000) | NO   |     | NULL    |       |
+------------+---------------+------+-----+---------+-------+
```
### oauth_public_keys
```
+----------------------+---------------+------+-----+---------+-------+
| Field                | Type          | Null | Key | Default | Extra |
+----------------------+---------------+------+-----+---------+-------+
| client_id            | varchar(80)   | YES  |     | NULL    |       |
| public_key           | varchar(2000) | YES  |     | NULL    |       |
| private_key          | varchar(2000) | YES  |     | NULL    |       |
| encryption_algorithm | varchar(100)  | YES  |     | RS256   |       |
+----------------------+---------------+------+-----+---------+-------+
```
### oauth_refresh_tokens
```
+---------------+------------------+------+-----+-------------------+-----------------------------+
| Field         | Type             | Null | Key | Default           | Extra                       |
+---------------+------------------+------+-----+-------------------+-----------------------------+
| refresh_token | varchar(40)      | NO   | PRI | NULL              |                             |
| client_id     | varchar(80)      | YES  |     | NULL              |                             |
| user_id       | varchar(80)      | YES  |     | NULL              |                             |
| expires       | timestamp        | NO   |     | CURRENT_TIMESTAMP | on update CURRENT_TIMESTAMP |
| scope         | varchar(4000)    | YES  |     | NULL              |                             |
+---------------+------------------+------+-----+-------------------+-----------------------------+
```
### oauth_scopes
```
+------------+-------------+------+-----+---------+-------+
| Field      | Type        | Null | Key | Default | Extra |
+------------+-------------+------+-----+---------+-------+
| scope      | varchar(80) | NO   | PRI | NULL    |       |
| is_default | tinyint(1)  | YES  |     | NULL    |       |
+------------+-------------+------+-----+---------+-------+
```
### oauth_users
```
+----------------+------------------+------+-----+---------+----------------+
| Field          | Type             | Null | Key | Default | Extra          |
+----------------+------------------+------+-----+---------+----------------+
| username       | varchar(80)      | YES  |     | NULL    |                |
| password       | varchar(80)      | YES  |     | NULL    |                |
| first_name     | varchar(80)      | YES  |     | NULL    |                |
| last_name      | varchar(80)      | YES  |     | NULL    |                |
| email          | varchar(2000)    | YES  |     | NULL    |                |
| email_verified | tinyint(1)       | YES  |     | NULL    |                |
| scope          | varchar(4000)    | YES  |     | NULL    |                |
+----------------+------------------+------+-----+---------+----------------+

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://www.visualstudio.com/en-us/docs/git/create-a-readme). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
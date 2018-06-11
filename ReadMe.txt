Para publicar o site é necessário seguir os seguintes passos:
1 - Abra o SQL Server no servidor apontando para o servidor desejado
2 - Execute o script BaseDados.sql no SQL Server para criação da base de dados, tabelas e procedures
3 - Abra o projeto no Visual Studio
4 - No arquivo web.config, atualizar a chave de configuração "connectionString" para apontar a configuração da base de dados
	- <add key="connectionString" value="Data Source=[Servidor];Initial Catalog=DB_CLIENTE;Integrated Security=True"/>
5 - Publicar o projeto no local desejado
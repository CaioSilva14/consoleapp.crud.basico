until /opt/mssql-tools/bin/sqlcmd -S sql-server -U sa -P AulaGeekJobs1 -Q "SELECT 1" &> /dev/null; do
	echo "Aguardando o servidor SQL ficar pronto..."
	sleep 5
done

echo "Iniciando a criacao da base de dados geekjobs..."
/opt/mssql-tools/bin/sqlcmd -S sql-server -U sa -P AulaGeekJobs1 -d master -i /tmp/scripts/script-criacao-database.sql
echo "Finalizando a criacao da base de dados geekjobs..."

echo "Iniciando a carga de dados na base de dados geekjobs..."
/opt/mssql-tools/bin/sqlcmd -S sql-server -U sa -P AulaGeekJobs1 -d geekjobs -i /tmp/scripts/carga-dados.sql
echo "Finalizando a carga de dados na base de dados geekjobs..."

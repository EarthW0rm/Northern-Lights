FROM microsoft/mssql-server-linux:2017-GDR
EXPOSE 1433

ENV MSSQL_SA_PASSWORD=p@ssw0rd
ENV ACCEPT_EULA=Y

COPY './create_databases.sql' /sql/create_databases.sql
RUN /opt/mssql/bin/sqlservr --accept-eula & sleep 10 \
  && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'p@ssw0rd' -i /sql/create_databases.sql


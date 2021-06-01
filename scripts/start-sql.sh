#!/bin/bash
# https://hub.docker.com/_/microsoft-mssql-server
# https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-configure-environment-variables?view=sql-server-2017

export PASSW='ddd20demoSQL-'
export CNAME=ddd-sql
export PORT=1466
export SLEEPSECS=15
parentdir="$(dirname "$(pwd)")"
export data="${parentdir}/data"
export IMGNM=mcr.microsoft.com/mssql/server:2017-CU21-ubuntu-16.04

docker stop ${CNAME} 2>/dev/null
docker rm ${CNAME} 2>/dev/null
docker pull ${IMGNM}
docker run --name=${CNAME} -v "/${data}:/data" -d -p $PORT:$PORT -e MSSQL_PID='Developer' -e MSSQL_SA_PASSWORD="${PASSW}" -e MSSQL_TCP_PORT=$PORT -e ACCEPT_EULA=Y  ${IMGNM} 

echo "SQL Running on Port: ${PORT}, waiting for sql to start for ${SLEEPSECS} seconds"

sleep ${SLEEPSECS}

export DCMD="docker exec -it ${CNAME} //opt/mssql-tools/bin/sqlcmd -S tcp:localhost,${PORT} -U sa -P ${PASSW}  -i //data/Restore.sql -o //tmp/restore.log"

echo "Restoring database *bicycle*"

winpty $DCMD
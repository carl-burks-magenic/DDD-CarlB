#!/bin/bash
export PASSW=ddd20demoSQL-
export CNAME=ddd-sql
export PORT=1466
export DCMD="docker exec -it ${CNAME} //opt/mssql-tools/bin/sqlcmd -S tcp:localhost,${PORT} -U sa -P ${PASSW}"
winpty $DCMD
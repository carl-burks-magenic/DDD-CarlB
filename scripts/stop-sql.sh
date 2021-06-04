#!/bin/bash
# https://hub.docker.com/r/microsoft/mssql-server-windows-express/
export CNAME=ddd-sql
docker stop ${CNAME} >/dev/null 2>&1
docker rm ${CNAME}   >/dev/null 2>&1
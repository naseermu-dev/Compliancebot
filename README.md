# ComplianceBot - AI Enterprise Compliance Agent

[![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![Angular](https://img.shields.io/badge/Angular-17-red)](https://angular.io/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-15-blue)](https://www.postgresql.org/)

**AI-powered system that automatically analyzes regulatory compliance requirements against company controls.**

## Steps for getting started

```bash
git clone https://github.com/naseermu-dev/ComplianceBot.git
cd ComplianceBot
./setup.sh
docker-compose up -d
dotnet run --project src/ComplianceBot.API
cd ComplianceBot-Frontend && ng serve

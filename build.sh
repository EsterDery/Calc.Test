#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

dotnet restore src/Calc.Test/ && \
    dotnet build src/Calc.Test/ && \
    echo "Now, run the following to start the project: dotnet run -p src/Calc.Test/Calc.Test.csproj --launch-profile web"
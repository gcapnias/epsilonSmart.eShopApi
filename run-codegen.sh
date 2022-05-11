#!/bin/bash
rm -rf eShopApi
mkdir -p eShopApi

# EpsilonSmart Eshop API
wget --no-check-certificate https://epsilonsmart6.epsilonnet.gr/swagger/Eshop/swagger.json -O eShopApi/swagger.json
java -jar swagger-codegen-cli.jar generate -i eShopApi/swagger.json -l csharp -o eShopApi --api-package Api --model-package Models -DpackageName='epsilonSmart.eShopApi'

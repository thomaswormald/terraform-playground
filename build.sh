cd HelloWorldLambda/HelloWorldLambda
dotnet lambda package -o ../../HelloWorldLambda.zip
cd ../..
terraform apply

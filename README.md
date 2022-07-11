# KCMicroservice

RabbitMQ -> service-to-service communication

$ docker run -d --hostname my-rabbit --name some-rabbit rabbitmq:3

Install tye 

$dotnet tool install -g Microsoft.Tye --version "0.11.0-alpha.22111.1"

Run Tye

$tye run --watch


Install Seq

docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest

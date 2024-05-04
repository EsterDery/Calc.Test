# Calc.Test - ASP.NET Core 2.0 Server

The API for the EatBacon IOT project

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/Calc.Test
docker build -t calc.test .
docker run -p 5000:5000 calc.test
```

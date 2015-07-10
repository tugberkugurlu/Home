First, build the docker file. `cd` into this path and:

```
sudo docker build -t hello-docker-app .
```

Once it's done, you have the image now:

```
sudo docker images
```

You can now run the docker image:

```
sudo docker run -t -d -p 4040:5004 hello-docker-app
```

You can verify that it's running:

```
sudo docker ps
```

If all looks OK, visit localhost:4040 on your docker host. From this point on, you can start and stop the container.


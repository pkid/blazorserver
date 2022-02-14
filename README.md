# blazorserver


 docker build -t dogsitter .  
 
 docker image tag dogsitter pkid/dogsitter:latest
 
 docker image push pkid/dogsitter:latest   
 
docker run -p 80:80 -e AWS_ACCESS_KEY_ID=${AWS_ACCESS_KEY_ID} -e AWS_SECRET_ACCESS_KEY=${AWS_SECRET_ACCESS_KEY}  -v ${PWD}/app/app.db:/app/app.db pkid/dogsitter

AWS_ACCESS_KEY_ID and AWS_SECRET_ACCESS_KEY is your s3 credentials

in your VM: mkdir app && touch /app/app.db

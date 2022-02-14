# blazorserver


 docker build -t dogsitter .  
 
 docker image tag dogsitter pkid/dogsitter:latest
 
 docker image push pkid/dogsitter:latest   
 
 docker run -p 80:80 -e AWS_ACCESS_KEY_ID=${AWS_ACCESS_KEY_ID} -e AWS_SECRET_ACCESS_KEY=${AWS_SECRET_ACCESS_KEY} pkid/dogsitter

AWS_ACCESS_KEY_ID and AWS_SECRET_ACCESS_KEY is your s3 credentials

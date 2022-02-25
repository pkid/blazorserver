# blazorserver
 
how to run locally:
* in your VM: mkdir app && touch app/app.db

* docker run -p 80:80 -p 443:443 -e SENDGRID_API_KEY=${SENDGRID_API_KEY} -e AWS_ACCESS_KEY_ID=${AWS_ACCESS_KEY_ID} -e AWS_SECRET_ACCESS_KEY=${AWS_SECRET_ACCESS_KEY}  -v ${PWD}/app/app.db:/app/app.db pkid/dogsitter

note: AWS_ACCESS_KEY_ID and AWS_SECRET_ACCESS_KEY is your s3 credentials, SENDGRID_API_KEY is the sendgrid api key


[Note] Every check-in to Master will build and push a new docker image! 


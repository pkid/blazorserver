echo "submitting to git"
git add -A
git commit -m "changes"
git push origin master

echo "builing and pushing Dockerfile"
docker build -t dogsitter .
docker image tag dogsitter pkid/dogsitter:latest
docker image push pkid/dogsitter:latest

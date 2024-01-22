# stop containers
docker stop litter-box-frontend
docker stop litter-box-backend
docker stop litter-box-db

# remove containers
docker rm litter-box-frontend
docker rm litter-box-backend
docker rm litter-box-db

# remove images
docker image rm dev-litter-box-frontend:latest
docker image rm dev-litter-box-backend:latest
docker image rm postgres
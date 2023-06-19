# Stage 1: Build the React application
FROM node:latest as build

WORKDIR /app

# Copy package.json and yarn.lock
COPY package.json yarn.lock ./

# Install dependencies
RUN yarn install

# Copy the rest of the application code
COPY . .

# Build the React application
RUN yarn build


# Stage 2: Serve the built React application using Nginx
FROM nginx:1.21

# Install Nginx
RUN apt-get update && apt-get install -y nginx

# Remove the default Nginx configuration
RUN rm /etc/nginx/conf.d/default.conf

# Copy the Nginx configuration file
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Copy the built React application from the previous stage
COPY --from=build /app/build /usr/share/nginx/html

# Expose port 3000 for HTTP
EXPOSE 3000

# Start Nginx server
CMD ["nginx", "-g", "daemon off;"]
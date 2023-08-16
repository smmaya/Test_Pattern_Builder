# Test_Pattern_Builder
Simple test pattern builder for Astrato manual epic/story comments.

How to creat a docker image and container:
1. Run Docker (daemon must be running)
2. Navigate to the projects location where you have your Dockerfile
3. type: docker build -t test-pattern-builder-image .
4. then: docker run -d -p 3005:80 --name test-pattern-builder-container test-pattern-builder-image (change the port to whatever you need)
5. Run the container and go to http://localhost:3005
6. Ta da ;) you can play with your application now.
